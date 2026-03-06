# 🌐 .NET API — Desafio de Projeto

![.NET](https://img.shields.io/badge/Framework-.NET-purple?logo=dotnet)
![C#](https://img.shields.io/badge/Language-C%23-blue?logo=csharp)
![API](https://img.shields.io/badge/Application-REST%20API-green)
![Status](https://img.shields.io/badge/Status-Completed-brightgreen)

Projeto desenvolvido como parte da **trilha .NET da Digital Innovation One (DIO)**.

O objetivo deste desafio foi desenvolver uma **API REST utilizando C# e ASP.NET**, aplicando conceitos fundamentais de desenvolvimento backend, persistência de dados e organização de aplicações web.

Este repositório faz parte do meu processo de aprendizado em **desenvolvimento backend com .NET**.

---

# 📚 Sobre o Projeto

Este projeto consiste no desenvolvimento de uma **API para gerenciamento de tarefas**, semelhante a uma **TODO List**.

A aplicação permite realizar operações de criação, leitura, atualização e remoção de tarefas, permitindo organizar atividades com informações como título, descrição, status e data de realização. ([LinkedIn][1])

O desafio foi projetado para praticar a construção de **APIs REST utilizando ASP.NET**, além da integração com banco de dados utilizando **Entity Framework**.

---

# 🎯 Objetivo do Desafio

O principal objetivo deste projeto é colocar em prática conceitos essenciais do desenvolvimento backend em .NET, incluindo:

* criação de **APIs REST**
* organização de **controllers e modelos**
* persistência de dados com **Entity Framework**
* manipulação de dados em banco relacional
* utilização de **HTTP verbs e rotas REST**

---

# ⚙️ Funcionalidades Implementadas

A API permite gerenciar tarefas através de endpoints REST.

Entre as principais funcionalidades estão:

* 📌 Criar novas tarefas
* 📋 Listar tarefas cadastradas
* 🔍 Buscar tarefas específicas
* ✏️ Atualizar informações de tarefas
* ❌ Remover tarefas

Cada tarefa pode conter informações como:

* título
* descrição
* status
* data prevista ou de conclusão

---

# 🔗 Estrutura da API

A aplicação segue a estrutura padrão de projetos **ASP.NET Web API**.

Exemplo de endpoints disponíveis:

| Método | Endpoint        | Descrição                     |
| ------ | --------------- | ----------------------------- |
| GET    | `/tarefas`      | Lista todas as tarefas        |
| GET    | `/tarefas/{id}` | Retorna uma tarefa específica |
| POST   | `/tarefas`      | Cria uma nova tarefa          |
| PUT    | `/tarefas/{id}` | Atualiza uma tarefa           |
| DELETE | `/tarefas/{id}` | Remove uma tarefa             |

---

# 🧠 Conceitos Aplicados

Durante o desenvolvimento deste projeto foram explorados conceitos importantes do ecossistema .NET.

### 🌐 Desenvolvimento de APIs REST

Criação de endpoints utilizando:

* controllers
* rotas
* verbos HTTP (`GET`, `POST`, `PUT`, `DELETE`)

---

### 🗄️ Persistência de Dados

Utilização do **Entity Framework** como ORM para realizar a comunicação entre a aplicação e o banco de dados.

---

### 📦 Programação Orientada a Objetos

Organização da aplicação utilizando:

* classes
* entidades
* separação de responsabilidades

---

### 📑 Modelagem de Dados

Criação de entidades que representam as informações manipuladas pela API.

---

# 🛠️ Tecnologias Utilizadas

Este projeto foi desenvolvido utilizando:

* **C#**
* **.NET**
* **ASP.NET Web API**
* **Entity Framework**
* **SQL Server**
* **Git**
* **GitHub**
* **Swagger**


[1]: https://pt.linkedin.com/posts/developergiovanesouza_github-giovanesouzatrilha-net-api-desafio-activity-7204097176279375872-q3fN?utm_source=chatgpt.com "GitHub - giovanesouza/trilha-net-api-desafio: Construindo um Sistema de Agendamento de Tarefas (API) com Entity Framework | Giovane Souza"
