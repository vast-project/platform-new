import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { DataService } from '../data.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {

  constructor(private route: ActivatedRoute, private dataService: DataService, private router: Router,) { }

  goToExplorer() {
    window.open('https://explore.vast-project.eu', "_blank");
  }

  goToOntology() {
    window.open('https://ontology.vast-project.eu', "_blank");
  }

  goToGames() {
    this.router.navigate(['/present/games']);
  }

  goToNews() {
    window.open("https://www.vast-project.eu/presentations-publications/", "_blank");
  }

  sendEmail(): void {
    const mailtoLink = `mailto:vast@vast-project.eu?subject=${encodeURIComponent("VAST Feedback")}`;
    window.open(mailtoLink, '_self');
  }
}
