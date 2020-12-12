import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http'
import { Car } from '../modelos/car'

@Injectable({
  providedIn: 'root'
})
export class CarrosService {
  apiURL = "https://localhost:44363/api/Car"

  constructor(private http : HttpClient) { }
  obtenerCar(){
    return this.http.get<Car>(this.apiURL);
  }
  obtenerCars(){
    return this.http.get<Car[]>(this.apiURL);
  }
  eliminarCar(id:Number){
    return this.http.delete(this.apiURL + "/" + id);
  }
  crearCar(car: Car){
    return this.http.post<Car>(this.apiURL, car);
  }
  editarBrand(car: Car){
    return this.http.put<Car>(
      this.apiURL + "/" + car.Id, 
      car
    );
  }
}
