import { Component, OnInit, AfterViewInit, ElementRef } from '@angular/core';
import { ArticleService } from '../article.service';
import { ActivatedRoute, Router } from '@angular/router';
import { DataService } from '../data.service';
import { EuValuesComponent } from '../eu-values/eu-values.component';
import { ChangeDetectorRef } from '@angular/core';
import { DomSanitizer } from '@angular/platform-browser';


@Component({
  selector: 'app-article',
  templateUrl: './article.component.html',
  styleUrls: ['./article.component.css']
})
export class ArticleComponent implements OnInit, AfterViewInit {
  article: any;
  id?: string;

  constructor(
    private route: ActivatedRoute,
    private dataService: DataService,
    private router: Router,
    private el: ElementRef,
    private cdRef: ChangeDetectorRef,
    private sanitizer: DomSanitizer
  ) { }

  ngOnInit() {
    this.route.paramMap.subscribe(params => {
      this.id = params.get('id') ?? undefined;

      const overrideId = this.route?.snapshot?.data['articleId']
      if (overrideId) {
        this.id = overrideId;
      }

      if (this.id) {
        this.dataService.getArticle(this.id).subscribe(results => {
          this.article = results;

          this.hideElementsInIframesAfterDataFetch();
        });
      } else {
        this.router.navigate(['/']);
      }
    });
  }

  sanitizeHtml(html: string) {
    return this.sanitizer.bypassSecurityTrustHtml(html);
  }

  ngAfterViewInit() {
    this.hideElementsInIframes();
  }

  private hideElementsInIframesAfterDataFetch() {
    // Use a timeout to allow the view to update
    setTimeout(() => {
        this.hideElementsInIframes();

        // Manually run change detection
        this.cdRef.detectChanges();
    });
}

  hideElementsInIframes() {
    // Get all iframes of type 'iframe-internal' using Angular's ElementRef
    const iframes = this.el.nativeElement.querySelectorAll('.internal-iframe');
    console.log(`Found ${iframes.length} iframes`);

    iframes.forEach((iframe: HTMLIFrameElement) => {
      // Check if iframe is loaded
      iframe.onload = () => {
        const idsToHide = ['g-top', 'g-navigation', 'g-slideshow', 'g-container-footer'];

        idsToHide.forEach(id => {
          console.log(`Checking iframe with src ${iframe.src} for element with id ${id}`);
          if (iframe.contentDocument) {
            const elementInsideIframe = iframe.contentDocument.querySelector(`section#${id}`) as HTMLElement;
            if (elementInsideIframe) {
              console.log(`Hiding element with id ${id} in iframe with src ${iframe.src}`);
              elementInsideIframe.style.display = 'none';
            }
          }
        });
      };
    });
  }
}
