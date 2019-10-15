import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class SkilService {
  
  
  constructor(private http: HttpClient) {   
    this.http = http;
  }
  listSkils(api){
    return this.http.get<JSON>(api);    
  }

  saveSkil(api, body){
    return this.http.post<JSON>(api, body);    
  }
}
