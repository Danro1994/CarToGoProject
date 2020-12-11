import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';

import { CrearModelPage } from './crear-model.page';

describe('CrearModelPage', () => {
  let component: CrearModelPage;
  let fixture: ComponentFixture<CrearModelPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CrearModelPage ],
      imports: [IonicModule.forRoot()]
    }).compileComponents();

    fixture = TestBed.createComponent(CrearModelPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
