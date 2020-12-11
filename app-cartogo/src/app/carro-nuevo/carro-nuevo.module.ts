import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { CarroNuevoPageRoutingModule } from './carro-nuevo-routing.module';

import { CarroNuevoPage } from './carro-nuevo.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    CarroNuevoPageRoutingModule
  ],
  declarations: [CarroNuevoPage]
})
export class CarroNuevoPageModule {}
