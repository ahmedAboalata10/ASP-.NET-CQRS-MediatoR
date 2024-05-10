# CQRS & Mediator Project

This project implements a robust software architecture utilizing CQRS with the Mediator pattern for command/query segregation. It employs Fluent Validation for clear and concise validation rules, AutoMapper for simplified object mapping, a Generic Repository for abstracted data access, and Custom Exceptions for handling application-specific errors. This hands-on exercise provides practical experience in building scalable, maintainable applications with a focus on separation of concerns and code reusability. Additionally, it includes Unit Testing and Email Sending functionalities.

## Table of Contents

- [Prerequisites](#prerequisites)
- [General Definitions](#general-definitions)
- [Installation and Getting Started](#installation-and-getting-started)
- [Usage](#usage)
- [Contributing](#contributing)
- [Additional Sections (Optional)](#additional-sections-optional)
- [Contact](#contact)

## Prerequisites

- .NET Core/.NET 8
- Visual Studio
- C# Programming Skills
- Dependency Injection
- Unit Testing Skills
- SQL Server
- EF Core/LINQ
- Onion Architecture

## General Definitions

### CQRS and Its Benefits

Command Query Responsibility Segregation (CQRS) is a software architectural pattern that suggests separating operations that read data (queries) from those that modify data (commands) into different parts of the application. Benefits of CQRS include:

1. Simplified Model
2. Scalability
3. Performance Optimization
4. Flexibility

### Onion Architecture

Onion Architecture is a software architectural pattern that emphasizes the separation of concerns and the dependency inversion principle. In this architecture, the core business logic and domain model are placed at the center (the innermost layer), surrounded by layers representing different concerns, such as application services, interfaces, and infrastructure.

Key Components of the Onion Architecture:

- Core Domain
- Application Services
- Persistence
- Infrastructure
- Presentation

## Installation and Getting Started

### Project Sections

1. **Setting Up Application Core (CQRS-Mediator)**:
   - Create Project
   - Create Solution
   - Create Key Components
     - Src
       - API
       - Core
       - Infrastructure
       - UI
     - Test
   - Create Layers
     #### Create API Layer
     1. Add a reference to (application - infrastructure - presentation).
     2. Configure all services in the API Layer before `builder.build()`, including:
        - All layers configuration service
        - Connection string
        - Email Settings
        - CORS
     3. Add Migrations
        - Configure startup project & project of migration
        - Add EF tools for Migration
        - Locate Migrations Pristine
        - Add migration
     4. Create a controller
        - Inject MediatR in constructor
        - Create Action(Method-Route-RequestQuery)

   #### Seeding 
   - The main goal of seeding is to ensure the project runs without data.
   - Seeding is placed in pristine as it's where data exists.

2. **Manage Relations Between Entities**
3. **Setting Up Infrastructure**
4. **Adding API Layer**
5. **Setting Up Testing**

## Technology Used

- AutoMapper
- Moq
- Shouldly
- EF Core

## Usage

Examples and instructions on how to use the project. Include code snippets if necessary.

## Contributing

Guidelines for contributing to the project, including how to report issues or submit pull requests.

## Contact

Email: ahmed_c44@outlook.com
LinkedIn: [https://www.linkedin.com/in/ahmedaboalata/](https://www.linkedin.com/in/ahmedaboalata/)

