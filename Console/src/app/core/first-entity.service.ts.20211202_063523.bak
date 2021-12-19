import { Injectable } from '@angular/core'
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable, of } from 'rxjs'
import { FirstEntityDetail, Page } from '@models';

@Injectable({
  providedIn: 'root',
})
export class ~!pacal!~Service {

  constructor(private http: HttpClient) { }

  get~!plural-pacal!~(page:Page): Observable<~!pacal!~Detail> {
        
    return this.http.get<FirstEntityDetail>(`https://localhost:5001/api/first-entity/GetFirstEntity`, { "params": page as any } );

  }
}