
import {Component, OnInit, Inject} from '@angular/core';
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';

import { FirstEntity } from '@models'
import { FirstEntityDetailComponent } from './first-entity-detail/first-entity-detail.component';

export interface FirstEntityDetailData {
  mode: string;
  model:FirstEntity;
}

/**
 * @title Dialog Overview
 */
 @Component({
  selector: 'app-first-entity',
  templateUrl: './first-entity.component.html',
  styleUrls: ['./first-entity.component.scss']
})
export class FirstEntityComponent implements OnInit {


  mode: string;
  model: FirstEntity;

  constructor(public dialog: MatDialog ) {}

  ngOnInit(): void {

  }

  openDialog(): void {
    const dialogRef = this.dialog.open(FirstEntityDetailComponent, {
     // width: '500px',
     data: {mode: this.mode, model: this.model},
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
      this.model = result;
    });
  }
}

