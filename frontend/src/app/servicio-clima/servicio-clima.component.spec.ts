import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ServicioClimaComponent } from './servicio-clima.component';

describe('ServicioClimaComponent', () => {
  let component: ServicioClimaComponent;
  let fixture: ComponentFixture<ServicioClimaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ServicioClimaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ServicioClimaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
