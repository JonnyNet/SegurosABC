import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { URLS } from 'src/app/core/urls';
import { PagosComponent } from './pages/pagos/pagos.component';

const routes: Routes = [
  {
    path: URLS.HISTORIA_PAGOS.PATH,
    component: PagosComponent,
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class HistorialPagoRoutingModule { }
