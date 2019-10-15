import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CandidatoDetalhesService {

  constructor(private http: HttpClient) {   
    this.http = http;
  }
  listCandidato(api){
    return this.http.get<JSON>(api);    
  }

  listSkils(api){
    return this.http.get<JSON>(api);    
  }

  updateCandidato(api, body){    
    return this.http.post<JSON>(api, body);    
  }
  saveCandidatoSkil(api, body){    
    return this.http.post<JSON>(api, body);    
  }
}
