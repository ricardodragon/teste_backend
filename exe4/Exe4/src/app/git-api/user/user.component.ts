import { Component, OnInit } from '@angular/core';
import { UserService } from './user.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {
  
  user: any = {};
  constructor(private userService: UserService, private route: ActivatedRoute) {  }  
  
  ngOnInit() {    
    this.userService.listUser('https://api.github.com/user/'+this.route.snapshot.params.id).subscribe(
      user=>{
        this.user = user;
        this.userService.listRepos(this.user.repos_url).subscribe(repos=>this.user.repos = repos)
      });
    ;
  }

}
