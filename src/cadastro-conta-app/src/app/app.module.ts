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


@NgModule({
  declarations: [
    AppComponent,
    CadastroComponent,
    PessoaFisicaComponent,
    PessoaJuridicaComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    NgxMaskModule.forRoot()
  ],
  providers: [
    CadastroService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
