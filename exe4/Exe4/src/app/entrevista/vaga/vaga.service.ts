import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class VagaService {

  constructor(private http: HttpClient) {   
    this.http = http;
  }
  listVaga(api){
    return this.http.get<JSON>(api);    
  }
  saveVaga(api, body){    
    return this.http.post<JSON>(api, body);    
  }
}
