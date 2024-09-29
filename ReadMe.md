
# Mock Ticket Handle

## Project Description
**Mock Ticket Handle** is a .NET-based project designed to manage ticketing systems through a modular architecture that separates concerns between the business logic and the API layer. The project provides a scalable and structured approach to handling tasks related to ticket management, allowing easy integration with third-party systems and handling various message-based operations through RabbitMQ.

The solution consists of multiple sub-projects, each focusing on a different aspect of the ticket handling process. This includes business logic, API services, and model definitions.

## Features
- **Business Logic Layer:** Contains core business functionalities and model definitions, including RabbitMQ options for message handling.
- **Web API Layer:** A RESTful API that exposes endpoints for external systems or clients to interact with the ticketing system.
- **Message-based Communication:** Supports RabbitMQ for messaging and task queuing, enabling scalable and decoupled processes.

## Project Structure

```
Mock.Ticket.Handle/
│
├── Business/
│   ├── Models/                  # Contains data models such as RabbitMQ options
│   ├── ServiceRegistration.cs    # Dependency injection and service configurations
│   └── Business.csproj           # Project file for the business layer
│
├── Web.API/
│   ├── Controllers/              # API controllers that expose ticketing endpoints
│   ├── Properties/               # API project settings
│   └── Web.API.csproj            # Project file for the API layer
│
└── Mock.Ticket.Handle.sln        # Solution file
```

## Technologies Used
- **.NET Core 8.0** - The core framework used for building both the business layer and Web API.
- **RabbitMQ** - For message-based communication, facilitating asynchronous processing.
- **Entity Framework** (Optional) - Can be used if there's a database integration for ticket storage.
- **RESTful API** - Provides a standard interface for clients to interact with the system.

## Prerequisites
- **.NET 8.0 SDK** - Ensure you have the latest .NET SDK installed to build and run the project.
- **RabbitMQ** - You should have RabbitMQ installed and running if you want to leverage message-based communication.

## Installation

1. **Clone the repository:**
   ```bash
   git clone https://github.com/yourusername/Mock.Ticket.Handle.git
   ```

2. **Navigate to the project directory:**
   ```bash
   cd Mock.Ticket.Handle
   ```

3. **Restore the dependencies:**
   ```bash
   dotnet restore
   ```

4. **Configure RabbitMQ (Optional but recommended):**
   - Update the `RabbitMQOptions.cs` file in the `Business/Models/` folder with your RabbitMQ connection settings.
   - Ensure RabbitMQ is running on your machine or server.

## Running the Application

### Business Logic Layer
1. **Build the Business project:**
   ```bash
   cd Business
   dotnet build
   ```

2. **Run the Business logic if necessary:**
   ```bash
   dotnet run
   ```

### API Layer
1. **Navigate to the API project directory:**
   ```bash
   cd Web.API
   ```

2. **Run the Web API:**
   ```bash
   dotnet run
   ```

3. **Access the API:**
   Once the API is running, access it at `http://localhost:5000`. You can interact with the API using tools like Postman or cURL.

## API Endpoints
Here are some example API endpoints you can interact with:

- **GET /tickets** - Retrieves a list of all tickets.
- **POST /tickets** - Creates a new ticket.
- **PUT /tickets/{id}** - Updates an existing ticket by ID.
- **DELETE /tickets/{id}** - Deletes a ticket by ID.

## Configuration
- **RabbitMQ Configuration:** The RabbitMQ connection settings are defined in the `Business/Models/RabbitMQOptions.cs` file. You can adjust these settings to point to your RabbitMQ server.

- **API Configuration:** You can modify API settings in the `Web.API/Properties/launchSettings.json` file to customize the launch URL, ports, and environment configurations.

## Testing
- Unit tests for the business logic and API can be added to ensure the correctness of the ticket handling processes.
- Integration tests can be written to test the interaction between the business logic and the API.

## Future Improvements
- **Database Integration:** Integrate a database like SQL Server or PostgreSQL using Entity Framework to store tickets persistently.
- **Enhanced Security:** Implement authentication and authorization mechanisms for secure access to API endpoints.
- **Logging:** Add structured logging using tools like Serilog for better monitoring and debugging.

## License
This project is licensed under the MIT License.
