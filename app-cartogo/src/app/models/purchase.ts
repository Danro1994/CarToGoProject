import { Model } from './model';
import { Brand } from './brand';
import { Photo } from './photo';
import { Status } from './status';
import { Seller } from './seller';
import { Condition } from './condition';
import { Car } from './car';

export class Purchase{
     Model :Model ;
     Brand :Brand ;
     Photo :Photo ;
     Status :Status ;
     Seller :Seller ;
     Condition: Condition ;
     Car: Car ;
}