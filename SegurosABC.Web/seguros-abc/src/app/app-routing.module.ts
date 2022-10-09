import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { URLS } from './core/urls';

const routes: Routes = [
  {
    path: 'historia-pagos',
    loadChildren: () => import('./modules/historial-pago/historial-pago.module').then(m => m.HistorialPagoModule),
  },
  {
    path: '**',
    redirectTo: URLS.HISTORIA_PAGOS.FULLPATH,
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
