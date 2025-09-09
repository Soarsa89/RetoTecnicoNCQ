# Reto técnico - Administador de tareas

Es una aplicación de escritorio para administrar tareas sencillas, con una interfaz de usuario optimizada y validación de datos.

## Características principales

- Crear, editar y eliminar tareas.
- Definir estado de la tarea (Pendiente, En Proceso, Completada).
- Persistencia de datos con Entity Framework Core y SQLite.
- Patrón MVVM aplicado en Windows Forms con .NET 8.
- Validaciones en formularios para garantizar integridad de datos.
- Interfaz construida con DevExpress para una mejor experiencia de usuario.

## Entorno de Desarrollo

- SDK .Net8
- Visual Studio 2022
- DevExpress
- EtintyFramework
- SQlite
- CommunityToolkit.Mvvm

## Ejecutar El proyecto

- Clonar el repositorio : '<https://github.com/Soarsa89/RetoTecnicoNCQ.git>'
- ir a : cd RetoTecnicoNCQ/AdminTareas
- Ejecutar: dotnet add package Microsoft.EntityFrameworkCore.Design --version 9.0.8
- Retornar a la raiz del proyecto:  cd ..
- Ejecutar migraciones para crear la Base de datos y en  caso de que no este cargado los estados y la prioridad de las tareas 
  - dotnet ef database update --project "AdminTareas.Datos\AdminTareas.Datos.csproj" --startup-project "AdminTareas\AdminTareas.csproj"
- Ejecutar proyecto : dotnet run --project AdminTareas

## Decisiones técnicas

- Se implemtento WinForms con MVVM para separa lo que es la vista  con la logica de negocio, donde  se
  utiliza ViewModel.
- Se dividio en librerias(Dll) para temer mas separacion entre las capas y que cada una de ellas tuviera cierta independecia.
- Se utilizo Entity Framework  como ORM por la facilidad de mapear los datos entre la base de Datos y  las clases.
- Se utilizo SQLite  porque se integra dentro del mismo proyecto y es facil impmentar sin instalar algun otro motor de base de datos mas complejo.
- Se utilizo patron de diseño repository para mantener la conexion ocn los datos libre de  los view Model y la vista esten recargados con esto.
- Se utilizo DevExpress por la potencia en las funcionalidad y en la experiencia de Usuario.

## Guía de estilo de código

### 1. Nomenclatura

- Clases : PascalCase
- Metodos : PascalCase
- Variables privada : camelCase con guion bajo
- Organizacion de Archivos en Dll y carpetas(Arquitectura )
