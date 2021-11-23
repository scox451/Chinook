import { Component, Input } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { debounceTime, distinctUntilChanged, switchMap } from 'rxjs';

import { TrackService } from '@services';
import { TrackDetails, TracksResult, Page } from '@models';
import { ColumnMode } from '@swimlane/ngx-datatable';

@Component({
  selector: 'app-home',
  templateUrl: `./home.component.html`,
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent {
  page:Page;
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
  ColumnMode = ColumnMode;;

  constructor(private fb: FormBuilder, private trackService: TrackService) { }

  ngOnInit(): void {
    this.page = new Page()
    this.setPage(this.page);
  }

  setPage(page) {
    this.page.offset = page.offset * page.limit;
    this.trackService.getTracks(page).subscribe((result: TracksResult) => {
      this.tracks = result.data;
      this.page = result.page;
    });
  }

  clear() { }

  search() { }
}

