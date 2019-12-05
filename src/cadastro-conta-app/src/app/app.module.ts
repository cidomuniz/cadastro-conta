import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule  } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CadastroComponent } from './cadastro/cadastro.component';
import { PessoaFisicaComponent } from './cadastro/pessoa-fisica/pessoa-fisica.component';
import { PessoaJuridicaComponent } from './cadastro/pessoa-juridica/pessoa-juridica.component';
import { CadastroService } from './cadastro/cadastro.service';

import { NgxMaskModule } from 'ngx-mask';
import { SucessoComponent } from './cadastro/sucesso/sucesso.component';
import { ErroComponent } from './cadastro/erro/erro.component';
import { HomeComponent } from './home/home.component';


@NgModule({
  declarations: [
    AppComponent,
    CadastroComponent,
    PessoaFisicaComponent,
    PessoaJuridicaComponent,
    SucessoComponent,
    ErroComponent,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    NgxMaskModule.forRoot(),
    AppRoutingModule
  ],
  providers: [
    CadastroService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
