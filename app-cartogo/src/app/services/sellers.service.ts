import { Injectable } from '@angular/core';
import { from } from 'rxjs';
import {HttpClient} from "@angular/common/http";
import { Seller } from '../models/seller';
@Injectable({
  providedIn: 'root'
})
export class SellersService {
apiURL= "http://localhost:49741/api/seller";
  constructor(private http: HttpClient) { }

  getSellers(){
    return this.http.get<Seller[]>(this.apiURL);
  }
}
