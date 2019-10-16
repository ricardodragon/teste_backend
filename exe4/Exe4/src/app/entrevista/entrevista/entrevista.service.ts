import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class EntrevistaService {
    constructor(private http: HttpClient) {   
        this.http = http;
    }

    listVagas(api){
        return this.http.get<JSON>(api);
    }

    listSkils(api){
        return this.http.get<JSON>(api);
    }

    listEntrevistas(api){
        return this.http.get<JSON>(api);
    }

    saveEntrevista(api, body){
        return this.http.post<JSON>(api, body);
    }
}