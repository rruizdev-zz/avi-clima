import { Component, OnInit } from '@angular/core';
import { ServicioClimaService, Forecast, Weather } from './servicio-clima.service';

@Component({
  selector: 'app-servicio-clima',
  templateUrl: './servicio-clima.component.html',
  styleUrls: ['./servicio-clima.component.sass']
})
export class ServicioClimaComponent implements OnInit {
  public showReporte: boolean;
  public showClima: boolean;

  public constructor(private service: ServicioClimaService) { }

  public ngOnInit(): void {
    this.service.forecast$.subscribe((reporte: Forecast) => this.showReporte = reporte !== undefined);
    this.service.weather$.subscribe((weather: Weather) => this.showClima = weather !== undefined);
  }

}
