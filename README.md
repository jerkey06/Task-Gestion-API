# TaskGestionAPI - Task Management API

## Project Overview

TaskGestionAPI is a **RESTful API** built with **.NET 9** designed for efficient **CRUD (Create, Read, Update, Delete)** operations for task management.

## Technologies Used

- **.NET 9**
- **ASP.NET Core**
- **Entity Framework Core**
- **Swagger/OpenAPI**
- **In-Memory Database**

## Key Features

- Creation of new tasks
- Retrieval of all tasks
- Task retrieval by ID
- Updating existing tasks
- Deletion of tasks
- Interactive API documentation via Swagger

## Prerequisites

- **.NET 9 SDK**
- **Visual Studio 2022 or Visual Studio Code**

## Installation

### Cloning the Repository

Bash

```
git clone https://github.com/jerkey06/Task-Gestion-API.git
cd TaskGestionAPI
```

### Restoring Dependencies

Bash

```
dotnet restore
```

### Running the Application

Bash

```
dotnet run
```

## API Endpoints

- `GET /api/Task`: Retrieves all tasks
- `GET /api/Task/{id}`: Retrieves a specific task by its ID
- `POST /api/Task`: Creates a new task
- `PUT /api/Task/{id}`: Updates an existing task
- `DELETE /api/Task/{id}`: Deletes a task

## Task Model

C#

```
public class Task
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime? ExpirationDate { get; set; }
    public string Priority { get; set; }
    public string Status { get; set; }
}
```

## Swagger Access

Once the application is running, navigate to `/swagger` in your web browser to access the interactive API documentation.

## Future Enhancements

- User authentication
- Transition to a persistent database
- Implementation of more robust validations
- Integration of logging capabilities
