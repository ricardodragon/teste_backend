import { TestBed } from '@angular/core/testing';

import { SkilService } from './skil.service';

describe('SkilService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: SkilService = TestBed.get(SkilService);
    expect(service).toBeTruthy();
  });
});
