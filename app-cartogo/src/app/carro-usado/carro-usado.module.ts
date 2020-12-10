import { Component, NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Routes, RouterModule } from '@angular/router';

import { IonicModule } from '@ionic/angular';

import { CarroUsadoPageRoutingModule } from './carro-usado-routing.module';

import { CarroUsadoPage } from './carro-usado.page';



@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    CarroUsadoPageRoutingModule
  ],
  declarations: [CarroUsadoPage]
})
export class CarroUsadoPageModule {}
