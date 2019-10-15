import { Component, OnInit } from '@angular/core';
import { UsersService } from './users.service';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.css']
})
export class UsersComponent implements OnInit {
  //.subscribe(users=>this.users = users);
  users: Object[] = [];
  constructor(private usersService: UsersService) {     
  }
  
  ngOnInit(){
    this.usersService.listUsers('https://api.github.com/users').subscribe(users=>this.users = users);
  }

}
