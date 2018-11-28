import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MarketTaskComponent } from './market-task.component';

describe('MarketTaskComponent', () => {
  let component: MarketTaskComponent;
  let fixture: ComponentFixture<MarketTaskComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MarketTaskComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MarketTaskComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
