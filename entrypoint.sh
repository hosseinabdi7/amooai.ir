#!/bin/bash

# Install EF Core tools
dotnet tool install --global dotnet-ef

# Run database migrations
echo "Running database migrations..."
dotnet ef database update

# Start the application
echo "Starting the application..."
exec dotnet AmooAI.dll 