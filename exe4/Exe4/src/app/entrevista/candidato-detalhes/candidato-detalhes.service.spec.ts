import { TestBed } from '@angular/core/testing';

import { CandidatoDetalhesService } from './candidato-detalhes.service';

describe('CandidatoDetalhesService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: CandidatoDetalhesService = TestBed.get(CandidatoDetalhesService);
    expect(service).toBeTruthy();
  });
});
