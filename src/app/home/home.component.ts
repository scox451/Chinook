import { Component, Input } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { debounceTime, distinctUntilChanged, switchMap } from 'rxjs';

import { TrackService } from '@services';
import { TrackDetails ,TracksResult, Pagination} from '@models';

@Component({
  selector: 'app-home',
  templateUrl: `./home.component.html`,
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent {
  searchForm: FormGroup;
  firstNameField: FormControl = new FormControl();
  lastNameField: FormControl;

  results: TrackDetails[];
  displayMode:string ="";

  constructor(private fb: FormBuilder, private trackService: TrackService) {}

  ngOnInit(): void {
    this.initControls();
    this.trackService.getTracks().subscribe((result:TracksResult) => {
         this.results = result.data;
       });
    // this,this.displayMode="list-results";
    // this.firstNameField.valueChanges
    //   .pipe(
    //     distinctUntilChanged(),
    //     debounceTime(500),
    //     switchMap((filterText) => {
    //       if (!filterText) return;

    //       return this.trackService.getTracks();
    //     })
    //   )
    //   .subscribe((data:Track[]) => {
    //     this.results = data;
    //   });

    // this.imdbService.search("shawshank").subscribe(data=>{
    //   this.results = data.results;
    // });
  }

  initControls() {
    this.searchForm = this.fb.group({
      firstNameField: this.firstNameField,
      lastNameField: this.lastNameField,
    });
  }

  clear() {}

  search() {}
}
