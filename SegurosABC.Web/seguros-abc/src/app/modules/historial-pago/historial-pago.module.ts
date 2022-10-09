import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HistorialPagoRoutingModule } from './historial-pago-routing.module';
import { PagosComponent } from './pages/pagos/pagos.component';
import { SharedModule } from '../shared/shared.module';


@NgModule({
  declarations: [
    PagosComponent
  ],
  imports: [
    CommonModule,
    HistorialPagoRoutingModule,
    SharedModule,
  ]
})
export class HistorialPagoModule { }
