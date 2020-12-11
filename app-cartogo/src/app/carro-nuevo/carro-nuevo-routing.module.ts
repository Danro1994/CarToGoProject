import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { CarroNuevoPage } from './carro-nuevo.page';

const routes: Routes = [
  {
    path: '',
    component: CarroNuevoPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class CarroNuevoPageRoutingModule {}
