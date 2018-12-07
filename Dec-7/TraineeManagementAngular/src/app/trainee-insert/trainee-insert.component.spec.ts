import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TraineeInsertComponent } from './trainee-insert.component';

describe('TraineeInsertComponent', () => {
  let component: TraineeInsertComponent;
  let fixture: ComponentFixture<TraineeInsertComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TraineeInsertComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TraineeInsertComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
