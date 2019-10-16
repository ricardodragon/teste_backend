import { Component, OnInit } from '@angular/core';
import { CandidatoService } from './candidato.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-candidato',
  templateUrl: './candidato.component.html',
  styleUrls: ['./user.component.css']
})
export class CandidatoComponent implements OnInit {
  URL: string = "http://localhost:5000/api/candidato";
  URL_SKIL: string = "http://localhost:5000/api/skil";
  candidatos: any = [];
  skils: any = [];
  teste: any = {};
  candidato: any = {};
  constructor(private candidatoService: CandidatoService, private route: ActivatedRoute) {  }  
  ngOnInit() {    
    this.candidatoService.listCandidatos(this.URL).subscribe(
      candidatos => this.candidatos = candidatos); 
    this.candidatoService.listCandidatos(this.URL_SKIL).subscribe(
      skils => this.skils = skils);       
  }

  cadastrar(candidato, skils){
    var skilsMap = [];
    skils.forEach(x=> {
      if(x.selected) skilsMap.push(x);
    });    
    var candidatoSkil = [];
    skilsMap.forEach(element => {      
      candidatoSkil.push({skilId:element.id});
    });
    candidato.candidatoSkil = candidatoSkil;
    this.candidatoService.saveCandidato(this.URL,candidato).subscribe(candidato => this.candidatos.push(candidato));
  }
}
