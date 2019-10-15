import { NgModule } from '@angular/core';
//import { UserComponent } from '../user/user.component';
import { HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';
import { SkilComponent } from './skil/skil.component';
import { VagaComponent } from './vaga/vaga.component';
import { CandidatoComponent } from './candidato/candidato.component';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { CandidatoDetalhesComponent } from './candidato-detalhes/candidato-detalhes.component';

@NgModule({
    declarations: [ SkilComponent, CandidatoComponent, VagaComponent, CandidatoDetalhesComponent ],
    exports: [ SkilComponent, CandidatoComponent, VagaComponent, CandidatoDetalhesComponent ],
    imports: [ HttpClientModule, CommonModule, RouterModule, FormsModule ]
})
export class EntrevistaModule {  }