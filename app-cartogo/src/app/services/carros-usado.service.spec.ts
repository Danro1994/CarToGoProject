import { TestBed } from '@angular/core/testing';

import { CarrosUsadoService } from './carros-usado.service';

describe('CarrosUsadoService', () => {
  let service: CarrosUsadoService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CarrosUsadoService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
