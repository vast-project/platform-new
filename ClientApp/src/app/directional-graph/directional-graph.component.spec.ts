import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DirectionalGraphComponent } from './directional-graph.component';

describe('DirectionalGraphComponent', () => {
  let component: DirectionalGraphComponent;
  let fixture: ComponentFixture<DirectionalGraphComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DirectionalGraphComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DirectionalGraphComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
