    Developing a Resilient & Scalable REST API with Hexagonal Architecture & DDD

:warning: This solution intentionally remains incomplete, serving solely as a demonstration of constructing a resilient infrastructure.

⚠️ This solution deliberately forgoes the implementation of security best practices, as it is intended solely as a demonstration project.

------------------------------------------------------------------------------------------------------------------------------

Greetings and welcome to our public GitHub repository. 

Here, we embark on a meticulous endeavor to construct a robust REST API, meticulously adhering to the tenets of Clean Architecture and Domain-Driven Design (DDD) from inception.
Within this project, we employ the latest advancements, notably .NET 6 and EF Core, to architect our solution with precision. 
We adhere to industry-standard methodologies, incorporating foundational patterns such as :
- CQRS
- Unit of work
- Repository
- Mediator

Context : Developed a "The AirBnB for restaurants" project during free time, focusing on transforming dining rooms into restaurants.
Constructed a system from scratch, adhering to Domain-Driven Design (DDD) principles, beginning with a comprehensive understanding of the domain space through Event Storming and Event Modeling.

-> Utilized ASP.Net 6 REST API as the presentation layer.

-> Established an agnostic data persistence layer to store Aggregates efficiently.

-> Implemented CQRS pattern with MediatR to scale writing and reading jobs independently.

-> Integrated Domain Events and Repository Pattern for efficient Aggregate storage.

-> Employed the Ports And Adapter Architecture (Hexagonal Architecture) principles.

-> Developed a mini testing framework to facilitate Test-Driven Development (TDD) throughout the development process.

-> Technologies utilized include C#, ASP.Net 6, SQL Server, NUnit, Moq, FluentAssertions, and Docker.

-> Established a scalable and robust system architecture that seamlessly integrated various design principles and technologies, facilitating efficient development and maintenance of the project.


| The main goal here is to ensure a codebase that is both scalable and maintainable |

In addition to our architectural choices, we integrated select open-source libraries such as : 
- MediatR
- FluentValidation
- ErrorOr
- Throw
- Mapster and others.

These augment our development experience, elevating our application's capabilities to meet contemporary standards.

Our development environment centers on Rider JetBrains and the dotnet CLI.
Leveraging a suite of meticulously chosen Rider plugins, we streamline our workflow, facilitating tasks ranging from crafting HTTP requests to database interaction, debugging, and token analysis.

Classical TDD : This solution was built in a continuous cycle of coding and refactoring, systematically addressing a spectrum of conceptual nuances. 


  
