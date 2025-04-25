#!/bin/bash

# Wait for PostgreSQL to be ready
echo "Waiting for PostgreSQL to be ready..."
while ! nc -z shortline.proxy.rlwy.net 39110; do
  sleep 1
done
echo "PostgreSQL is ready!"

# Install EF Core tools
dotnet tool install --global dotnet-ef

# Run database migrations
echo "Running database migrations..."
dotnet ef database update

# Start the application
echo "Starting the application..."
exec dotnet AmooAI.dll 