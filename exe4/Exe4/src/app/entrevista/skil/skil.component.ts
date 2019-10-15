import { Component, OnInit } from '@angular/core';
import { SkilService } from './skil.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-skil',
  templateUrl: './skil.component.html',
  styleUrls: ['./users.component.css']
})
export class SkilComponent implements OnInit {
  //.subscribe(users=>this.users = users);
  URL: string = "http://localhost:5000/api/skil/"
  skils: any = [];
  skil: any = {};
  constructor(private skilService: SkilService, private route: ActivatedRoute) {  

  }
  
  ngOnInit(){
    var urlCandidato = this.route.snapshot.params.idCandidato;
    var urlVaga = this.route.snapshot.params.idCandidato;
    // if(urlVaga)
    //   this.URL+='vaga/'+urlVaga;
    // if(urlCandidato)
    //   this.URL+='candidato/'+urlVaga;
    console.log(this.URL);
    this.skilService.listSkils(this.URL).subscribe(skils=>this.skils = skils);
  }

  cadastrar(skil){
    this.skilService.saveSkil(this.URL, skil).subscribe(skil=>this.skils.push(skil));
  }
}
