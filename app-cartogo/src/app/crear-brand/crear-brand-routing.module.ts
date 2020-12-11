import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { CrearBrandPage } from './crear-brand.page';

const routes: Routes = [
  {
    path: '',
    component: CrearBrandPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class CrearBrandPageRoutingModule {}
