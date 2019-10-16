import { TestBed } from '@angular/core/testing';

import { EntrevistaService } from './entrevista.service';

describe('EntrevistaService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: EntrevistaService = TestBed.get(EntrevistaService);
    expect(service).toBeTruthy();
  });
});
