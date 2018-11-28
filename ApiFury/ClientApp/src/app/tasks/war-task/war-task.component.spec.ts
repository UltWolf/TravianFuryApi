import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { WarTaskComponent } from './war-task.component';

describe('WarTaskComponent', () => {
  let component: WarTaskComponent;
  let fixture: ComponentFixture<WarTaskComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ WarTaskComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(WarTaskComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
