import { Injectable } from '@angular/core';
import { Model } from '../modelos/model';
import { HttpClient} from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class ModelsService {
  apiURL = "https://localhost:44363/api/model";

  constructor(private http : HttpClient) { }

  obtenerModel(id:Number){
    return this.http.get<Model>(this.apiURL + "/" + id);
  }
  obtenerModels(){
    return this.http.get<Model[]>(this.apiURL);
  }
  eliminarModel(id:Number){
    return this.http.delete(this.apiURL + "/" + id);
  }
  crearModel(model: Model){
    return this.http.post<Model>(this.apiURL, model);
  }
  editarModel(model: Model){
    return this.http.put<Model>(
      this.apiURL + "/" + model.Id, 
      model
    );
  }
}
