import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';

import { CarroNuevoPage } from './carro-nuevo.page';

describe('CarroNuevoPage', () => {
  let component: CarroNuevoPage;
  let fixture: ComponentFixture<CarroNuevoPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CarroNuevoPage ],
      imports: [IonicModule.forRoot()]
    }).compileComponents();

    fixture = TestBed.createComponent(CarroNuevoPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
