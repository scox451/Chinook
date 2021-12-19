import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA,MatDialogContent,MatDialogActions } from '@angular/material/dialog';

import { SecondEntityService } from '@services'

import { SecondEntity } from '@models';
import { SecondEntityDetailData } from '../second-entity.component';

@Component({
  selector: 'app-second-entity-detail',
  templateUrl: './second-entity-detail.component.html',
  styleUrls: ['./second-entity-detail.component.scss']
})
export class SecondEntityDetailComponent implements OnInit {
  mode: string;
  model:SecondEntityDetail;
  
   secondEntityDetailForm: FormGroup;
   column1Field: FormControl = new FormControl({ value: null, disabled: false } );
column2Field: FormControl = new FormControl({ value: null, disabled: false } );
column3Field: FormControl = new FormControl({ value: null, disabled: false } );
column4Field: FormControl = new FormControl({ value: null, disabled: false } );
column5Field: FormControl = new FormControl({ value: null, disabled: false } );
column6Field: FormControl = new FormControl({ value: null, disabled: false } );
column7Field: FormControl = new FormControl({ value: null, disabled: false }, [Validators.required] );
column8Field: FormControl = new FormControl({ value: null, disabled: false }, [Validators.required] );
column9Field: FormControl = new FormControl({ value: null, disabled: false }, [Validators.required] );


  constructor(
    public dialogRef: MatDialogRef<SecondEntityDetailComponent>,
    @Inject(MAT_DIALOG_DATA) public data: SecondEntityDetailData,
	
  ) {
    this.mode = data.mode;
    this.model = data.model;

  }

  ngOnInit(): void {
  
  this.initControls();
  this.mapControls();
  
  }
  
  initControls(){
   column1Field: this.column1Field,
 column2Field: this.column2Field,
 column3Field: this.column3Field,
 column4Field: this.column4Field,
 column5Field: this.column5Field,
 column6Field: this.column6Field,
 column7Field: this.column7Field,
 column8Field: this.column8Field,
 column9Field: this.column9Field
  }
  
  mapControls(){
  this.column1Field.setValue(this.model.column1);
this.column2Field.setValue(this.model.column2);
this.column3Field.setValue(this.model.column3);
this.column4Field.setValue(this.model.column4);
this.column5Field.setValue(this.model.column5);
this.column6Field.setValue(this.model.column6);
this.column7Field.setValue(this.model.column7);
this.column8Field.setValue(this.model.column8);
this.column9Field.setValue(this.model.column9);

  }
  
  mapValues(){
  this.model.column1=this.column1Field.value;
this.model.column2=this.column2Field.value;
this.model.column3=this.column3Field.value;
this.model.column4=this.column4Field.value;
this.model.column5=this.column5Field.value;
this.model.column6=this.column6Field.value;
this.model.column7=this.column7Field.value;
this.model.column8=this.column8Field.value;
this.model.column9=this.column9Field.value;

  }
  
  close(): void {
    this.dialogRef.close();
  }
  
  save(): void {
  
    this.mapValues();
  
    this.dialogRef.close();
  }
}
