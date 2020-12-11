import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { ComprarMarcaPageRoutingModule } from './comprar-marca-routing.module';

import { ComprarMarcaPage } from './comprar-marca.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    ComprarMarcaPageRoutingModule
  ],
  declarations: [ComprarMarcaPage]
})
export class ComprarMarcaPageModule {}
