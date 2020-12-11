import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { CrearModelPage } from './crear-model.page';

const routes: Routes = [
  {
    path: '',
    component: CrearModelPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class CrearModelPageRoutingModule {}
