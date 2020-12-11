import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { EditarModelPageRoutingModule } from './editar-model-routing.module';

import { EditarModelPage } from './editar-model.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    EditarModelPageRoutingModule
  ],
  declarations: [EditarModelPage]
})
export class EditarModelPageModule {}
