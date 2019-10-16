import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { UsersComponent } from './git-api/users/users.component';
import { UserComponent } from './git-api/user/user.component';
import { CandidatoComponent } from './entrevista/candidato/candidato.component';
import { VagaComponent } from './entrevista/vaga/vaga.component';
import { SkilComponent } from './entrevista/skil/skil.component';
import { CandidatoDetalhesComponent } from './entrevista/candidato-detalhes/candidato-detalhes.component';
import { EntrevistaComponent } from './entrevista/entrevista/entrevista.component';
import { ResultadoComponent } from './entrevista/resultado/resultado.component';


const routes: Routes = [
  {path: 'users', component: UsersComponent},
  {path: 'user/:id', component: UserComponent},
  {path: 'candidatos', component: CandidatoComponent},
  {path: 'candidato/:id', component: CandidatoDetalhesComponent},
  {path: 'vagas', component: VagaComponent},
  {path: 'skils', component: SkilComponent},
  {path: 'entrevista', component: EntrevistaComponent},
  {path: 'resultado/:id', component: ResultadoComponent},
  {path: '**', component: UsersComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {

}
