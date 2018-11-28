import { Component, OnInit } from '@angular/core';
import { MarketTask } from 'src/app/Models/MarketTask';

@Component({
  selector: 'app-market-task',
  templateUrl: './market-task.component.html',
  styleUrls: ['./market-task.component.scss']
})
export class MarketTaskComponent implements OnInit {

  Trade:MarketTask[];
  Task:MarketTask = {
    sourceVillage:"",
    destinationVillage:"",
    sourceVillageId:1,
    destinationVillageId:1
  }
  constructor() {
    this.Trade=[];
    this.Trade.push(this.Task);
    this.Trade.push(this.Task);
    this.Trade.push(this.Task);
    this.Trade.push(this.Task);
    this.Trade.push(this.Task);
    this.Trade.push(this.Task);
   }

  ngOnInit() {
  }

}
