import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http'
import { Brand } from '../modelos/brand'

@Injectable({
  providedIn: 'root'
})
export class BrandsService {
  apiURL = "https://localhost:44363/api/Brand"

  constructor(private http : HttpClient) { }
  
  obtenerBrand(id:Number){
    return this.http.get<Brand>(this.apiURL + "/" + id);
  }
  obtenerBrands(){
    return this.http.get<Brand[]>(this.apiURL);
  }
  eliminarBrand(id:Number){
    return this.http.delete(this.apiURL + "/" + id);
  }
  crearBrand(model: Brand){
    return this.http.post<Brand>(this.apiURL, model);
  }
  editarBrand(brand: Brand){
    return this.http.put<Brand>(
      this.apiURL + "/" + brand.Id, 
      brand
    );
  }
}
