import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA,MatDialogContent,MatDialogActions } from '@angular/material/dialog';
import { Playlist } from '@models';
import { PlylistDetailData } from '../playlist.component';

@Component({
  selector: 'app-playlist-detail',
  templateUrl: './playlist-detail.component.html',
  styleUrls: ['./playlist-detail.component.scss']
})
export class PlaylistDetailComponent implements OnInit {
  mode: string;
  model:Playlist;

  constructor(
    public dialogRef: MatDialogRef<PlaylistDetailComponent>,
    @Inject(MAT_DIALOG_DATA) public data: PlylistDetailData,
  ) {
    this.mode = data.mode;
    this.model = data.model;

  }

  ngOnInit(): void {
  }

  onNoClick(): void {
    this.dialogRef.close();
  }
}
