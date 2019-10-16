import { Component, OnInit } from '@angular/core';
import { EntrevistaService } from './entrevista.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-entrevista',
  templateUrl: './entrevista.component.html',  
})
export class EntrevistaComponent implements OnInit {
  //.subscribe(users=>this.users = users);
  URL: string = "http://localhost:5000/api/entrevista/";
  URL_VAGAS: string = "http://localhost:5000/api/vaga/";
  URL_SKILS: string = "http://localhost:5000/api/skil/";
  vagas: any = [];
  entrevista: any = {};  
  entrevistas: any = [];
  skils: any = [];
  constructor(private entrevistaService: EntrevistaService, private route: ActivatedRoute) {  
  }
  
  ngOnInit(){    
    // this.entrevistaService.listSkils(this.URL).subscribe(skils=>this.skils = skils);
    this.entrevistaService.listVagas(this.URL_VAGAS).subscribe(vagas=>this.vagas=vagas);
    this.entrevistaService.listSkils(this.URL_SKILS).subscribe(skils=>this.skils=skils);
    this.entrevistaService.listEntrevistas(this.URL).subscribe(entrevistas=>this.entrevistas=entrevistas);
  }

  cadastrar(entrevista, skils){
    var entrevistaSkil=[];
    console.log(entrevista);
    console.log(skils);
    skils.forEach(element => {
      entrevistaSkil.push({skilId: element.id, pontuacao: element.pontos});
    });
    console.log(entrevistaSkil);
    entrevista.entrevistaSkil = entrevistaSkil;
    this.entrevistaService.saveEntrevista(this.URL, entrevista).subscribe(entrevista=>this.entrevista =entrevista);
  }
}
