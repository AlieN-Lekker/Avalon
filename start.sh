#!/bin/bash
# Starts backend and frontend

dotnet run --project src/AvelonApi/AvelonApi.csproj &
cd AvelonFront.web && npm start
