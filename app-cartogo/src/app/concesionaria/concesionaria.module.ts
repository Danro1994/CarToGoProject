import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { ConcesionariaPageRoutingModule } from './concesionaria-routing.module';

import { ConcesionariaPage } from './concesionaria.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    ConcesionariaPageRoutingModule
  ],
  declarations: [ConcesionariaPage]
})
export class ConcesionariaPageModule {}
