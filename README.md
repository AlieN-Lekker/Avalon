# Avalon Framework

This repository contains the main framework for Avalon, built with a C# backend and an Angular frontend. Run `./start.sh` to launch the API and development frontend. MongoDB is required via the `MongoDb` connection string.

## Getting Started

Before running the API for the first time, restore all C# dependencies:

```bash
dotnet restore
```

The backend can then be launched with:

```bash
dotnet run --project src/AvelonApi/AvelonApi.csproj
```

For the frontend, install Node dependencies inside the `AvelonFront.web/` directory prior to starting the development server:

```bash
cd AvelonFront.web
npm install
npm start
```


## Structure
Each folder contains its own .csproj project file, e.g. `src/AvelonApi/AvelonApi.csproj`.

- `src/` - C# backend
  - `AvelonData/` - database context
  - `AvelonController/` - data transfer objects
  - `AvelonDomain/` - domain models
  - `AvelonService/` - business logic
  - `AvelonEngine/` - engine orchestrating logic
  - `AvelonApi/` - ASP.NET Web API with controllers and services
- `AvelonFront.web/` - Angular client
- `docs/` - documentation

See [docs/architecture.md](docs/architecture.md) for an overview of the framework.
