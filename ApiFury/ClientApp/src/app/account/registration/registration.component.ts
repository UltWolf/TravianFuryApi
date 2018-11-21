import { User } from './../../Models/User';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.scss']
})
export class RegistrationComponent implements OnInit {

  user: User = {
    name: "Please input your name",
    password: "Please input your password"
  }
  constructor() { }
  CreateUser(newUser:User){
    console.log(this.user);
  }

  ngOnInit() {
  }

}
