import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { CrearModelPageRoutingModule } from './crear-model-routing.module';

import { CrearModelPage } from './crear-model.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    CrearModelPageRoutingModule
  ],
  declarations: [CrearModelPage]
})
export class CrearModelPageModule {}
