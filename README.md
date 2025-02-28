    Developing a Resilient & Scalable REST API with Hexagonal Architecture & DDD

:warning: This solution intentionally remains incomplete, serving solely as a demonstration of constructing a resilient infrastructure.

⚠️ This solution deliberately forgoes the implementation of security best practices, as it is intended solely as a demonstration project.

------------------------------------------------------------------------------------------------------------------------------
# 🍽️ **DinnerBooking**  

> **Plateforme de réservation de dîners**, permettant aux utilisateurs de transformer leurs salles à manger en **restaurants privés**.  
> Conçu avec une **architecture moderne et scalable**, ce projet illustre les bonnes pratiques en **.NET et DDD (Domain-Driven Design)**.  

![DinnerBooking](https://via.placeholder.com/1000x300.png?text=DinnerBooking+App)  
*(Tu peux remplacer cette image par un vrai visuel de l'application !)*  

---

## 📌 **Technologies & Outils**  

### 🖥 **Backend**  
- **.NET 6 (ASP.NET Core)** – API REST structurée et optimisée  
- **CQRS avec MediatR** – Séparation claire des commandes et requêtes  
- **Entity Framework Core** – ORM pour la gestion des données  
- **Repository & Unit of Work Patterns** – Gestion efficace des entités  
- **DDD (Domain-Driven Design)** – Architecture hexagonale & séparation des domaines  

### 🎨 **Frontend** *(Non implémenté mais peut être ajouté plus tard)*  
- Prévu pour **Angular 18** ou **React** *(Possibilité d’évolution ! 🚀)*  

### 🗄 **Base de données**  
- **SQL Server** – Stockage principal  
- **SQLite** *(option pour tests & développement rapide)*  

### 🚀 **DevOps & CI/CD**  
- **Docker** – Conteneurisation pour déploiement flexible  
- **GitHub Actions** – CI/CD pour build & tests automatisés *(si ajouté plus tard)*  

---

## 🎯 **Fonctionnalités Clés**  

✅ **Gestion des réservations** – Les hôtes peuvent publier leurs disponibilités et les invités réserver  
✅ **Validation & Sécurité** – Authentification JWT, validation des données  
✅ **Architecture modulaire** – Facilité d’extension avec de nouvelles fonctionnalités  
✅ **Optimisation des requêtes** – Utilisation avancée de **LINQ & Entity Framework**  
✅ **Tests automatisés** *(TDD-ready)* – **xUnit, Moq, FluentAssertions**  

---

## ⚙️ **Installation & Lancement**  

### 1️⃣ **Prérequis**  
- .NET 6+ installé  
- SQL Server *(ou SQLite pour dev rapide)*  
- Docker *(optionnel pour exécuter les services en conteneurs)*  

### 2️⃣ **Cloner le repo**  
```bash
git clone https://github.com/DziriM/DinnerBooking.git
cd DinnerBooking
```

### 3️⃣ **Configurer la base de données**
- Mettre à jour appsettings.json pour pointer vers votre SQL Server
- Appliquer les migrations EF Core :
```bash
dotnet ef database update
```

### 4️⃣ **Lancer l’API**
- Accéder à Swagger UI : http://localhost:5000/swagger

### 📖 Architecture & Explication
DinnerBooking suit une architecture hexagonale avec les principes DDD & CQRS :

- 📌 Domain – Logique métier pure (Aggrégats, Entities, Value Objects)
- 📌 Application – Services applicatifs & gestion des commandes/requêtes (CQRS + MediatR)
- 📌 Infrastructure – Accès aux données, stockage, communication avec SQL Server
- 📌 API – Exposition des endpoints REST avec validation des entrées
- 📌 Gestion avancée des requêtes
- 📌 CQRS avec MediatR – Séparation claire des lectures/écritures
- 📌 Unit of Work & Repository – Gestion optimisée des transactions
- 📌 Validation & Sécurité – FluentValidation + JWT

### 🛠 Roadmap & Améliorations futures
- 🔹 Intégration d’un frontend Angular/React (UI moderne et interactive)
- 🔹 Ajout d’un système de paiements Stripe (Réservations payantes)
- 🔹 Support multi-base de données (PostgreSQL, MongoDB)
- 🔹 Monitoring avec Application Insights & Serilog


### 🤝 Contribuer au projet
Les contributions sont les bienvenues ! 🚀

- 📌 Fork le repo
- 📌 Crée une branche (git checkout -b feature-xxx)
- 📌 Fais tes modifications et commit (git commit -m "Ajout de xxx")
- 📌 Push ta branche et ouvre une Pull Request !

### 📄 Licence
- Ce projet est sous licence MIT – Utilisation et modification libres !
