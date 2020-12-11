import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { CrearCarroPage } from './crear-carro.page';

const routes: Routes = [
  {
    path: '',
    component: CrearCarroPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class CrearCarroPageRoutingModule {}
