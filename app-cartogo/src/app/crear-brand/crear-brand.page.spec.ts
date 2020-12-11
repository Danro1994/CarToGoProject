import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';

import { CrearBrandPage } from './crear-brand.page';

describe('CrearBrandPage', () => {
  let component: CrearBrandPage;
  let fixture: ComponentFixture<CrearBrandPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CrearBrandPage ],
      imports: [IonicModule.forRoot()]
    }).compileComponents();

    fixture = TestBed.createComponent(CrearBrandPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
