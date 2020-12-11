import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { CrearCarroPageRoutingModule } from './crear-carro-routing.module';

import { CrearCarroPage } from './crear-carro.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    CrearCarroPageRoutingModule
  ],
  declarations: [CrearCarroPage]
})
export class CrearCarroPageModule {}
