import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;
  searchQuery: string = '';

  constructor(
    private router: Router,
  ) { }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  onSearch() {
    this.router.navigate(['/present/search', this.searchQuery]);
  }

  goToGraph() {
    window.location.href = "https://graph.vast-project.eu";
  }
}
