import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { MatTableDataSource } from '@angular/material/table';
import { HistorialPagosService } from '../../services/historial-pagos.service';

@Component({
  selector: 'app-pagos',
  templateUrl: './pagos.component.html',
  styleUrls: ['./pagos.component.scss']
})
export class PagosComponent implements OnInit {

  displayedColumns: string[] = ['cedula', 'nombre', 'fechaPago', 'monto'];
  dataSource = new MatTableDataSource<any>();

  filter = new FormControl();

  constructor(private service: HistorialPagosService) { }

  ngOnInit(): void {
    this.search();
  }

  search() {

    const value = !!this.filter.value ? this.filter.value : null;

    this.service.ObtenerHistorialPagos(value).subscribe((result: any) => {
      this.dataSource.data = result;
    });
  }

}
