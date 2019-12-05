import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';

import { Cliente } from '../cliente';
import { CadastroService } from '../cadastro.service';

@Component({
  selector: 'cc-pessoa-juridica',
  templateUrl: './pessoa-juridica.component.html',
  styleUrls: ['./pessoa-juridica.component.css']
})
export class PessoaJuridicaComponent implements OnInit {

  cadastroForm: FormGroup;
  loading: boolean = false;

  constructor(
    private cadastroService: CadastroService,
    private router: Router,
    private formBuilder: FormBuilder
    ) { }

  ngOnInit(): void {
    this.cadastroForm = this.formBuilder.group({
      cnpj: ['',
        [
          Validators.required,
          Validators.pattern('[0-9]{2}\.?[0-9]{3}\.?[0-9]{3}\/?[0-9]{4}\-?[0-9]{2}')
        ]
      ],
      razaoSocial: ['',
        [
          Validators.required
        ]
      ],
      telefone: ['',
        [
          Validators.required,
          Validators.minLength(10)
        ]
      ],
      cep: ['',
        [
          Validators.required,
          Validators.minLength(8),
          Validators.maxLength(8)
        ]
      ],
      pais: ['',
        [
          Validators.required
        ]
      ],
      estado: ['',
        [
          Validators.required
        ]
      ],
      cidade: ['',
        [
          Validators.required
        ]
      ],
      bairro: ['',
        [
          Validators.required
        ]
      ],
      numero: ['',
        [
          Validators.required
        ]
      ],
      complemento: ['',
        []
      ],
      renda: ['',
        [
          Validators.required
        ]
      ],
      tipo: 'PJ'
    });
  }

  submit(){
    this.loading = true;

    const newCadastro = this.cadastroForm.getRawValue() as Cliente
    console.log(newCadastro);

    this.cadastroService
            .inserirCliente(newCadastro)
            .subscribe(
                () => { this.loading = false; this.router.navigate(['']) },
                err => { this.loading = false; console.log(err) }
            );
  }

}
