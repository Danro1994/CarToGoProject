import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ComprarMarcaPage } from './comprar-marca.page';

const routes: Routes = [
  {
    path: '',
    component: ComprarMarcaPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class ComprarMarcaPageRoutingModule {}
