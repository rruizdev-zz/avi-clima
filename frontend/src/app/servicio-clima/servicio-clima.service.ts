import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ServicioClimaService {
  private weather: BehaviorSubject<Weather>;
  public weather$: Observable<Weather>;
  private forecast: BehaviorSubject<Forecast>;
  public forecast$: Observable<Forecast>;

  public constructor(private http: HttpClient) {
    this.weather = new BehaviorSubject<Weather>(undefined);
    this.weather$ = this.weather.asObservable();
    this.forecast = new BehaviorSubject<Forecast>(undefined);
    this.forecast$ = this.forecast.asObservable();
  }

  public procesarClima(country: string, city: string): void {
    // tslint:disable-next-line: deprecation
    this.http.get(`${environment.url.backend}/Weather/${country}/${city}`).subscribe((weather: Weather) => this.weather.next(weather));
  }

  public procesarPronostico(country: string, city: string): void {
    // tslint:disable-next-line: deprecation
    this.http.get(`${environment.url.backend}/Forecast/${country}/${city}`).subscribe((forecast: Forecast) => this.forecast.next(forecast));
  }
}

export class ForecastDay {
  date: string;
  status: string;
  temperatureC: number;
  temperatureF: number;
}

export class Forecast {
  city: string;
  country: string;
  forecasts: ForecastDay[];
}

export class Weather {
  city: string;
  country: string;
  humidity: number;
  rain: number;
  status: string;
  temperatureC: number;
  temperatureF: number;
  wind: number;
}
