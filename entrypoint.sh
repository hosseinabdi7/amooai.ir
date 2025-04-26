#!/bin/bash

# Run database update
echo "Updating database..."
cd /app
dotnet ef database update

# Start the application
echo "Starting the application..."
exec dotnet AmooAI.dll 