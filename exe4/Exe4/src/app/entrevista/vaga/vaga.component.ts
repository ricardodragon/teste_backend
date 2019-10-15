import { Component, OnInit } from '@angular/core';
import { VagaService } from './vaga.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-vaga',
  templateUrl: './vaga.component.html',
  styleUrls: ['./user.component.css']
})
export class VagaComponent implements OnInit {
  
  URL: string = "http://localhost:5000/api/vaga"; 
  vagas: any = [];
  vaga: any = {};
  constructor(private vagaService: VagaService, private route: ActivatedRoute) {  }  
  
  ngOnInit() {    
    this.vagaService.listVaga(this.URL).subscribe(vagas=>this.vagas = vagas);
  }

  cadastrar(vaga){
    this.vagaService.saveVaga(this.URL, vaga).subscribe(vaga=>this.vagas.push(vaga));
  }
}
