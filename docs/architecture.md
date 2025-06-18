# Avelon Framework Architecture

## Authentication & Authorization
- **Method**: JSON Web Tokens (JWT)
- **Token Type**: Bearer tokens
- Stateless authentication with token generation, expiration, and refresh logic.

## Version Control
- **Repository Management**: GitHub
- Separate repositories for core framework and microservices.
- GitFlow or trunk-based branching strategy.
- Continuous Integration via GitHub Actions.

## Validation Strategy
- **Database-level**: constraints (unique, not null, foreign keys).
- **API-level**: data annotations and FluentValidation with standardized error responses.

## Notification Services
- **Primary**: Email via SMTP or third-party providers (SendGrid, Mailgun).
- **Secondary**: SMS via third-party gateways such as Twilio.
- Template-based messaging for consistency.

## Reporting & Documentation
- **Tool**: Sciber Documentation for report generation.
- Standard templates documented in this repository.
- Reports available via secured API endpoints or dashboards.

## Summary of Core Components

| Component                   | Selected Technology         |
| --------------------------- | --------------------------- |
| Authentication              | JWT (Bearer Tokens)         |
| Version Control             | GitHub                      |
| Validation                  | Database & API logic        |
| Notification                | Email & SMS                 |
| Reporting & Documentation   | Sciber Documentation        |

## Database

- **Provider**: MongoDB
- **Schemas**: `User`, `Product`, `AuditLog`

## Layered Structure

```
src/
├── AvelonData/        # database context
├── AvelonController/  # data transfer objects
├── AvelonDomain/      # domain models
├── AvelonService/     # business logic
├── AvelonEngine/      # engine orchestrating logic
└── AvelonApi/         # ASP.NET Web API
```

The API layer depends on the engine, which uses business logic classes interacting with the database and models. DTOs are used to expose data through the API and between layers.

## Project Layout

```
repo/
├── src/            # C# backend projects
├── AvelonFront.web/       # Angular client app
├── docs/           # Documentation
└── README.md
```

This document serves as the high-level overview of the **Avelon** framework. Further documentation and examples will be added as development progresses.
