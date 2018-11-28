import { Component, OnInit } from '@angular/core';
import { WarTask } from 'src/app/Models/WarTask';
import { MarketTask } from 'src/app/Models/MarketTask';
import { UserProfile } from 'src/app/Models/UserProfile';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.scss']
})
export class ProfileComponent implements OnInit {
  User: UserProfile = {
     name: 'Vitalka'
  };
  constructor() { }

  ngOnInit() {
  }

}
