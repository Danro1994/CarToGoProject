import { Component, OnInit } from '@angular/core';
import { Brand } from "../modelos/brand";
import { BrandsService } from "../services/brands.service";
import { Router } from '@angular/router'
import { AlertController,   Platform} from '@ionic/angular'

@Component({
  selector: 'app-brands',
  templateUrl: './brands.page.html',
  styleUrls: ['./brands.page.scss'],
})
export class BrandsPage implements OnInit {
  brands: Brand[];

  constructor(
    private _brandsService:BrandsService,
    private router:Router,
    private alertController:AlertController,
    private plartform:Platform
  ) {}

  ngOnInit() {
  }
  ionViewWillEnter(){
    this.obtenerBrands(); 

}

crearBrand(){
  this.router.navigate(["/brands/crear"]);
}

editarBrand(id: Number){
  this.router.navigate([`brands/editar/${id}`])
}

obtenerBrands(event= null)
{
  this._brandsService.obtenerBrands().subscribe(data =>{
    this.brands = data;
    if(event){
      event.target.complete();
    }
  })
}

presentAlert(id){
  this.alertController
  .create({
    message:"Desea Eliminar el Brand",
    header: "Confirmar",
    buttons: [
      {
        text: "No",
        role: "cancel",
        cssClass: "secunday",
        handler: blah => {}
      },
      {
        text: "Si",
        handler: () => {
          this._brandsService.eliminarBrand(id).subscribe(() =>{
            this.obtenerBrands();
          })
        }
      }
    ]
  }) 
.then(alert => alert.present())
}

eliminarBrand(id:Number){
this.plartform.ready().then(() =>{
  if(this.plartform.is("cordova")){
    this.presentAlert(id);
  }else{
    const res = confirm("Desea Eliminar el Brand");
    if(res){
      this._brandsService.eliminarBrand(id).subscribe(() => {
        this.obtenerBrands();
      });
    }
  }
})
}
}

