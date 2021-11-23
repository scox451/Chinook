import { Injectable } from '@angular/core'
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable, of } from 'rxjs'
import { TracksResult } from '@models';

@Injectable({
  providedIn: 'root',
})
export class TrackService {

  constructor(private http: HttpClient) { }

  getTracks(page): Observable<TracksResult> {
        
    let params = {
      "limit": page.limit,
      "offset": page.offset
    }

    return this.http.get<TracksResult>(`https://localhost:5001/api/tracks`, { params:params } );

  }
}