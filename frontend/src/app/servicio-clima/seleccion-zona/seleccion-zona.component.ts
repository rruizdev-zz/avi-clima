import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-seleccion-zona',
  templateUrl: './seleccion-zona.component.html',
  styleUrls: ['./seleccion-zona.component.sass']
})
export class SeleccionZonaComponent implements OnInit {
  public seleccionZona: FormGroup;
  public paises: string[];
  public ciudades: string[];

  constructor(private builder: FormBuilder) { }

  ngOnInit(): void {
    this.seleccionZona = this.builder.group({
      pais: ['', Validators.required],
      ciudad: ['', Validators.required]
    });
  }

}
