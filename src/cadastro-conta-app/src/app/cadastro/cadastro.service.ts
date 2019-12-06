import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';

import { Cliente } from './cliente';

const API_URL = "http://localhost:5000/api/clientes";

@Injectable()
export class CadastroService {

  constructor(private http: HttpClient) { }

  inserirCliente(newCliente: Cliente) {
    return this.http.post(API_URL, newCliente);
  }
}
