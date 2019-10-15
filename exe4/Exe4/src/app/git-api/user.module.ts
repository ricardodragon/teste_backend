import { NgModule } from '@angular/core';
//import { UserComponent } from '../user/user.component';
import { HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';
import { UsersComponent } from './users/users.component';
import { UserComponent } from './user/user.component';
import { RouterModule } from '@angular/router';

@NgModule({
    declarations: [ UsersComponent, UserComponent ],
    exports: [ UsersComponent, UserComponent ],
    imports: [ HttpClientModule, CommonModule, RouterModule ]
})
export class UserModule {  }