import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { SucessoComponent } from './cadastro/sucesso/sucesso.component';
import { ErroComponent } from './cadastro/erro/erro.component';
import { HomeComponent } from './home/home.component';


const routes: Routes = [
  {
    path: '',
    pathMatch: 'full',
    redirectTo: 'home'
  },
  {
    path: 'home',
    component: HomeComponent
  },
  {
    path: 'sucesso',
    component: SucessoComponent
  },
  {
    path: 'erro',
    component: ErroComponent
  },
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes)
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
