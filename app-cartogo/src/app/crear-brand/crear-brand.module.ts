import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { CrearBrandPageRoutingModule } from './crear-brand-routing.module';

import { CrearBrandPage } from './crear-brand.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    CrearBrandPageRoutingModule
  ],
  declarations: [CrearBrandPage]
})
export class CrearBrandPageModule {}
