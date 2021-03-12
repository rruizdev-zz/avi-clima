import { Component, OnInit } from '@angular/core';
import { ServicioClimaService, Weather } from '../servicio-clima.service';

@Component({
  selector: 'app-reporte-diario',
  templateUrl: './reporte-diario.component.html',
  styleUrls: ['./reporte-diario.component.sass']
})
export class ReporteDiarioComponent implements OnInit {
  public weather: Weather;
  public dia: string = ['Domingo', 'Lunes', 'Martes', 'Miércoles', 'Jueves', 'Viernes', 'Sábado']
    .find((_: string, index: number) => index === new Date().getDay());

  public constructor(private service: ServicioClimaService) { }

  public ngOnInit(): void {
    // tslint:disable-next-line: deprecation
    this.service.weather$.subscribe((weather: Weather) => this.weather = weather);
  }

}
