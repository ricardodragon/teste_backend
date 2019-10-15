import { Component, OnInit } from '@angular/core';
import { CandidatoDetalhesService } from './candidato-detalhes.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-candidato-detalhes',
  templateUrl: './candidato-detalhes.component.html'
})
export class CandidatoDetalhesComponent implements OnInit {
  URL: string = "http://localhost:5000/api/candidato";
  URL_CANDIDATO_SKIL: string = "http://localhost:5000/api/candidatoskil";
  URL_SKIL: string = "http://localhost:5000/api/skil";
  candidato: any = {};
  skils: any = [];
  constructor(private candidatoDetalheService: CandidatoDetalhesService, private route: ActivatedRoute) {  }  
  ngOnInit() {    
    this.candidatoDetalheService.listCandidato(this.URL+'/'+this.route.snapshot.params.id).subscribe(
      candidato => this.candidato = candidato[0]);
    this.candidatoDetalheService.listSkils(this.URL_SKIL).subscribe(
        skils => this.skils = skils);    
  }

  salvarSkil(candidato, skils){
    var skilsMap = skils.map(x=>x.selected);
    var candidatoSkil = [];
    skilsMap.forEach(element => {
      candidatoSkil.push({candidato, skil: element});
    });
    this.candidatoDetalheService.saveCandidatoSkil(this.URL_CANDIDATO_SKIL, candidatoSkil);
  }
  // cadastrarSkil(candidato){
  //   this.candidatoDetalheService.saveCandidato(this.URL,candidato).subscribe(candidato => this.candidatos.push(candidato));
  // }
}
