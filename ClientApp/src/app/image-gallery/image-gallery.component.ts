import { Component } from '@angular/core';

@Component({
  selector: 'app-image-gallery',
  templateUrl: './image-gallery.component.html',
  styleUrls: ['./image-gallery.component.css']
})
export class ImageGalleryComponent {
  images = [
    'https://placeimg.com/640/480/nature',
    'https://placeimg.com/640/480/arch',
    'https://placeimg.com/640/480/tech',
    'https://placeimg.com/640/480/people'
  ];
}
