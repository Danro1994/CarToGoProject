import { Condition } from './condition';
import { Model } from './model';
import { Photo } from './photo';
import { Seller } from './seller';
import { Status } from './status';

export class Car{
    Id: Number;
    ModelId:Number ;
    Model: Model ;
    PhotoId:Number ;
    Photo: Photo ;
    Year:Number ;
    Color: String ;
    Mileage:Number ;
    Fuel: String ;
    Engine: String ;
    Transmission: String ;
    Traction: String ;
    Seats: String;
    AirConditione: boolean ;
    Windows : String;
    StatusId:Number ;
    Status :Status ;
    SellerId :Number;
    Seller :Seller ;
    ConditionId :Number;
    Condition :Condition ;
    Price :Number;
    Comments: String ;
}