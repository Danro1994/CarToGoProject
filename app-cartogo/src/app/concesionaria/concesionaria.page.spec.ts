import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';

import { ConcesionariaPage } from './concesionaria.page';

describe('ConcesionariaPage', () => {
  let component: ConcesionariaPage;
  let fixture: ComponentFixture<ConcesionariaPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ConcesionariaPage ],
      imports: [IonicModule.forRoot()]
    }).compileComponents();

    fixture = TestBed.createComponent(ConcesionariaPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
