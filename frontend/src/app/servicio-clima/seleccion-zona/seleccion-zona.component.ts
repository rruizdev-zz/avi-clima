import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ServicioClimaService } from '../servicio-clima.service';

@Component({
  selector: 'app-seleccion-zona',
  templateUrl: './seleccion-zona.component.html',
  styleUrls: ['./seleccion-zona.component.sass']
})
export class SeleccionZonaComponent implements OnInit {
  public seleccionZona: FormGroup;
  public paises: PairAutocomplete[] = [{ id: 1, name: 'Argentina' }];
  public ciudades: PairAutocomplete[] = [{ id: 1, name: 'Ciudad de Buenos Aires' }];

  constructor(private builder: FormBuilder, private service: ServicioClimaService) { }

  public ngOnInit(): void {
    this.seleccionZona = this.builder.group({
      pais: ['', Validators.required],
      ciudad: ['', Validators.required]
    });
  }

  public query(): void {
    this.service.procesarClima(this.seleccionZona.value.pais, this.seleccionZona.value.ciudad);
    this.service.procesarPronostico(this.seleccionZona.value.pais, this.seleccionZona.value.ciudad);
  }
}

export class PairAutocomplete {
  id: number;
  name: string;
}
