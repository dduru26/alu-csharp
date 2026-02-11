#!/usr/bin/env bash

# Initialize a new C# console project in a folder named 2-new_project
dotnet new console -o 2-new_project

# Modify the .csproj file to target .NET 7.0
sed -i 's/<TargetFramework>.*<\/TargetFramework>/<TargetFramework>net7.0<\/TargetFramework>/g' 2-new_project/2-new_project.csproj

# Modify Program.cs to output "Hello World!" instead of "Hello, World!"
sed -i 's/Console.WriteLine("Hello, World!");/Console.WriteLine("Hello World!");/' 2-new_project/Program.cs

# Build the project
dotnet build 2-new_project

# Run the project
dotnet run --project 2-new_project
