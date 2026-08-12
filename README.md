# 🚀 System Management Portal (Users & Projects)

Um sistema robusto e moderno desenvolvido em C# / ASP.NET Core com controle total de autenticação, gestão de usuários e administração de projetos.

---

## 📌 Índice

- Visão Geral
- Funcionalidades Principais
- Arquitetura e Tecnologias
- Telas e Fluxo da Aplicação
- Pré-requisitos
- Como Executar o Projeto
- Estrutura do Projeto
- Autor
- Licença

---

## 🔎 Visão Geral

O System Management Portal foi projetado para oferecer uma solução completa de gerenciamento corporativo. Utilizando o ASP.NET Core Identity, o projeto garante autenticação segura (Login, Logout e Registro) com suporte a perfis de acesso (Roles/Permissões), permitindo que administradores gerenciem tanto a base de usuários quanto o ciclo de vida de diversos projetos.

---

## ✨ Funcionalidades Principais

### 🔐 Autenticação & Segurança (ASP.NET Core Identity)
- Login & Logout: Autenticação baseada em cookies/tokens seguros.
- Registro de Usuários: Cadastro com validação de e-mail, senha forte e hash seguro.
- Gerenciamento de Sessão: Expiração de sessão e proteção contra CSRF/XSS.
- Controle de Acesso (RBAC): Níveis de permissão (ex: Admin, Manager, User).

### 👥 Administração de Usuários
- Listagem Completa: Visualização paginada com busca e filtros.
- Cadastro e Edição: Edição de dados do perfil, alteração de senhas e papéis (Roles).
- Ativação / Desativação: Bloqueio de acessos com suporte a Lockout.

### 📁 Gestão de Projetos
- CRUD Completo de Projetos: Criação, visualização, atualização e exclusão de projetos.
- Vinculação de Usuários: Atribuição de responsáveis e membros de equipe a cada projeto.
- Status e Prazos: Acompanhamento de progresso (Em Aberto, Em Andamento, Concluído, Cancelado).

---

## 🛠 Arquitetura e Tecnologias

- Linguagem: C# (.NET 8.0)
- Framework Web: ASP.NET Core MVC / Razor Pages
- Autenticação: ASP.NET Core Identity
- ORM / Banco de Dados: Entity Framework Core (SQL Server / PostgreSQL / SQLite)
- Frontend: HTML5, CSS3, JavaScript, Bootstrap 5

---

## 🖥 Telas e Fluxo da Aplicação

1. Tela de Login: Entrada no sistema com validação em tempo real e opção "Lembrar-me".
2. Dashboard / Painel Central: Resumo dos projetos ativos e estatísticas de usuários.
3. Gerenciamento de Usuários: Tabela intuitiva para editar perfis e redefinir credenciais.
4. Gerenciamento de Projetos: Interface de cadastro, filtro por status e inclusão de equipes.
5. Logout Seguro: Encerramento da sessão com limpeza dos tokens de autenticação.

---

## ⚙️ Pré-requisitos

Antes de começar, garanta que você possui instalado em sua máquina:

- .NET 8.0 SDK
- Git
- SQL Server ou SQLite
- IDE recomendada: Visual Studio 2022 ou VS Code

---

## 🚀 Como Executar o Projeto

### 1. Clonar o repositório
```bash
git clone [https://github.com/lucasmoraes/projeto-csharp-identity.git](https://github.com/lucasmoraes/projeto-csharp-identity.git)
cd projeto-csharp-identity


by GustavoAndrade0
