import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http'
import { Brand } from '../modelos/brand'

@Injectable({
  providedIn: 'root'
})
export class BrandsService {
  apiURL = "https://localhost:44363/api/brand"

  constructor(private http : HttpClient) { }
  
  obtenerBrand(){
    return this.http.get<Brand[]>(this.apiURL);
  }
}
