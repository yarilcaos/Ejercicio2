
# Ejercicio 2

Requisitos:  

Crear API en C# para realizar las siguientes operaciones: 

Create – mediante entity framework. 

Read by Id – mediante entity framework. 

Update – mediante stored procedure. 

Delete – mediante stored procedure. 

Nota: Deseable .net core 3.1/.net 6/.net 8, Repository Pattern, Generics, mediatr, Dependency Injection. 

Creado el controlador:

UsersController

Estructura del Proyecto
Models: Contiene las entidades del proyecto.

Data: Configuración del AppDbContext.

Repositories: Implementación del patrón repositorio con genéricos.

Controllers: Controlador UsersController para manejar las operaciones de usuario.

CQRS: Comandos y consultas utilizando MediatR para el manejo de la lógica de negocio.

Funcionalidades de la API

Create
Descripción: Crea un nuevo usuario en la base de datos mediante Entity Framework.

Endpoint: POST /api/users
Read by Id
Descripción: Obtiene un usuario por su ID utilizando Entity Framework.

Endpoint: GET /api/users/{id}
Update
Descripción: Actualiza un usuario existente mediante un 

procedimiento almacenado.
Endpoint: PUT /api/users/{id}
Delete

Descripción: Elimina un usuario existente utilizando un procedimiento almacenado.
Endpoint: DELETE /api/users/{id}

Tecnologías Utilizadas
.NET 6: Plataforma principal para el desarrollo.

Entity Framework Core: ORM para la gestión de datos.

SQL Server: Base de datos para el almacenamiento de la información.

MediatR: Implementación de patrones CQRS para separar la lógica de comandos y consultas.

Inyección de Dependencias: Para la gestión y configuración de servicios.