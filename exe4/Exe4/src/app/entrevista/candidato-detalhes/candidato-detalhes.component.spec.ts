import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CandidatoDetalhesComponent } from './candidato-detalhes.component';

describe('CandidatoDetalhesComponent', () => {
  let component: CandidatoDetalhesComponent;
  let fixture: ComponentFixture<CandidatoDetalhesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CandidatoDetalhesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CandidatoDetalhesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
