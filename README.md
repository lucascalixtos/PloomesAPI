# PloomesAPI


## Utilizando a API

Esta API está hospedada no seguinte endereço: https://apiploomes20200930100335.azurewebsites.net/api/ . Todos os métodos serão acessados pelo mesmo.

### Métodos

TODAS as requisições devem ter o seguinte header: Content-type application/json

### POST /Usuarios - Criação de usuários

Url da requisição: https://apiploomes20200930100335.azurewebsites.net/api/Usuarios

Body da requisição:
```json
  {
    "Nome": "Usuario",
    "Sobrenome": "Exemplo",
    "Email": "teste@email.com",
    "Senha": "123",
    "Telefone" :"4444-4444"
  }
 ```
 
Resposta da requisição - 201 Created:

``` json
{
  "id": 12,
  "nome": "Usuario",
  "sobrenome": "Exemplo",
  "email": "teste@email.com",
  "senha": "123",
  "telefone": "4444-4444"
}
```
 
### GET /Usuarios - Listar usuários

Url da requisição: https://apiploomes20200930100335.azurewebsites.net/api/Usuarios

Body da requisição: não contém

Resposta da requisição - 200 Ok:
 ```json
[
  {
    "id": 2,
    "nome": "Lucas",
    "sobrenome": "Calixto",
    "email": "lucas@gmail.com",
    "senha": "123",
    "telefone": "4444-4444"
  },
  {
    "id": 3,
    "nome": "Teste",
    "sobrenome": "Calixto",
    "email": "teste@il.com",
    "senha": "123",
    "telefone": "4444-4444"
  }
]
```

### DELETE /Usuarios - Deletar usuário específico

Url da requisição: https://apiploomes20200930100335.azurewebsites.net/api/Usuarios/{id}

Body da requisição: não contém

Resposta da requisição - 200 Ok:

```json
{
  "id": 12,
  "nome": "Usuario",
  "sobrenome": "Exemplo",
  "email": "teste@email.com",
  "senha": "123",
  "telefone": "4444-4444"
}
```

### GET /Usuarios/{id} - Listar usuário específico pelo ID

Url da requisição: https://apiploomes20200930100335.azurewebsites.net/api/Usuarios/{id}

Body da requisição: não contém

Resposta da requisição - 200 Ok:

```json
{
  "id": 12,
  "nome": "Usuario",
  "sobrenome": "Exemplo",
  "email": "teste@email.com",
  "senha": "123",
  "telefone": "4444-4444"
}
```

### PUT /Usuarios/{id} - Editar um usuário específico por ID

Url da requisição: https://apiploomes20200930100335.azurewebsites.net/api/Usuarios/{id}

Body da requisição:

```json
{
	"id": "10",
	"Nome": "User",
	"Sobrenome": "Exemplo",
	"Email": "teste@email.com",
	"Senha": "123",
	"Telefone" :"4444-4444"
}
```

Resposta da requisição - 204 No Content

### GET /Usuarios/PaginacaoUsuario?pagina={NumeroPágina}&quantidadeRegistros={TotaldeRegistrosPorPagina} - Paginação de usuários por número e total de registros por página

Url da requisição: https://apiploomes20200930100335.azurewebsites.net/api/Usuarios/PaginacaoUsuario?pagina={NumeroPágina}&quantidadeRegistros={TotaldeRegistrosPorPagina}

Body da requisição: não contém

Resposta da requisição - 200 Ok:

```json
[
  {
    "id": 7,
    "nome": "Usuario6",
    "sobrenome": "Calixto",
    "email": "testeil.com",
    "senha": "123",
    "telefone": "4444-4444"
  },
  {
    "id": 8,
    "nome": "Usuario7",
    "sobrenome": "Calixto",
    "email": "testeil.com",
    "senha": "123",
    "telefone": "4444-4444"
  },
  {
    "id": 9,
    "nome": "Usuario8",
    "sobrenome": "Calixto",
    "email": "testeil.com",
    "senha": "123",
    "telefone": "4444-4444"
  },
  {
    "id": 10,
    "nome": "Usuario9",
    "sobrenome": "Calixto",
    "email": "testeil.com",
    "senha": "123",
    "telefone": "4444-4444"
  },
  {
    "id": 11,
    "nome": "Usuario10",
    "sobrenome": "Calixto",
    "email": "testeil.com",
    "senha": "123",
    "telefone": "4444-4444"
  }
]
```

### GET /Usuarios/LimitarUsuariosPorId?offset={IdInicial}&limit={IdFinal} - Filtrar usuários dentro de um intervalo entre {IdInicial} e {IdFinal}

Url da requisição: https://apiploomes20200930100335.azurewebsites.net/api/Usuarios/LimitarUsuariosPorId?offset={IdInicial}&limit={IdFinal}

Resposta da requisição - 200 Ok:

```json
[
  {
    "id": 3,
    "nome": "Teste",
    "sobrenome": "Calixto",
    "email": "testeil.com",
    "senha": "123",
    "telefone": "4444-4444"
  },Re
  {
    "id": 4,
    "nome": "Usuario3",
    "sobrenome": "Calixto",
    "email": "testeil.com",
    "senha": "123",
    "telefone": "4444-4444"
  },
  {
    "id": 5,
    "nome": "Usuario4",
    "sobrenome": "Calixto",
    "email": "testeil.com",
    "senha": "123",
    "telefone": "4444-4444"
  },
  {
    "id": 6,
    "nome": "Usuario5",
    "sobrenome": "Calixto",
    "email": "testeil.com",
    "senha": "123",
    "telefone": "4444-4444"
  },
  {
    "id": 7,
    "nome": "Usuario6",
    "sobrenome": "Calixto",
    "email": "testeil.com",
    "senha": "123",
    "telefone": "4444-4444"
  },
  {
    "id": 8,
    "nome": "Usuario7",
    "sobrenome": "Calixto",
    "email": "testeil.com",
    "senha": "123",
    "telefone": "4444-4444"
  }
]
```

### GET /Usuarios/GetByName/{nome} - Busca usuários por nome específico

Url da requisição: https://apiploomes20200930100335.azurewebsites.net/api/Usuarios/GetByName/{nome}

Resposta da requisição - 200 Ok:

```json
[
  {
    "id": 2,
    "nome": "User2",
    "sobrenome": "Exemplo",
    "email": "teste@email.com",
    "senha": "123",
    "telefone": "4444-4444"
  }
]
```



