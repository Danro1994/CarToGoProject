import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';

import { ComprarMarcaPage } from './comprar-marca.page';

describe('ComprarMarcaPage', () => {
  let component: ComprarMarcaPage;
  let fixture: ComponentFixture<ComprarMarcaPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ComprarMarcaPage ],
      imports: [IonicModule.forRoot()]
    }).compileComponents();

    fixture = TestBed.createComponent(ComprarMarcaPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
