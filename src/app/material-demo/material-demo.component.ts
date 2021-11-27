import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-material-demo',
  templateUrl: './material-demo.component.html',
  styleUrls: ['./material-demo.component.scss']
})
export class MaterialDemoComponent implements OnInit {
  
  allComplete:boolean;

  constructor() { }

  ngOnInit(): void {
    this.allComplete = true;
  }

}
