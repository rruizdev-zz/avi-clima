import { Component, OnInit } from '@angular/core';
import { Forecast, ServicioClimaService } from '../servicio-clima.service';

@Component({
  selector: 'app-reporte-semanal',
  templateUrl: './reporte-semanal.component.html',
  styleUrls: ['./reporte-semanal.component.sass']
})
export class ReporteSemanalComponent implements OnInit {
  public reporte: Forecast;

  public constructor(private service: ServicioClimaService) { }

  public ngOnInit(): void {
    // tslint:disable-next-line: deprecation
    this.service.forecast$.subscribe((reporte: Forecast) => this.reporte = reporte);
  }

  public obtenerDia(date: string): string {
    return ['Domingo', 'Lunes', 'Martes', 'Miércoles', 'Jueves', 'Viernes', 'Sábado']
      .find((_: string, index: number) => index === new Date(date).getDay());
  }
}
