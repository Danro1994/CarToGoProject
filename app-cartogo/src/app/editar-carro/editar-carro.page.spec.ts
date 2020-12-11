import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';

import { EditarCarroPage } from './editar-carro.page';

describe('EditarCarroPage', () => {
  let component: EditarCarroPage;
  let fixture: ComponentFixture<EditarCarroPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EditarCarroPage ],
      imports: [IonicModule.forRoot()]
    }).compileComponents();

    fixture = TestBed.createComponent(EditarCarroPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
