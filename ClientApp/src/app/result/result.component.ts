import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';
import { Router } from '@angular/router';
import { DataService } from '../data.service';

@Component({
  selector: 'app-result',
  templateUrl: './result.component.html',
  styleUrls: ['./result.component.css']
})
export class ResultComponent implements OnInit {
  result: any = {
    id: 0,
    title: 'Sample Result Title',
    description: 'Sample result description goes here.',
    tag: 'Sample Tag',
    url: '',
  };

  keywords: string[] = [
    'true statement',
    'abuse of power',
    'Power Dominance vs Benevolence Caring',
    'Power Dominance [C] vs Benevolence Caring [C]',
    'Universalism vs Security Societal',
    'Greed',
    'Cooperation',
    'Truth',
    'Knowledge',
    'Objectivity',
    'Validation',
    'Reliableness',
    'Empathy',
    'Loyalty',
    'Reward',
    'Punishment',
    'Social/Political Function of Art',
    'Love among Siblings',
    'Love/Marital Love',
    'Piety',
    'Curiosity',
    'Ingenuity',
    'Purity',
    'Appearance vs Reality',
    'Exclusion vs Respect of Minorities\nand Marginalised Communities',
    'Fate/Destiny vs Individual Law',
    'Imperialist/Civil War vs Local\nand International Peace',
    'Law of Gods/States',
    'Female Oppression and Devaluation vs\nFemale Emancipation and Autonomy',
    'Gender Equality vs Submission',
    'Rivalry vs Solidarity',
    'Justice/Fairness vs\nUnfairness/Abuse of Power',
    'Freedom vs Slavery',
    'Reason/Political Correctness vs\nPolitical Arbitrariness',
    'Demonstration vs Revelation',
    'Evidence vs Authority',
    'Autonomy vs Heteronomy',
    'Clarity vs Ambiguity',
    'Freedom of Speech vs Censorship',
    'Tradition vs Innovation',
    'Speculation vs Observation',
    'Rivalry vs Cooperation',
    'Violence vs Kindness',
    'Good vs Evil',
    'Right vs Wrong',
    'Punishment vs Reward',
    'Deceptiveness vs Honesty',
    'Gratitude vs Ingratitude',
    'Generosity vs Greed',
    'Vengeance vs Forgiveness',
    'Jealousy vs Selflessness',
    'Trust vs Distrust',
    'Loyalty vs Disloyalty',
    'Arrogance vs Modesty',
    'Obedience vs Defiance',
    'Sadness vs Happiness',
    'Shame vs Pride',
    'Individual vs Collective',
    'Guilt vs Innocence',
    'Male vs Female',

  ];

  concepts: string[] = [
    'Self-Direction Thought',
    'Conformity Rules',
    'Benevolence Caring',
    'Benevolence Dependability',
    'Conformity Interpersonal',
    'Self-Direction Action',
    'Power Dominance',
    'Power Resources',
    'Universalism Concern',
    'Universalism Tolerance',
    'Conformity',
    'Security',
    'Security - Personal',
    'Security - Societal',
    'Benevolence',
    'Universalism',
    'Self-Direction',
    'Tradition',
    'Universalism - Nature',
    'Hedonism',

  ];

  annotations: string[] = [
    'Antigone: "For me, it was not Zeus who made that order."',
    'Antigone: "I will bury him myself. And even if I die in the act, that death will be a glory."',
    'Ismene: "We are only women, We cannot fight with men, Antigone!"',
    'Chorus: "There is no happiness where there is no wisdom; No wisdom but in submission to the gods."',
    'Creon: "Better to fall from power, if fall we must, At the hands of a man - never be rated inferior to a woman, never."'
  ];

  constructor(
    private route: ActivatedRoute,
    private location: Location,
    private router: Router,
    private dataService: DataService,
  ) { }

  ngOnInit() {
    const id = parseInt(this.route.snapshot.paramMap.get('id') ?? "0", 10);

    this.dataService.getResultById(id).subscribe(
      result => {
        this.result = result;
      });
  }

  goBackToSearchResults(): void {
    this.location.back();
  }

  search(keywordOrConcept: string): void {
    this.router.navigate(['/search', keywordOrConcept]);
  }

  searchByTag(tag: string): void {
    this.router.navigate(['/search'], { queryParams: { tag } });
  }
}
