# Avalon Framework

This repository contains the main framework for Avalon, built with a C# backend and an Angular frontend. Run `./start.sh` to launch the API and development frontend. MongoDB is required via the `MongoDb` connection string.

## Structure

- `src/` - C# backend
  - `Avalon.Data/` - database context
  - `Avalon.Contracts/` - data transfer objects
  - `Avalon.Domain/` - domain models
  - `Avalon.Business/` - business logic
  - `Avalon.Core/` - engine orchestrating logic
  - `Avalon.Api/` - ASP.NET Web API with controllers and services
- `frontend/` - Angular client
- `docs/` - documentation

See [docs/architecture.md](docs/architecture.md) for an overview of the framework.
