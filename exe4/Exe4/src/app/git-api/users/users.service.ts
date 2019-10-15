import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class UsersService {
  
  
  constructor(private http: HttpClient) {   
    this.http = http;
  }
  listUsers(api){
    return this.http.get<Object[]>(api);    
  }
}
