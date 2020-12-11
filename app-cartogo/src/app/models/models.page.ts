import { Component, OnInit } from '@angular/core';
import { Model } from "../modelos/model";
import { ModelsService } from "../services/models.service";
import { Router } from '@angular/router'
import { AlertController,   Platform} from '@ionic/angular'

@Component({
  selector: 'app-models',
  templateUrl: './models.page.html',
  styleUrls: ['./models.page.scss'],
})
export class ModelsPage implements OnInit {
  models: Model[];

  constructor(
    private _modelsService:ModelsService,
    private router:Router,
    private alertController:AlertController,
    private plartform:Platform
  ) { }

  ngOnInit() {}
  xx
  ionViewWillEnter(){
    this.obtenerModels();

    }
    crearModel(){
      this.router.navigate(["/models/crear"]);
    }

    editarModel(id: Number){
      this.router.navigate([`/models/editar/${id}`])
    }
    obtenerModels(event= null)
    {
      this._modelsService.obtenerModels().subscribe(data =>{
        this.models = data;
        if(event){
          event.target.complete();
        }
      })
    }
    presentAlert(id){
      this.alertController
      .create({
        message:"Desea Eliminar el Modelo",
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
              this._modelsService.eliminarModel(id).subscribe(() =>{
                this.obtenerModels();
              })
            }
          }
        ]
      }) 
    .then(alert => alert.present())
  }

  eliminarModel(id:Number){
    this.plartform.ready().then(() =>{
      if(this.plartform.is("cordova")){
        this.presentAlert(id);
      }else{
        const res = confirm("Desea Eliminar el Modelo");
        if(res){
          this._modelsService.eliminarModel(id).subscribe(() => {
            this.obtenerModels();
          });
        }
      }
    })
  }
}
