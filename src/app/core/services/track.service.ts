import { Injectable } from '@angular/core'
import { HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs'
import { TracksResult } from '@models';

@Injectable({
  providedIn: 'root',
})
export class TrackService {

  constructor(private http: HttpClient) { }

  getTracks(): Observable<TracksResult> {

    return this.http.get<TracksResult>(`https://localhost:5001/api/tracks`);

  }
}