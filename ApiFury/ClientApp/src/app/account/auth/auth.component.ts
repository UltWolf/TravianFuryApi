import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/Models/User';

@Component({
  selector: 'app-auth',
  templateUrl: './auth.component.html',
  styleUrls: ['./auth.component.scss']
})
export class AuthComponent implements OnInit {

  user: User = {
    name: "Please input your name",
    password: "Please input your password"
  }
  Login(newUser:User){
    console.log(this.user);
  }
  constructor() { }

  ngOnInit() {
  }

}
