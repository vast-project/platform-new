import { Component, Input } from '@angular/core';
import { Router } from '@angular/router';

@Component({
    selector: 'app-listing',
    templateUrl: './listing.component.html',
    styleUrls: ['./listing.component.css'],
    standalone: false
})
export class ListingComponent {
  @Input() itemsPerRow: number = 4;
  @Input() items: any[] = [];
  constructor(private router: Router) { }

  navigateToUrl(url: string): void {
    // Check if the URL is absolute
    if (this.isAbsoluteUrl(url)) {
      window.open(url, '_blank');
    } else {
      // Use Angular's router for relative URLs
      this.router.navigateByUrl(url);
    }
  }

  private isAbsoluteUrl(url: string): boolean {
    // A simple check to determine if the URL is absolute
    console.info("isAbsoluteUrl: " + url + " => " + /^(http|https):\/\//.test(url) + "")
    return /^(http|https):\/\//.test(url);
  }
}
