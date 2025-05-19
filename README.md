# GuestbookApp

Una aplicación web simple desarrollada con **ASP.NET Core** que permite a los usuarios dejar su nombre y un mensaje en un libro de visitas. Este proyecto fue realizado como parte del curso **"Comprender los aspectos básicos de ASP.NET Core"** de Microsoft.

## 🧾 Características

- ✅ Página de bienvenida con mensaje desde un servicio (`IWelcomeService`)
- ✅ Formulario para registrar nombre y comentario
- ✅ Listado de entradas almacenadas (en memoria o en un archivo JSON)
- ✅ Separación por capas: servicios, modelos y controladores

## 🚀 Tecnologías utilizadas

- ASP.NET Core MVC
- C#
- Razor Pages
- Inyección de dependencias
- JSON (para almacenamiento de datos)

## 📂 Estructura del proyecto

```bash
GuestbookApp/
├── Controllers/
│   └── GuestbookController.cs
├── Models/
│   └── GuestbookEntry.cs
├── Services/
│   ├── IWelcomeService.cs
│   └── WelcomeService.cs
├── Views/
│   ├── Home/
│   ├── Guestbook/
│   └── Shared/
├── wwwroot/
├── appsettings.json
└── Program.cs
```
## 🧪 Cómo ejecutar el proyecto
- Clona este repositorio:
```bash
git clone https://github.com/jhordanmallma/GuestbookApp.git
```
- Abre la carpeta en Visual Studio o Visual Studio Code.
- Ejecuta el proyecto:
```bash
dotnet run
```
- Abre tu navegador y ve a:

```bash
https://localhost:5001/
```

## 💬 Autor
Jhordan Mallma
Desarrollador en formación | Proyecto del curso Microsoft


