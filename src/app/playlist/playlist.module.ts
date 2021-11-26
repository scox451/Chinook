import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PlaylistRoutingModule } from './playlist-routing.module';
import { PlaylistComponent } from './playlist.component';
import { PlaylistDetailComponent } from './playlist-detail/playlist-detail.component';

import { SharedModule } from '@shared';

@NgModule({
  declarations: [
    PlaylistComponent,
    PlaylistDetailComponent
  ],
  imports: [
    CommonModule,
    PlaylistRoutingModule,
    SharedModule
  ]
})
export class PlaylistModule { }
