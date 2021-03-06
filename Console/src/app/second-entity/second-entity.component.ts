
import {Component, OnInit, Inject} from '@angular/core';
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';

import { SecondEntity } from '@models'
import { SecondEntityDetailComponent } from './second-entity-detail/second-entity-detail.component';

export interface SecondEntityDetailData {
  mode: string;
  model:SecondEntity;
}

/**
 * @title Dialog Overview
 */
 @Component({
  selector: 'app-second-entity',
  templateUrl: './second-entity.component.html',
  styleUrls: ['./second-entity.component.scss']
})
export class SecondEntityComponent implements OnInit {


  mode: string;
  model: SecondEntity;

  constructor(public dialog: MatDialog ) {}

  ngOnInit(): void {

  }

  openDialog(): void {
    const dialogRef = this.dialog.open(SecondEntityDetailComponent, {
     // width: '500px',
     data: {mode: this.mode, model: this.model},
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
      this.model = result;
    });
  }
}

