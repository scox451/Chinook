import { Injectable } from '@angular/core';
import { HttpEvent, HttpInterceptor, HttpHandler, HttpRequest, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class CorsInterceptor implements HttpInterceptor {

  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    const userToken = 'secure-user-token';

    
    const modifiedReq = req.clone({ 
      setHeaders: {'content-type': 'application/json','Access-Control-Allow-Origin': '*'},
    });
    return next.handle(modifiedReq);
  }
}
