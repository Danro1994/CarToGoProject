import { Component, OnInit } from '@angular/core';
import { Car } from "../modelos/car";
import { CarrosService } from "../services/carros.service";
import { Router } from '@angular/router'
import { AlertController,   Platform} from '@ionic/angular'

@Component({
  selector: 'app-carros',
  templateUrl: './carros.page.html',
  styleUrls: ['./carros.page.scss'],
})
export class CarrosPage implements OnInit {
  cars: Car[];

  constructor(
    private _carrosService:CarrosService,
    private router:Router,
    private alertController:AlertController,
    private plartform:Platform
  ) { }

  ngOnInit() {}
  
  ionViewWillEnter(){
      this.obtenerCars(); 
  }

  crearCar(){
    this.router.navigate(["/carros/crear"]);
  }

  editarCar(id: Number){
    this.router.navigate([`carros/editar/${id}`])
  }
  
  obtenerCars(event= null)
  {
    this._carrosService.obtenerCars().subscribe(data =>{
      this.cars = data;
      if(event){
        event.target.complete();
      }
    })
  }
  presentAlert(id){
    this.alertController
    .create({
      message:"Desea Eliminar el Carro",
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
            this._carrosService.eliminarCar(id).subscribe(() =>{
              this.obtenerCars();
            })
          }
        }
      ]
    }) 
  .then(alert => alert.present())
}

eliminarCar(id:Number){
  this.plartform.ready().then(() =>{
    if(this.plartform.is("cordova")){
      this.presentAlert(id);
    }else{
      const res = confirm("Desea Eliminar el Carro");
      if(res){
        this._carrosService.eliminarCar(id).subscribe(() => {
          this.obtenerCars();
        });
      }
    }
  })
}

}
