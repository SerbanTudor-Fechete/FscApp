# Fun Shooting Center Web App
A full-stack web application designed as an informational website to showcase details about simulation shooter. The app offers an engaging and interactive platform where users can explore information, reserve sessions, submit questions, and provide feedback.

## Table of Contents
- [Features](#features)
- [Tech Stack](#tech-stack)
- [Project Structure](#project-structure)
- [Prerequisites](#prerequisites)
- [Installation & Setup](#installation-and-setup)
- [Screenshots](#screenshots)


## Features

- **Multi-page User Interface:**  
  Built with ASP.NET Core Blazor, the app features a responsive navigation bar, footer, and multiple content pages for seamless navigation.

- **Dynamic Carousel Integration:**  
  Utilizes the Syncfusion package for a responsive and visually appealing image carousel to showcase the shooting center's offerings.

- **Interactive Forms:**  
  - **Reservation Form:** Allows users to book shooting sessions.  
  - **Question Submission Form:** Enables users to ask questions.  
  - **Feedback Form:** Collects user feedback for continuous improvement.

- **Backend Services:**  
  - Built with ASP.NET Class Library and Entity Framework Core for efficient database schema management.  
  - SQL Server for robust and scalable database management.

## Tech Stack

### Frontend:
- ASP.NET Core Blazor for an interactive web UI.  
- HTML, CSS, and Bootstrap for responsive design.  
- Syncfusion package for dynamic carousel integration.

### Backend:
- ASP.NET Class Library for business logic and data access.  
- Entity Framework Core for database migrations and ORM.  
- SQL Server for database storage and management.

## Project Structure

The project is organized into two main folders: `FscAppLibrary` (backend) and `FscAppUi` (frontend).

### Backend (`FscAppLibrary`)
- **DataAccess/**  
  Contains the database context (`DbContext`) for managing database connections.  
- **Migrations/**  
  Auto-generated migration files by EF Core for database schema updates.  
- **Models/**  
  Defines models for entities such as reservations, questions, and feedback.  
- **Services/**  
  Contains services for handling database operations.

### Frontend (`FscAppUi`)
- **Pages/NavBarPages/**  
  Contains all pages linked from the navigation bar.  
- **Shared/**  
  Includes shared components like the `NavBar`, `Footer`, and `MainLayout`.


## Prerequisites
- **Visual Studio 2022** (with ASP.NET and web development workload installed)
- **.NET 7.0 SDK** (or compatible version)
- **SQL Server** (LocalDB or a full instance)
- **Git** (for cloning the repository)

## Installation and Setup

### Cloning the Repository
1. Open a terminal or command prompt.
2. Clone the repository:
   ```bash
   git clone https://github.com/SerbanTudor-Fechete/FscApp.git
   ```

### Setting Up with Visual Studio (ASP.NET Core Blazor)

1. **Open the Project**:
   - Launch Visual Studio 2022.
   - Go to `File > Open > Project/Solution`.
   - Select `FscAppUi.sln` from the cloned repository folder.

2. **Restore Dependencies**:
   - Visual Studio will automatically restore NuGet packages. If it doesn’t, right-click the solution in Solution Explorer and choose `Restore NuGet Packages`.

3. **Configure SQL Server**:
   - Ensure SQL Server (e.g., LocalDB) is installed and running.
   - Update the connection string in `FscAppUi/appsettings.json` to match your SQL Server instance:
     ```json
     {
       "ConnectionStrings": {
         "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=FscDb;Trusted_Connection=True;MultipleActiveResultSets=true"
       }
     }
     ```

4. **Apply Database Migrations**:
   - Open the Package Manager Console: `Tools > NuGet Package Manager > Package Manager Console`.
   - Set the default project to `FscAppLibrary`.
   - Run:
     ```powershell
     Update-Database
     ```

5. **Register Syncfusion License**:
   - Add the following line in the `RegisterServices.cs` file:
     ```csharp
     Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR_LICENSE_KEY_HERE");
     
## Screenshots 

![Screenshot 2025-03-20 183645](https://github.com/user-attachments/assets/3564dc5b-3ea1-42e7-8846-63143b9bc2b9)


![Screenshot 2025-03-20 183707](https://github.com/user-attachments/assets/9169db07-cbef-49f7-9c83-c161da4fc57a)


![Screenshot 2025-03-20 183726](https://github.com/user-attachments/assets/4849a30b-d27e-423d-a25f-c3a191575953)


![Screenshot 2025-03-20 183759](https://github.com/user-attachments/assets/4166e502-795b-405d-bf12-eea5a22031d6)


