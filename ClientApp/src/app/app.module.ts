import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { MatIconModule } from '@angular/material/icon';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { DirectionalGraphComponent } from './directional-graph/directional-graph.component';
import { SearchComponent } from './search/search.component';
import { ResultComponent } from './result/result.component';
import { ContentComponent } from './content/content.component';
import { ArticleComponent } from './article/article.component';
import { ImageGalleryComponent } from './image-gallery/image-gallery.component';
import { VideoComponent } from './video/video.component';
import { SafePipe } from './safe.pipe';
import { MapComponent } from './map/map.component';
import { SchwartzWheelComponent } from './schwartz-wheel/schwartz-wheel.component';
import { EuValuesComponent } from './eu-values/eu-values.component'; 


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    DirectionalGraphComponent,
    SearchComponent,
    ResultComponent,
    ContentComponent,
    ArticleComponent,
    ImageGalleryComponent,
    VideoComponent,
    SafePipe,
    MapComponent,
    SchwartzWheelComponent,
    EuValuesComponent 
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    MatIconModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'present/about', component: SearchComponent, pathMatch: 'full', data: { articleId: 'about' } },
      { path: 'present/search', component: SearchComponent, pathMatch: 'full' },
      { path: 'present/search/:query', component: SearchComponent },
      { path: 'present/result/:id', component: ResultComponent },
      { path: 'present/games', component: SearchComponent, pathMatch: 'full', data: { searchType: 'games' } },
      { path: 'present/services', component: SearchComponent, pathMatch: 'full', data: { searchType: 'services' } },
      { path: 'present/stats', component: SearchComponent, pathMatch: 'full', data: { searchType: 'stats' } },
      { path: 'present/success', component: SearchComponent, pathMatch: 'full', data: { searchType: 'success' } },
      { path: 'present/resources', component: SearchComponent, pathMatch: 'full', data: { searchType: 'resources' } },
      { path: 'present/campaigns', component: SearchComponent, pathMatch: 'full', data: { searchType: 'campaigns' } },
      { path: 'present/article/:id', component: ArticleComponent },
      { path: 'present/gallery/:id', component: ImageGalleryComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
