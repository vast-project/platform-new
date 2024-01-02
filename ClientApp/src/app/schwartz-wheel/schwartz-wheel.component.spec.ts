import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SchwartzWheelComponent } from './schwartz-wheel.component';

describe('SchwartzWheelComponent', () => {
  let component: SchwartzWheelComponent;
  let fixture: ComponentFixture<SchwartzWheelComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SchwartzWheelComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SchwartzWheelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
