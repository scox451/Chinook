import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';

import { SharedModule } from '@shared';
import { TracksRoutingModule } from './tracks-routing.module';

import { TracksComponent } from './tracks.component';
//import { ViewDetailComponent } from './view-detail/view-detail.component';

@NgModule({
  declarations: [
    TracksComponent
  //  , ViewDetailComponent
  ],
  imports: [CommonModule, TracksRoutingModule, SharedModule]
})
export class TracksModule {}