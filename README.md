# 🦸‍♂️ SuperHero API 
Este projeto é uma Web API desenvolvida com .NET 8 e Entity Framework Core, utilizando SQLite como banco de dados. A arquitetura é baseada em camadas, promovendo a separação de responsabilidades e facilitando a manutenção e escalabilidade da aplicação.

 ## 📐 Arquitetura do Projeto
A estrutura do projeto está organizada da seguinte forma:

* **Controllers:** Responsáveis por receber as requisições HTTP e retornar as respostas adequadas.<br>

* **Services:** Contêm a lógica de negócios da aplicação.<br>

* **Repositories:** Responsáveis pelo acesso e manipulação dos dados no banco de dados.<br>

* **DTOs (Data Transfer Objects):** Utilizados para transferir dados entre as camadas de forma segura e eficiente.<br>

* **Exceptions:** Gerenciam os erros personalizados e tratam exceções de forma centralizada.<br>

## 🛠 Funcionalidades
Esta API implementa um CRUD completo para o gerenciamento de super-heróis:

## ✅ Criação de heróis
✏️ Atualização de heróis

❌ Exclusão de heróis

📋 Listagem de heróis e seus poderes

🔍 Visualização de detalhes de um herói

## 🗃 Tecnologias Utilizadas
* .NET 8
* Entity Framework Core
* SQLite

## 🚀 Como Executar o Projeto Localmente
### Pré-requisitos
* .NET 8 SDK <br>
* Um editor como o Visual Studio ou Visual Studio Code

### Clone o repositório:
```c
git clone https://github.com/lyndark/Viceri.SuperHero.git
cd Viceri.SuperHero
```
### Restaure as dependências:
```c
dotnet restore
```
### Aplique as migrations e crie o banco SQLite:
```c
dotnet ef database update
```
### Execute a aplicação:
```c
dotnet run
```
### Acesse a API pelo navegador ou por ferramentas como Postman ou Swagger:
```bash
https://localhost:7035/swagger
```

### 📦 Exemplos de Requisições
#### ➕ Criar um Heróis
```http
POST /Hero/CreateHero
Content-Type: application/json
```
```json
{
  "name": "Peter Parker",
  "heroName": "Spider Man",
  "dateOfBirth": "1965-05-05T18:02:57.389",
  "height": 1,78,
  "weight": 75.75
}
```
#### 📋 Listar Todos os Heróis
```http
GET /Hero/ListHero
```
#### 🔍 Detalhes de um Herói
```http
GET /Hero/GetHero/{id}
```
#### ✏️ Atualizar um Herói
```http
PUT /Hero/UpdateHero/{id}
Content-Type: application/json
```
```json
{
  "name": "Anthony Stark",
  "heroName": "Homem de Ferro",
  "dateOfBirth": "2025-05-05T18:16:27.410Z",
  "height": 0,
  "weight": 0
}
```
#### ❌ Deletar um Herói
```http
DELETE /Hero/DeleteHero/{id}
```
