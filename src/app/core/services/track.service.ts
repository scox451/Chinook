import { Injectable } from '@angular/core'
import { HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs'
import { Track } from '@models';

@Injectable({
  providedIn: 'root',
})
export class TrackService {

  constructor(private http: HttpClient) { }

  getTracks(): Observable<Track[]> {

    return this.http.get<Track[]>(`https://localhost:5001/chinook/api/tracks`);

  }
}