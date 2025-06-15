#!/bin/bash
# Starts backend and frontend

dotnet run --project src/Avalon.Api/Avalon.Api.csproj &
cd frontend && npm start
