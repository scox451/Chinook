import { Injectable } from '@angular/core'
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable, of } from 'rxjs'
import { TracksResult, Page } from '@models';

@Injectable({
  providedIn: 'root',
})
export class TrackService {

  constructor(private http: HttpClient) { }

  getTracks(page:Page): Observable<TracksResult> {
        
    return this.http.get<TracksResult>(`https://localhost:5001/api/tracks`, { "params": page as any } );

  }
}