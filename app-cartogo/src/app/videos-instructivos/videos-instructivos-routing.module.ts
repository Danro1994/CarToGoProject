import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { VideosInstructivosPage } from './videos-instructivos.page';

const routes: Routes = [
  {
    path: '',
    component: VideosInstructivosPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class VideosInstructivosPageRoutingModule {}
