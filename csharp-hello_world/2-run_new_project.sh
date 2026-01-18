#!/usr/bin/env bash
set -euo pipefail

PROJECT_DIR="2-new_project"
PROJECT_NAME="NewProject"

# Create project directory
mkdir -p "$PROJECT_DIR"
cd "$PROJECT_DIR"

# Initialize a new C# console project
dotnet new console -n "$PROJECT_NAME" -f net7.0

# Move into the project folder
cd "$PROJECT_NAME"

# Build the project
dotnet build

# Run the project
dotnet run