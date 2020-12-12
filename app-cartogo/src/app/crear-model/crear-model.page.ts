import { Component, OnInit } from '@angular/core';
import { Model } from '../modelos/model'
import { ModelsService } from '../services/models.service'
import { BrandsService } from '../services/brands.service'
import { Router} from '@angular/router'
import { Brand } from '../modelos/brand';

@Component({
  selector: 'app-crear-model',
  templateUrl: './crear-model.page.html',
  styleUrls: ['./crear-model.page.scss'],
})
export class CrearModelPage implements OnInit {
  brands: Brand[];
  model: Model;

  constructor(
    private _brandsService: BrandsService, private _modelsService: ModelsService,
    public router: Router ){
    this.model = new Model();
    } 

  ngOnInit() {
    this._brandsService.obtenerBrands().subscribe(res =>{
      this.brands = res;
    })
  }

  crearModel(){
    if(this.model){
      this._modelsService
      .crearModel(this.model)
      .subscribe(() => {
        this.router.navigate(["/models"]);
      });
    }
  }

  cancelar(){
    this.router.navigate(["/models"])
  }
}

