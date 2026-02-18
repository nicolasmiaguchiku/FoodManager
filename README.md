# FoodManager.Catalog API

API REST para gerenciamento de produtos e categorias, desenvolvida em ASP.NET Core.

Este é um projeto desenvolvidos com o objetivo de gerenciar comidas de um estabelecimento aplicando boas praticas de desenvolvimento backend .NET,
com arquitetura limpa, DDD, autenticação, um pacote externo desenvolvido por mim, desings patterns, pesistencias de dados e integração com banco de dados não relacional


## 🛠 Tecnologias
- .NET 10
- ASP.NET Core Web API
- Docker
- MongoDb
- Keycloak
- LiteBus
- FluentValidation
- CQRS + Repository Pattern
- FoodManager.Internal.Shared


## 🧪 Testes
- Moq
- xUnit
- AutoFixture
- FluentAssertions
- NetArchTest


## 🧱 Arquitetura
- Separação em camadas:
  - Domain
  - Application
  - Infrastructure
  - API
  - IoC


## ⚙️ Funcionalidades
- [x] CRUD de produtos
- [x] Upload de imagens
- [ ] Autenticação com JWT

## 🚀 Como executar o projeto

### Opção 1: Usando Docker (recomendado)

Pré-requisitos:
- Docker

```bash
git clone https://github.com/nicolasmiaguchiku/FoodManager.Catalog.git
cd FoodManager.Catalog
docker-compose up --build
```


### Opção 2: rodar sem Docker (localmente)

Aqui você executa a API usando o .NET SDK instalado e conecta direto a um banco local.

Pré-requisitos:
- .NET SDK .NET 10
- Banco de dados MongoDb (mongodb Atlas)

```bash
git clone https://github.com/nicolasmiaguchiku/FoodManager.Catalog.git
cd FoodManager.Catalog
dotnet restore
dotnet run
```
## 👤 Autor

Desenvolvido por **Nicolas Miaguchiku**

- GitHub: https://github.com/nicolasmiaguchiku
- LinkedIn: https://www.linkedin.com/nicolas-miaguchiku
