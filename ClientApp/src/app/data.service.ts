import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Observable, of } from 'rxjs';

interface SearchResult {
  id: number;
  title: string;
  description: string;
  tag: string;
  url: string;
}

@Injectable({
  providedIn: 'root'
})
export class DataService {
  private apiUrl = 'https://platform.vast-project.eu/api';
  private headers = new HttpHeaders().set('Content-Type', 'application/json');

  constructor(private http: HttpClient) { }


  getSampleData(): Observable<any> {
    const data = [{ "source": "Achievement", "target": "Power" }, { "source": "Benevolence", "target": "Security" }, { "source": "Conformity", "target": "Self-Direction" }, { "source": "Hedonism", "target": "Stimulation" }, { "source": "Power", "target": "Achievement" }, { "source": "Security", "target": "Benevolence" }, { "source": "Self-Direction", "target": "Conformity" }, { "source": "Stimulation", "target": "Hedonism" }, { "source": "Universalism", "target": "Tradition" }, { "source": "Tradition", "target": "Universalism" }, { "source": "Benevolence", "target": "Self-Transcendence" }, { "source": "Conformity", "target": "Achievement" }, { "source": "Hedonism", "target": "Universalism" }, { "source": "Power", "target": "Stimulation" }, { "source": "Security", "target": "Self-Direction" }, { "source": "Self-Transcendence", "target": "Benevolence" }, { "source": "Stimulation", "target": "Power" }, { "source": "Universalism", "target": "Hedonism" }, { "source": "Benevolence", "target": "Conformity" }, { "source": "Conformity", "target": "Security" }, { "source": "Hedonism", "target": "Achievement" }, { "source": "Power", "target": "Self-Direction" }, { "source": "Security", "target": "Universalism" }, { "source": "Self-Direction", "target": "Stimulation" }, { "source": "Self-Transcendence", "target": "Tradition" }];

    return of(data);
  }

  getSearchResults(query: string, filters: { [key: string]: string }): Observable<any> {
    let params = new HttpParams().set('query', query);
    for (const key in filters) {
      params = params.set(key, filters[key]);
    }

    return this.http.get<SearchResult[]>(`${this.apiUrl}/search`, { headers: this.headers, params: params });
  }

  getResultById(id: number): Observable<SearchResult> {
    const url = `${this.apiUrl}/search/${id}`;
    return this.http.get<SearchResult>(url, { headers: this.headers });
  }

  getArticle(id: string): Observable<any> {
    const url = `${this.apiUrl}/articles/${id}`;
    return this.http.get<any>(url, { headers: this.headers });
  }
}
