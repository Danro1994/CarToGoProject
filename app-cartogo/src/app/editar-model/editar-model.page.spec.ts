import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';

import { EditarModelPage } from './editar-model.page';

describe('EditarModelPage', () => {
  let component: EditarModelPage;
  let fixture: ComponentFixture<EditarModelPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EditarModelPage ],
      imports: [IonicModule.forRoot()]
    }).compileComponents();

    fixture = TestBed.createComponent(EditarModelPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
