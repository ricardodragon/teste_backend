import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ResultadoService } from './resultado.service';

@Component({
  selector: 'app-resultado',
  templateUrl: './resultado.component.html',
})
export class ResultadoComponent implements OnInit {
  //.subscribe(users=>this.users = users);
  URL: string = "http://localhost:5000/api/entrevista/"
  URL_CANDIDATO: string = "http://localhost:5000/api/candidato/"
  candidatos: any = [];
  entrevista: any = {};
  constructor(private resultadoService: ResultadoService, private route: ActivatedRoute) {  }
  
  ngOnInit(){    
    this.resultadoService.listSkils(this.URL+this.route.snapshot.params.id).subscribe(entrevista=>{
        this.entrevista = entrevista;
        this.resultadoService.listSkils(this.URL_CANDIDATO).subscribe(candidatos=>{
            this.candidatos = candidatos;
            this.candidatos.forEach(c => {                    
                c.candidatoSkil.forEach(s => {                                                      
                    s.skil.pontos = this.entrevista.entrevistaSkil.filter(x=>x.skil.id == s.skil.id)[0].pontuacao;
                });
            });
        });
    });
    
    
  }

//   cadastrar(skil){
//     this.skilService.saveSkil(this.URL, skil).subscribe(skil=>this.skils.push(skil));
//   }
}
