#!/usr/bin/env bash
set -euo pipefail

PROJECT_DIR="2-new_project"
PROJECT_NAME="NewProject"

# Create the project directory
mkdir -p "$PROJECT_DIR"
cd "$PROJECT_DIR"

# Initialize a new C# console project
dotnet new console -n "$PROJECT_NAME"

# Build the project
dotnet build "$PROJECT_NAME"

# Run the project
dotnet run --project "$PROJECT_NAME"
