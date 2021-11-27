import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MaterialDemoRoutingModule } from './material-demo-routing.module';
import { MaterialDemoComponent } from './material-demo.component';

import { SharedModule } from '@shared'

@NgModule({
  declarations: [
    MaterialDemoComponent
  ],
  imports: [
    CommonModule,
    MaterialDemoRoutingModule,
    SharedModule
  ]
})
export class MaterialDemoModule { }
