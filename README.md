# API de gestión financiera

API en **C# y .NET 8** para operaciones de créditos, personas y configuración de productos financieros.

## Funcionalidad

- Gestión de créditos: registro, consulta, actualización, aprobación, anulación y cancelación.
- Consulta de calendarios de crédito.
- Gestión de personas y parámetros de configuración.
- Documentación interactiva de endpoints con Swagger en desarrollo.

## Tecnologías

ASP.NET Core Web API · SQL Server · Dapper · Swagger / OpenAPI

## Organización

| Proyecto | Responsabilidad |
| --- | --- |
| `ApiFinanciera` | Controladores HTTP y configuración de dependencias |
| `Application` | Servicios y casos de uso |
| `Domain` | Modelos, DTOs y contratos de entrada/salida |
| `Infrastructure` | Repositorios, Dapper y procedimientos almacenados |

La organización utiliza contratos de entrada y salida para separar los servicios de aplicación del acceso a datos.

## Ejecución local

Requisitos: SDK .NET 8 y una instancia de SQL Server con el esquema y los procedimientos almacenados requeridos por los repositorios.

```powershell
git clone https://github.com/APITHEBEST02/FinancieraProyect_Api.git
cd FinancieraProyect_Api
dotnet restore ApiFinanciera.sln
dotnet build ApiFinanciera.sln
```

Configura la conexión mediante la variable de entorno `ConnectionStrings__sqlConnetion` (el nombre corresponde a la clave que lee la aplicación). Usa valores propios de tu entorno y evita incluir credenciales en archivos versionados.

```powershell
dotnet run --project ApiFinanciera/ApiFinanciera.csproj
```

En el entorno Development, abre `/swagger` en la dirección que indique la aplicación.

## Alcance y estado

El código depende de procedimientos almacenados de SQL Server. La compilación por sí sola no prepara una base de datos ni valida un despliegue. Esta documentación describe el código revisado; no certifica su preparación para producción.

## Autor

[Luis Alfredo Ricopa Bardales](https://github.com/APITHEBEST02)
