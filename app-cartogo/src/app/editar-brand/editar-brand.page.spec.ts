import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';

import { EditarBrandPage } from './editar-brand.page';

describe('EditarBrandPage', () => {
  let component: EditarBrandPage;
  let fixture: ComponentFixture<EditarBrandPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EditarBrandPage ],
      imports: [IonicModule.forRoot()]
    }).compileComponents();

    fixture = TestBed.createComponent(EditarBrandPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
