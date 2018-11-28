import { WarTaskComponent } from './../war-task/war-task.component';
import { WarTaskForDB } from './../../Models/WarTask';
import { Component, OnInit, OnChanges, SimpleChanges, Input } from '@angular/core';

@Component({
  selector: 'app-under-war-task',
  templateUrl: './under-war-task.component.html',
  styleUrls: ['./under-war-task.component.scss'],
  providers:[WarTaskForDB]

})
export class UnderWarTaskComponent implements OnChanges {
  Change:boolean = false;

@Input()
item:WarTaskForDB;
  ngOnChanges(changes: SimpleChanges): void {
    this.Change = true;
  }

  constructor(itemInside:WarTaskForDB) {
    this.item = itemInside;
    console.log(this.item);
   }


}
