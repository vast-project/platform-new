import { Component, OnInit, ElementRef, NgZone, OnDestroy } from '@angular/core';
import * as d3 from 'd3';

@Component({
  selector: 'app-schwartz-wheel',
  template: '',
  styleUrls: ['./schwartz-wheel.component.css']
})
export class SchwartzWheelComponent implements OnInit, OnDestroy {

  private hostElement; // Native element hosting the SVG container
  private svg?: d3.Selection<SVGSVGElement, unknown, null, undefined>; // Top level SVG element
  private width: number = 600;
  private height: number = 400;
  private data = [
    // ... Your data transformed into a suitable format for D3
  ];

  constructor(private elRef: ElementRef, private ngZone: NgZone) {
    this.hostElement = this.elRef.nativeElement;
  }

  ngOnInit() {
    this.ngZone.runOutsideAngular(() => this.createChart());
  }

  ngOnDestroy() {
    // Clean up chart if needed
  }

  private createChart() {
    this.removeExistingChartFromParent();
    this.setChartDimensions();
    this.createSvgDrawArea();
    this.drawChart();
  }

  private removeExistingChartFromParent() {
    // Remove existing chart if there's one
    d3.select(this.hostElement).select('svg').remove();
  }

  private setChartDimensions() {
    this.width = this.hostElement.offsetWidth;
    this.height = this.hostElement.offsetHeight;
  }

  private createSvgDrawArea() {
    this.svg = d3.select(this.hostElement).append('svg')
      .attr('width', this.width)
      .attr('height', this.height);
  }

  private drawChart() {
    // Implement the D3 drawing code here
    // Use the D3 update pattern (enter, update, exit) to draw the values wheel
    // Add interactivity such as tooltips for mouseover events
  }
}
