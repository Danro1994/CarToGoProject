import { Component, OnInit } from '@angular/core';
import { Model } from '../modelos/model'
import { ModelsService } from '../services/models.service'
import { BrandsService } from '../services/brands.service'
import { Router, ActivatedRoute} from '@angular/router'
import { Brand } from '../modelos/brand';

@Component({
  selector: 'app-editar-model',
  templateUrl: './editar-model.page.html',
  styleUrls: ['./editar-model.page.scss'],
})
export class EditarModelPage implements OnInit {
  brands: Brand[];
  model: Model;
  constructor(
    private _brandsService: BrandsService, 
    private _modelsService: ModelsService,
    public router: Router,
    private route: ActivatedRoute
     ){
    this.model = new Model();
     }

  ngOnInit() {
    const id = +this.route.snapshot.paramMap.get("id");

    this._brandsService.obtenerBrand().subscribe(res =>{
      this.brands = res;
    })

    this._modelsService.obtenerModel(id).subscribe(res =>{
      this.model = res;
    })
  }
  
  actualizarModel(){
    if(this.model){
      this._modelsService
      .editarModel(this.model)
      .subscribe(() => {
    this.router.navigate(["/model"])
      });
    }
  }
 

  cancelar(){
    this.router.navigate(["/models"])
  }

}
