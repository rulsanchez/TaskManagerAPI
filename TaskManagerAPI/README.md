# TaskManagerAPI

TaskManagerAPI es una API REST desarrollada con **.NET 8**, **ASP.NET Core**, **Entity Framework Core** y **JWT**, que permite a usuarios autenticados gestionar tareas personales. Está pensada como parte de un portfolio técnico.

---
   
## Tecnologías utilizadas

* .NET 8 (ASP.NET Core Web API)
* Entity Framework Core
* SQL Server Express
* ASP.NET Core Identity
* JWT (Json Web Token)
* Swagger (OpenAPI)

---

## Características implementadas

* Registro de usuarios (con Identity)
* Inicio de sesión con generación de JWT
* Autenticación y autorización con tokens JWT
* CRUD de tareas asociado al usuario autenticado
* Swagger configurado para enviar el token JWT
* Uso de buenas prácticas: DTOs, servicios, configuración segura

---

##  Requisitos para ejecutar el proyecto

* Visual Studio 2022 o superior
* .NET 8 SDK
* SQL Server Express o localdb (configurable)

---

##  Configuración local

1. Clona el repositorio:

```bash
git clone https://github.com/rulsanchez/TaskManagerAPI.git
```

2. Crea un archivo `appsettings.Development.json` en la raíz del proyecto con este contenido:

```json
{
  "JwtSettings": {
    "SecretKey": "ClaveSuperMegaSecreta1234567890_AZ!@#456",
    "Issuer": "TaskManagerAPI",
    "Audience": "TaskManagerAPIUser",
    "ExpiryMinutes": 60
  }
}
```

> Nota: Este archivo está excluido del repositorio por seguridad y deberás crearlo localmente.

3. Asegúrate de tener acceso a una instancia SQL Server y configura tu cadena de conexión en `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=TU_SERVIDOR_SQL;Database=TaskManagerDb;Trusted_Connection=True;TrustServerCertificate=True"
}
```

4. Ejecuta las migraciones:

```bash
dotnet ef database update
```

5. Ejecuta la aplicación (`Ctrl + F5` o `dotnet run`) y abre Swagger en `https://localhost:xxxx/swagger`

---

## Endpoints disponibles

### Autenticación

* `POST /api/auth/register` → Registro de usuario
* `POST /api/auth/login` → Inicio de sesión, devuelve JWT

### Tareas (requiere token)

* `GET /api/tasks` → Lista de tareas del usuario
* `POST /api/tasks` → Crear tarea
* `PUT /api/tasks/{id}` → Editar tarea
* `DELETE /api/tasks/{id}` → Eliminar tarea

---

##  Autenticación en Swagger

1. Llama a `/api/auth/login` y copia el token JWT devuelto
2. Haz clic en el botón **Authorize** en Swagger
3. Escribe:

```
Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6...
```

4. Ahora podrás usar los endpoints protegidos

---

##  Objetivo del proyecto

Este proyecto fue desarrollado como ejercicio completo de un backend realista en .NET 8:

* Conocimiento de autenticación moderna (JWT)
* Integración de ASP.NET Core Identity con EF Core
* Estructura profesional basada en servicios y DTOs
* Prácticas seguras al gestionar configuraciones sensibles

---

##  Licencia

Este proyecto es de uso personal/educativo. No contiene datos reales ni se usa en entornos de producción.

---

*Desarrollado por [rulsanchez](https://github.com/rulsanchez)*
> Proyecto de ejemplo en .NET 8 - Portfolio técnico
