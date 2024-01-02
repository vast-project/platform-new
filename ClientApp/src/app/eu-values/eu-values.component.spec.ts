import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EuValuesComponent } from './eu-values.component';

describe('EuValuesComponent', () => {
  let component: EuValuesComponent;
  let fixture: ComponentFixture<EuValuesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EuValuesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EuValuesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
