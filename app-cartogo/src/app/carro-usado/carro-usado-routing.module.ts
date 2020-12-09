import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { CarroUsadoPage } from './carro-usado.page';

const routes: Routes = [
  {
    path: '',
    component: CarroUsadoPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class CarroUsadoPageRoutingModule {}
