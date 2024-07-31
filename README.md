# Pessoa API

Uma API simples para gerenciar uma lista de pessoas usando .NET.

## Endpoints

### Listar todas as pessoas

**GET** `/pessoas`

Resposta:
```json
[
    {
        "id": 1,
        "nome": "Nome da Pessoa",
        "email": "email@exemplo.com"
    },
    ...
]
```

### Obter uma pessoa por ID

**GET** `/pessoas/{id}`

Resposta:
```json
{
    "id": 1,
    "nome": "Nome da Pessoa",
    "email": "email@exemplo.com"
}
```

### Adicionar uma nova pessoa

**POST** `/pessoas`

Corpo da Requisição:
```json
{
    "nome": "Nome da Pessoa",
    "email": "email@exemplo.com"
}
```

Resposta:
```json
{
    "id": 1,
    "nome": "Nome da Pessoa",
    "email": "email@exemplo.com"
}
```

### Atualizar uma pessoa existente

**PUT** `/pessoas/{id}`

Corpo da Requisição:
```json
{
    "nome": "Nome Atualizado",
    "email": "email@exemplo.com"
}
```

Resposta:
```json
{
    "id": 1,
    "nome": "Nome Atualizado",
    "email": "email@exemplo.com"
}
```

### Remover uma pessoa

**DELETE** `/pessoas/{id}`

Resposta:
- Status: `204 No Content`

## Como Executar

1. Certifique-se de ter o .NET instalado.
2. Clone este repositório.
3. No diretório do projeto, execute:
    ```bash
    dotnet run
    ```
4. A API estará disponível em `http://localhost:5000`.

## Dependências

- .NET 5.0 ou superior

## Contribuindo

Contribuições são bem-vindas! Sinta-se à vontade para abrir uma issue ou enviar um pull request.

## Licença

Este projeto está licenciado sob a Licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.
