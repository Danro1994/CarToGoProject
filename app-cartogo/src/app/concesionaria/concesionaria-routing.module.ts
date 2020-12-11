import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ConcesionariaPage } from './concesionaria.page';

const routes: Routes = [
  {
    path: '',
    component: ConcesionariaPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class ConcesionariaPageRoutingModule {}
