import { Component, Input } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { debounceTime, distinctUntilChanged, switchMap } from 'rxjs';

import { TrackService } from '@services';
import { TrackDetails, TracksResult, Pagination } from '@models';

@Component({
  selector: 'app-home',
  templateUrl: `./home.component.html`,
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent {
  tracks: TrackDetails[];
  columns = [
    { prop: 'name' },
    {
      name: 'Albulm title',
      prop: 'albumTitle'
    },
    {
      name: 'Media type',
      prop: 'mediaTypeName'
    },
    {
      name: 'Genre',
      prop: 'genreName'
    },
    {
      name: 'Composer',
      prop: 'composer'
    }
  ];

  constructor(private fb: FormBuilder, private trackService: TrackService) { }

  ngOnInit(): void {
    // this.initControls();
    this.trackService.getTracks().subscribe((result: TracksResult) => {
      this.tracks = result.data;
    });
  }

  clear() { }

  search() { }
}
