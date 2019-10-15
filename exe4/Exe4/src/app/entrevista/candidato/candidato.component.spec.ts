import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CandidatoComponent } from './candidato.component';

describe('CandidatoComponent', () => {
  let component: CandidatoComponent;
  let fixture: ComponentFixture<CandidatoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CandidatoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CandidatoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
