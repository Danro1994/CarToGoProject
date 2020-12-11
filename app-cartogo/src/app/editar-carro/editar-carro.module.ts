import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { EditarCarroPageRoutingModule } from './editar-carro-routing.module';

import { EditarCarroPage } from './editar-carro.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    EditarCarroPageRoutingModule
  ],
  declarations: [EditarCarroPage]
})
export class EditarCarroPageModule {}
