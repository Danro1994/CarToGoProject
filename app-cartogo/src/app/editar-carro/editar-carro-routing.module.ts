import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { EditarCarroPage } from './editar-carro.page';

const routes: Routes = [
  {
    path: '',
    component: EditarCarroPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class EditarCarroPageRoutingModule {}
