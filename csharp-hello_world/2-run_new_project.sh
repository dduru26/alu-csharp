#!/usr/bin/env bash
set -euo pipefail

PROJECT_DIR="2-new_project"
PROJECT_NAME="NewProject"
PROGRAM_FILE="$PROJECT_DIR/$PROJECT_NAME/Program.cs"

mkdir -p "$PROJECT_DIR"
dotnet new console -n "$PROJECT_NAME" -o "$PROJECT_DIR/$PROJECT_NAME"

# Replace "Hello, World!" with "Hello World!"
sed -i 's/Hello, World!/Hello World!/' "$PROGRAM_FILE"

dotnet build "$PROJECT_DIR/$PROJECT_NAME"
dotnet run --project "$PROJECT_DIR/$PROJECT_NAME"
