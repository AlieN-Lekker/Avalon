# Avalon Framework


This repository contains the main framework for Avalon, built with a C# backend and an Angular frontend. Run `./start.sh` to launch the API and development frontend. MongoDB is required via the `MongoDb` connection string.

## Getting Started

Before running the API for the first time, restore all C# dependencies:

```bash
dotnet restore
```

The backend can then be launched with:

```bash
dotnet run --project src/Avalon.Api/Avalon.Api.csproj
```

For the frontend, install Node dependencies inside the `frontend/` directory prior to starting the development server:

```bash
cd frontend
npm install
npm start
```

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
