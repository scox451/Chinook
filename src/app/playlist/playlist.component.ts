
import {Component, OnInit, Inject} from '@angular/core';
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';

import { Playlist } from '@models'
import { PlaylistDetailComponent } from './playlist-detail/playlist-detail.component';

export interface PlylistDetailData {
  mode: string;
  model:Playlist;
}

/**
 * @title Dialog Overview
 */
 @Component({
  selector: 'app-playlist',
  templateUrl: './playlist.component.html',
  styleUrls: ['./playlist.component.scss']
})
export class PlaylistComponent implements OnInit {


  mode: string;
  model:Playlist;

  constructor(public dialog: MatDialog ) {}

  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }

  openDialog(): void {
    const dialogRef = this.dialog.open(PlaylistDetailComponent, {
      width: '250px',
      panelClass: 'fullscreen-dialog',
      data: {mode: this.mode, model: this.model},
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
      this.model = result;
    });
  }
}

