import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { DataService } from '../data.service';
import { Router } from '@angular/router';
import { ListingComponent } from '../listing/listing.component';

@Component({
    selector: 'app-search',
    templateUrl: './search.component.html',
    styleUrls: ['./search.component.css'],
    standalone: false
})
export class SearchComponent implements OnInit {
  query: string = "";
  performedQuery: string = "";
  searchResults: any[] = [];
  filters: { [key: string]: string } = {}
  itemsPerRow: number = 4;

  constructor(private route: ActivatedRoute, private dataService: DataService, private router: Router) { }

  ngOnInit() {
    //Get the parameters from the URL (if applicable)
    this.route.paramMap.subscribe(params => {
      this.query = params.get('query') ?? "";
    });

    //Get the custom data from the route
    const searchType = this.route?.snapshot?.data['searchType']
    if (searchType) {
      this.filters["type"] = searchType;
    }

    const bigParam = this.route?.snapshot?.data['big'];
    if (bigParam) {
      this.itemsPerRow = 2;
    } else {
      this.itemsPerRow = 4;
    }

    if (this.query || this.filters) {
      this.performSearch();
    }

  }

  /*
  performSearch() {
    this.dataService.getSearchResults(this.query, this.filters).subscribe(results => {
      this.performedQuery = this.query;
      this.searchResults = results;
    });
  }
  */

  performSearch() {
    this.dataService.getSearchResults(this.query, this.filters).subscribe(results => {
      this.performedQuery = this.query;
      this.searchResults = results.map((result: { smallImage: any; title: any; category: any; targetGroup: any; url: any; }) => ({
        imageUrl: result.smallImage || '/assets/background.jpg',
        title: result.title,
        category: result.category || 'VAST',
        targetGroup: result.targetGroup || '',
        url: result.url
      }));
    });
  }


  onEnter(event: KeyboardEvent) {
    if (event.key === "Enter") {
      this.performSearch();
    }
  }

  onSearchClick() {
    this.performSearch();
  }

  goToResult(url: string): void {
    this.router.navigate([url]);
  }
}
