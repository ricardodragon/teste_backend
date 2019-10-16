import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ResultadoService {    
  constructor(private http: HttpClient) {   
    this.http = http;
  }
  listSkils(api){
    return this.http.get<JSON>(api);    
  }
}
