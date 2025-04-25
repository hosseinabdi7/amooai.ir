# Build stage
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["AmooAI.csproj", "./"]
RUN dotnet restore "AmooAI.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet build "AmooAI.csproj" -c Release -o /app/build

# Publish stage
FROM build AS publish
RUN dotnet publish "AmooAI.csproj" -c Release -o /app/publish

# Final stage
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY --from=build /src/entrypoint.sh .
RUN chmod +x ./entrypoint.sh

# Create wwwroot directory and copy static files
RUN mkdir -p /app/wwwroot
COPY wwwroot /app/wwwroot

# Expose ports
EXPOSE 80
EXPOSE 443

# Set environment variables
ENV ASPNETCORE_ENVIRONMENT=Production
ENV DOTNET_RUNNING_IN_CONTAINER=true

# Start the application
ENTRYPOINT ["./entrypoint.sh"] 