# CQRS & Medaitor Project 

This project is an implementation of a robust software architecture utilizing CQRS with Mediator pattern for command/query segregation, Fluent Validation for clear and concise validation rules, AutoMapper for simplified object mapping, Generic Repository for abstracted data access, Custom Exceptions for handling application-specific errors. This hands-on exercise provides practical experience in building scalable, maintainable applications with a focus on the separation of concerns and code reusability. also, Unit Testing and Email Sending are used.

## Table of Contents

- [Prerequisites](#prerequisites).
- [General Definitions](#generaldefinitions).
- [Installation and  Getting Started](#gettingStarted).
- [Usage](#usage).
- [Contributing](#contributing).
- [License](#license)
- Technology Used

  
## Prerequisites

- .NET Core/.NET 8.
- Visual Studio.
- C# Programming Skills.
- Dependency Injection.
- Unit Testing Skills.
- SQL Server.
- EF Core/ LINQ.
- onion architecture
- 

## General Definitions
What is CQRS and what are its benefits?
-Command Query Responsibility Segregation (CQRS) is a software architectural pattern that suggests separating the operations that read data (queries) from those that modify data (commands) into different parts of the application. 
--Benefits of CQRS include:
1-Simplified Model
2-Scalability
3-Performance Optimization
4-Flexibility

What is onion architecture?
Onion Architecture is a software architectural pattern that emphasizes the separation of concerns and the dependency inversion principle. In this architecture, the core business logic and domain model are placed at the center (the innermost layer), surrounded by layers representing different concerns, such as application services, interfaces, and infrastructure.

Key Components of the Onion Architecture  
Core Domain
Application Services:
Persistence
Infrastructure
Presentation

## Installation and  Getting Started 

### We will divide this project into main Sections 
1 - Setting UP application core (CQRS-Mediator).
2 - Manage relations between Entities.
3 - Setting up infrastructure.
4 - Adding API Layer.
5 - Setting Up Testing. 

### Explanation of Each Section
# Setting UP application core (CQRS-Mediator).
- Create Project 
   Create Solution 
   Create Key Components
     Src
       API
       Core 
       Infrastructure
       UI
     Test
  -Create layers
    

     
     
#### Setting UP application cor e (CQRS-Mediator)

## Technology Used
AutoMapper
moqshouldly
EF Core


## Usage

Examples and instructions on how to use the project. Include code snippets if necessary.

## Contributing

Guidelines for contributing to the project, including how to report issues or submit pull requests.

## Additional Sections (Optional)

Depending on your project, you might want to include additional sections such as:

- **Acknowledgements**: Credits to individuals or organizations that helped or inspired the project.
- **FAQ**: Frequently asked questions and their answers.
- **Support**: Information on how users can get support if they encounter issues.
- **Changelog**: Record of changes made to the project over time.

## Contact

Provide contact information if users have questions or need further assistance.
  

