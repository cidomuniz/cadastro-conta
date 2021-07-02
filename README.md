# cadastro-conta
Simple customer registration for credit.

Project made with Angular, .NET Core and MongoDB.

1. [ Requirements. ](#req)
2. [ Front-End. ](#front)
3. [ API. ](#api)
4. [ Live test. ](#live)

<a name="req"></a>
## Requirements
Node.js 6.x, SDK Docker, Docker-Compose

### Run Docker (raiz do projeto)
```
docker-compose up
```
<a name="front"></a>
## Front-End Local
```
http://localhost:4200/
```

### Exemplo dados de entrada
Nome: João da Silva

CPF: 78733371890

Estado Civil: Solteiro

Data Nascimento: 05/07/1987

Telefone: 1137622479

Endereço: Rua Marechal Teodoro

CEP: 12231675

País: Brasil

Estado: SP

Cidade: SJC

Bairro: Jd Satelite

Número: 1065

Complemento: N/A

Renda Mensal: 4500

<a name="api"></a>
## API Local
```
http://localhost:5000/api/
```
```
Recuperar todos os clientes
GET /clientes
```
```
Recupar um cliente
GET /clientes/:id
```
```
Criar um cliente
POST /clientes
{
	"tipo": "PF",
	"bairro": "vila alta",
	"cep": "02131080",
	"cidade": "São Paulo",
	"complemento": "dfdf",
	"cpf": "25455454545",
	"dataNascimento": "1997-01-21",
	"estado": "SP",
	"estadoCivil": "casado",
	"nome": "LEO OLI",
	"numero": "156",
	"pais": "Brasil",
	"renda": 2323.88,
	"telefone": "11945687539"
}
```
