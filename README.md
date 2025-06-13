# FileTracking System

A full-stack file tracking and notification system built with **.NET 8**, **MediatR (CQRS)**, **EF Core**, and **React**. The system enables users to upload, manage, and receive alerts for files that are about to expire.

---

## 🌎 Features

* User login, registration, and role-based authorization (Admin/User)
* File upload with expiry date (using `IFormFile`)
* File listing, update, delete, and download
* Background service to check file expiry dates
* Email notifications (SMTP) for expiring files
* SMS alert simulation (console log)
* API response for upcoming file expirations
* User actions: extend validity, suppress warning, snooze alert
* React-based front-end panel

---

## 💡 Technologies

### Backend (ASP.NET Core)

* .NET 8
* MediatR (Command/Query Separation)
* Entity Framework Core (InMemoryDb)
* FluentValidation
* MailKit (SMTP)
* Identity + JWT Auth
* BackgroundService
* Clean Architecture principles

### Frontend

* React (Vite)
* Axios for API requests
* Protected routes based on roles
* File upload form with expiry selection
* Alert & toast notifications

---

## 🔧 System Architecture

```plaintext
API
├── Controllers
│   ├── FileController.cs
│   └── AuthController.cs
├── Program.cs

Application
├── Features
│   ├── Files
│   │   ├── Commands
│   │   │   └── Create, Upload, Delete, Update, Extend, Suppress, Snooze
│   │   ├── Queries
│   │   │   └── GetById, GetExpiringFiles
│   └── Auth
├── Notification
│   └── ExpiringFileNotificationHandler_Email, Sms

Domain
├── Entities
│   └── FileRecord, ApplicationUser
├── Interfaces
│   └── IFileRepository, IFileStorageService, IEmailService

Infrastructure
├── Repositories
├── Services
├── Data (DbContext)
```

---

## 🔄 API Endpoints (Summary)

| Method | Route                                   | Description                    |
| ------ | --------------------------------------- | ------------------------------ |
| POST   | `/api/auth/register`                    | Register a new user            |
| POST   | `/api/auth/login`                       | Authenticate and receive token |
| POST   | `/api/file/upload`                      | Upload a new file              |
| GET    | `/api/file/{id}`                        | Get file details               |
| PUT    | `/api/file/{id}`                        | Update file info               |
| DELETE | `/api/file/{id}`                        | Delete file                    |
| GET    | `/api/file/download/{id}`               | Download file                  |
| GET    | `/api/files/expiring`                   | List expiring files for user   |
| PUT    | `/api/files/extend-validity/{id}`       | Extend file expiration         |
| PUT    | `/api/files/suppress-warning/{id}`      | Disable future warnings        |
| PUT    | `/api/files/snooze-warning/{id}?days=X` | Snooze alert for X days        |

---

## 🎨 Frontend Screens

* Login page with JWT auth
* User dashboard (upload / manage own files)
* Admin dashboard (see/delete all files)
* Toast notifications for feedback
* Conditional rendering for roles

---

## 🌟 How to Run

### Backend

```bash
cd FileTracking.API
 dotnet restore
 dotnet build
 dotnet run
```

### Frontend

```bash
cd filetracking-react
npm install
npm run dev
```

> Note: Backend must be running for frontend to fetch files and auth.

---

## 🛠️ Future Improvements

* Cloud storage integration (e.g., Azure Blob)
* PDF preview support
* MongoDB or SQL Server backend
* Real SMS provider (e.g., Twilio)
* Admin analytics panel

---

## 🌟 Author

Developed by Kaan (Software Engineer / .NET & React Developer)

---

## ✅ License

MIT
# FileTracking
