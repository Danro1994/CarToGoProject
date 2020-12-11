import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';

import { CrearCarroPage } from './crear-carro.page';

describe('CrearCarroPage', () => {
  let component: CrearCarroPage;
  let fixture: ComponentFixture<CrearCarroPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CrearCarroPage ],
      imports: [IonicModule.forRoot()]
    }).compileComponents();

    fixture = TestBed.createComponent(CrearCarroPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
