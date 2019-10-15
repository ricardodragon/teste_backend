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
  candidatos: any = [];
  constructor(private candidatoService: CandidatoService, private route: ActivatedRoute) {  }  
  candidato: any = {};
  ngOnInit() {    
    this.candidatoService.listCandidatos(this.URL).subscribe(
      candidatos => this.candidatos = candidatos);    
  }

  cadastrar(candidato){
    this.candidatoService.saveCandidato(this.URL,candidato).subscribe(candidato => this.candidatos.push(candidato));
  }
}
