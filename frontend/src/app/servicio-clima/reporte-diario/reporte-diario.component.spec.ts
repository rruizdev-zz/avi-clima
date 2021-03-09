import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReporteDiarioComponent } from './reporte-diario.component';

describe('ReporteDiarioComponent', () => {
  let component: ReporteDiarioComponent;
  let fixture: ComponentFixture<ReporteDiarioComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ReporteDiarioComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ReporteDiarioComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
