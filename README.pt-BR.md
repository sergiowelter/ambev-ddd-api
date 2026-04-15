
---

# 📄 🇧🇷 README.pt-BR.md (português)

```md
# Sales API (DDD)

> 🇺🇸 English version available here: [README.md](README.md)

## 📌 Sobre o projeto

Este projeto é uma API RESTful para gerenciamento de vendas.

Foi desenvolvido como parte de um desafio técnico e segue princípios de **Domain-Driven Design (DDD)**, com foco em modelagem de domínio, separação de responsabilidades e escalabilidade.

---

## 🚀 Tecnologias utilizadas

- PHP / Laravel
- MySQL
- API REST
- Docker (opcional)

---

## 🧠 Arquitetura

A aplicação foi estruturada utilizando camadas inspiradas em DDD:

- **Domain**: regras de negócio e entidades
- **Application**: casos de uso
- **Infrastructure**: banco de dados, controllers e integrações externas

Também foi aplicado o padrão **External Identities** para referência entre entidades de diferentes domínios.

---

## 📦 Funcionalidades

- CRUD completo de vendas
- Gerenciamento de itens da venda
- Cálculo automático de:
  - Total por item
  - Total da venda
  - Descontos
- Cancelamento de vendas e itens

---

## 📏 Regras de negócio

- Até 3 itens iguais: **sem desconto**
- De 4 a 9 itens: **10% de desconto**
- De 10 a 20 itens: **20% de desconto**
- Acima de 20 itens iguais: **não permitido**

---

## 📣 Eventos de domínio

A aplicação registra eventos:

- SaleCreated
- SaleModified
- SaleCancelled
- ItemCancelled

> Os eventos são apenas logados (sem uso de mensageria).

---

## ▶️ Como executar o projeto

```bash
# Clonar repositório
git clone <your-repo-url>

# Instalar dependências
composer install

# Configurar ambiente
cp .env.example .env

# Gerar chave da aplicação
php artisan key:generate

# Executar migrations
php artisan migrate

# Subir servidor
php artisan serve