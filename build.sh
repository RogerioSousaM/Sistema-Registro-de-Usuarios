#!/bin/bash

# Build script for ASP.NET Core on Vercel
echo "Starting build process..."

# Restore dependencies
dotnet restore

# Build the project
dotnet build -c Release

# Publish the application
dotnet publish -c Release -o ./publish

echo "Build completed successfully!" 