# Sales API (DDD)

> 🇧🇷 Portuguese version available here: [README.pt-BR.md](README.pt-BR.md)

## 📌 About the Project

This project is a RESTful API designed to manage sales records.

It was developed as part of a technical evaluation and follows **Domain-Driven Design (DDD)** principles, focusing on clear domain modeling, separation of concerns, and scalability.

---

## 🚀 Tech Stack

- PHP / Laravel
- MySQL
- RESTful API
- Docker (optional)

---

## 🧠 Architecture

The application is structured using DDD-inspired layers:

- **Domain**: core business rules and entities
- **Application**: use cases and orchestration
- **Infrastructure**: database, controllers, and external integrations

The project also applies the **External Identities pattern** to reference entities across domains.

---

## 📦 Features

- Full CRUD operations for sales
- Sales item management
- Automatic calculation of:
  - Item totals
  - Sale total amount
  - Discounts
- Sale and item cancellation support

---

## 📏 Business Rules

- Up to 3 identical items: **no discount**
- 4 to 9 items: **10% discount**
- 10 to 20 items: **20% discount**
- More than 20 identical items: **not allowed**

---

## 📣 Domain Events

The application includes domain event handling:

- SaleCreated
- SaleModified
- SaleCancelled
- ItemCancelled

> Events are logged for demonstration purposes (no message broker integration).

---

## ▶️ Running the Project

```bash
# Clone repository
git clone <your-repo-url>

# Install dependencies
composer install

# Configure environment
cp .env.example .env

# Generate app key
php artisan key:generate

# Run migrations
php artisan migrate

# Start server
php artisan serve