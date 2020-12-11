import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { EditarModelPage } from './editar-model.page';

const routes: Routes = [
  {
    path: '',
    component: EditarModelPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class EditarModelPageRoutingModule {}
