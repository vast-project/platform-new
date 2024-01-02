import { Component, OnInit, OnDestroy, ElementRef, NgZone, Input } from '@angular/core';
import * as L from 'leaflet';

interface Marker {
  Latitude: number;
  Longitude: number;
  Title: string;
  Description: string;
  Link: string;
}

interface MapStruct {
  Latitude: number;
  Longitude: number;
  Zoom: number;
  Markers: Marker[];
}


@Component({
  selector: 'app-map',
  templateUrl: './map.component.html',
  styleUrls: ['./map.component.css']
})
export class MapComponent implements OnInit, OnDestroy {

  private map!: L.Map;

  // Input property to accept marker data
  @Input() mapdata?: MapStruct;

  constructor(private ngZone: NgZone, private elementRef: ElementRef) {}

  ngOnInit(): void {
    this.initMap();
    this.addMarkers();
  }

  ngOnDestroy(): void {
    if (this.map) {
      this.map.remove();
    }
  }

  private initMap(): void {
    this.ngZone.runOutsideAngular(() => {
      const el = this.elementRef.nativeElement.querySelector('#map');
      this.map = L.map(el).setView([50.000, 10.000], 5);
      L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png').addTo(this.map);
    });
  }

  private addMarkers(): void {
    this.mapdata?.Markers.forEach(markerData => {
      const marker = L.marker([markerData.Latitude, markerData.Longitude]).addTo(this.map);
      const popupContent = `
        <h3>${markerData.Title}</h3>
        <p>${markerData.Description}</p>
        <a href="${markerData.Link}" target="_blank">Read More</a>
      `;
      marker.bindPopup(popupContent);
    });
  }
}
