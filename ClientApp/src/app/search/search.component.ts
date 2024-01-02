import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { DataService } from '../data.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {
  query: string = "";
  performedQuery: string = "";
  searchResults: any[] = [];
  filters: { [key: string]: string } = {}
;

  constructor(private route: ActivatedRoute, private dataService: DataService, private router: Router,) { }

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

    if (this.query || this.filters) {
      this.performSearch();
    }

  }

  performSearch() {
    this.dataService.getSearchResults(this.query, this.filters).subscribe(results => {
      this.performedQuery = this.query;
      this.searchResults = results;
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
