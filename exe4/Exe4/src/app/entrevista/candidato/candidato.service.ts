import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CandidatoService {

  constructor(private http: HttpClient) {   
    this.http = http;
  }
  listCandidatos(api){
    return this.http.get<JSON>(api);    
  }
  saveCandidato(api, body){    
    return this.http.post<JSON>(api, body);    
  }
}
