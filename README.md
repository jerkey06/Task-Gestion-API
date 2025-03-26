# TaskGestionAPI - Gestión de Tareas

## 📝 Descripción del Proyecto
TaskGestionAPI es una API RESTful desarrollada con .NET 9 para la gestión de tareas, permitiendo operaciones CRUD (Crear, Leer, Actualizar, Eliminar) de manera eficiente.

## 🚀 Tecnologías Utilizadas
- .NET 9
- ASP.NET Core
- Entity Framework Core
- Swagger/OpenAPI
- In-Memory Database

## ✨ Características
- Crear nuevas tareas
- Listar todas las tareas
- Obtener tarea por ID
- Actualizar tareas existentes
- Eliminar tareas
- Documentación interactiva con Swagger

## 🔧 Requisitos Previos
- .NET 9 SDK
- Visual Studio 2022 o Visual Studio Code

## 📦 Instalación

### Clonar el Repositorio
```bash
git clone https://github.com/jerkey06/TaskGestionAPI.git
cd TaskGestionAPI
```

### Restaurar Dependencias
```bash
dotnet restore
```

### Ejecutar la Aplicación
```bash
dotnet run
```

## 🌐 Endpoints de la API
- `GET /api/Task`: Obtener todas las tareas
- `GET /api/Task/{id}`: Obtener una tarea específica
- `POST /api/Task`: Crear nueva tarea
- `PUT /api/Task/{id}`: Actualizar tarea
- `DELETE /api/Task/{id}`: Eliminar tarea

## 📄 Modelo de Tarea
```csharp
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

## 📊 Acceso a Swagger
Navega a `/swagger` cuando la aplicación esté en ejecución para ver la documentación interactiva de la API.

## 🔒 Próximas Mejoras
- Autenticación de usuarios
- Persistencia en base de datos real
- Validaciones más robustas
- Implementación de logging

## 👨‍💻 Autor
Emiliano(jerkey06)
