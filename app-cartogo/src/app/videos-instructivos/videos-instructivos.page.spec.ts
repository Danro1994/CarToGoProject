import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';

import { VideosInstructivosPage } from './videos-instructivos.page';

describe('VideosInstructivosPage', () => {
  let component: VideosInstructivosPage;
  let fixture: ComponentFixture<VideosInstructivosPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ VideosInstructivosPage ],
      imports: [IonicModule.forRoot()]
    }).compileComponents();

    fixture = TestBed.createComponent(VideosInstructivosPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
