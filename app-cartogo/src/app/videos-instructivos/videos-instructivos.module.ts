import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { VideosInstructivosPageRoutingModule } from './videos-instructivos-routing.module';

import { VideosInstructivosPage } from './videos-instructivos.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    VideosInstructivosPageRoutingModule
  ],
  declarations: [VideosInstructivosPage]
})
export class VideosInstructivosPageModule {}
