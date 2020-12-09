import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';

import { CarroUsadoPage } from './carro-usado.page';

describe('CarroUsadoPage', () => {
  let component: CarroUsadoPage;
  let fixture: ComponentFixture<CarroUsadoPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CarroUsadoPage ],
      imports: [IonicModule.forRoot()]
    }).compileComponents();

    fixture = TestBed.createComponent(CarroUsadoPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
