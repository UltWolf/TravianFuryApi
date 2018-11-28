import { Component, OnInit } from '@angular/core';

import { UnderWarTaskComponent } from '../under-war-task/under-war-task.component';

@Component({
  selector: 'app-war-task',
  templateUrl: './war-task.component.html',
  styleUrls: ['./war-task.component.scss'],

})
export class WarTaskComponent implements OnInit {

  War: UnderWarTaskComponent[];
  Task:UnderWarTaskComponent =  new UnderWarTaskComponent( {
      sourceVillage:"Cherkassy",
      sourceVillageId:1,
      destinationVillageId:2,
      destinationVillage:"Moskow",
      troop1: 0,
      troop2: 0,
      troop3: 0,
      troop4: 0,
      troop5: 0,
      troop6: 0,
      troop7: 0,
      troop8: 0,
      troop9:  0
    });
  constructor() {
    this.War = [];
    this.War.push(this.Task);
    this.War.push(this.Task);
    this.War.push(this.Task);
    this.War.push(this.Task);
    this.War.push(this.Task);
    this.War.push(this.Task);
    this.War.push(this.Task);
    console.log(this.War);
   }
  ngOnInit() {
  }

}
