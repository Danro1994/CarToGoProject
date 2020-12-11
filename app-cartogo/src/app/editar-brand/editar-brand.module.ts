import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { EditarBrandPageRoutingModule } from './editar-brand-routing.module';

import { EditarBrandPage } from './editar-brand.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    EditarBrandPageRoutingModule
  ],
  declarations: [EditarBrandPage]
})
export class EditarBrandPageModule {}
