import { Component, Input, OnInit } from '@angular/core';
import * as d3 from 'd3';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { DataService } from '../data.service';



@Component({
  selector: 'directional-graph',
  templateUrl: './directional-graph.component.html',
  styleUrls: ['./directional-graph.component.css']
})
export class DirectionalGraphComponent implements OnInit {


  path: any;
  circle: any;
  drag: any;

  constructor(private httpClient: HttpClient, private dataService: DataService) {}

  ngOnInit() {

  }


  ngAfterContentInit(): void {
    // get the data

    this.dataService.getSampleData().subscribe((data : any) => {

      //data = data.slice(0,100);
      var csvnodes: any[] = [];
      var index = 0;

      // Compute the distinct nodes from the links.
      data.forEach((link: any) => {
        var existsSource = false;
        var existsTarget = false;

        csvnodes.forEach((element: any) => {
          if (element["id"] == link.source) {
            existsSource = true;
          }
          if (element["id"] == link.target) {
            existsTarget = true;
          }
        });

        if (!existsSource) {
          csvnodes.push({ id: link.source });
        }

        if (!existsTarget) {
          csvnodes.push({ id: link.target });
        }

        index++;

      });

      var width = document.querySelectorAll(".directional-graph-container")[0]?.clientWidth ?? 0;
      var height = document.querySelectorAll(".directional-graph-container")[0]?.clientHeight ?? 0;


      var charge_force = d3.forceManyBody()
        .strength(-100);

      var center_force = d3.forceCenter(width / 2, height / 2);

      var simulation = d3.forceSimulation()
        .nodes(csvnodes)
        .force('link', d3.forceLink(data).id((d: any) => d.id).distance(220))
        .force('charge', d3.forceManyBody().strength(-250))
        .force('x', d3.forceX(width / 2))
        .force('y', d3.forceY(height / 2))
        .on('tick', () => this.tick());


      var svg = d3.select(".graph-wrapper").append("svg")
        .attr("width", width)
        .attr("height", height)
        .style("background-color", "transparent");

      // build the arrow.
      svg.append("svg:defs").selectAll("marker")
        .data(["end"])      // Different link/path types can be defined here
        .enter().append("svg:marker")    // This section adds in the arrows
        .attr("id", String)
        .attr("viewBox", "0 -5 10 10")
        .attr("refX", 15)
        .attr("refY", -1.5)
        .attr("markerWidth", 6)
        .attr("markerHeight", 6)
        .attr("orient", "auto")
        .append("svg:path")
        .attr("d", "M0,-5L10,0L0,5");

      // add the links and the arrows
      this.path = svg.append("svg:g").selectAll("path")
        .data(data)
        .enter().append("svg:path")
        //    .attr("class", function(d) { return "link " + d.type; })
        .attr("class", "link")
        .attr("marker-end", "url(#end)");


      // init D3 drag support
      this.drag = d3.drag()
        .on('start', (event: any, d: any) => {
          
          //if (!event.active) simulation.alphaTarget(0.3).restart;
          simulation.alphaTarget(0).restart();
          simulation.alphaTarget(0.3).restart;
          d.x = d.x;
          d.y = d.y;
        })
        .on('drag', (event: any, d: any) => {
          d.x = event.x;
          d.y = event.y;
        })
        .on('end', (event: any, d: any) => {
          simulation.alphaTarget(0).restart();
        });

      // define the nodes
      this.circle = svg.selectAll(".node")
        .data(csvnodes)
        .enter().append("g")
        .attr("class", "node")
        .call(this.drag);

      // add the nodes
      this.circle.append("circle")
        .attr("r", 5);

      // add the text 
      this.circle.append("text")
        .attr("x", 12)
        .attr("dy", ".35em")
        .text((d: any) => { return d.id; });

      //simulation.alphaTarget(0.3).restart();
      simulation.alphaTarget(0).restart();

    })

  }

  dragstarted() {
  }
  dragged(d: any) {
  }
  dragended(d: any) {
  }

  // update force layout (called automatically each iteration)
  tick() {
    // draw directed edges with proper padding from node centers
    this.path.attr('d', (d: any) => {
      const deltaX = d.target.x - d.source.x;
      const deltaY = d.target.y - d.source.y;
      const dist = Math.sqrt(deltaX * deltaX + deltaY * deltaY);
      const normX = deltaX / dist;
      const normY = deltaY / dist;
      const sourcePadding = d.left ? 17 : 12;
      const targetPadding = d.right ? 17 : 12;
      const sourceX = d.source.x + (sourcePadding * normX);
      const sourceY = d.source.y + (sourcePadding * normY);
      const targetX = d.target.x - (targetPadding * normX);
      const targetY = d.target.y - (targetPadding * normY);

      //return `M${sourceX},${sourceY}L${targetX},${targetY}`;
      return "M" +
        d.source.x + "," +
        d.source.y + "A" +
        dist + "," + dist + " 0 0,1 " +
        d.target.x + "," +
        d.target.y;
    });

    this.circle.attr('transform', (d: any) => `translate(${d.x},${d.y})`);
  }

}
