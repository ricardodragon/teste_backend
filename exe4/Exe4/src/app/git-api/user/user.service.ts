import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient) {   
    this.http = http;
  }
  listUser(api){
    return this.http.get<JSON>(api);    
  }
  listRepos(api){    
    return this.http.get<JSON>(api);    
  }
}
