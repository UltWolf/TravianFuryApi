import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UnderWarTaskComponent } from './under-war-task.component';

describe('UnderWarTaskComponent', () => {
  let component: UnderWarTaskComponent;
  let fixture: ComponentFixture<UnderWarTaskComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UnderWarTaskComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UnderWarTaskComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
