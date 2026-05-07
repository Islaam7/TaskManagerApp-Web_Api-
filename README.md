# 📋 TaskManagerApp - ASP.NET Core Web API

A secure and scalable **Task Management RESTful API** built using **ASP.NET Core Web API**, **Entity Framework Core**, **SQL**, and **JWT Authentication**.

This project allows users to register, authenticate, and manage their personal tasks securely through a clean RESTful API architecture.

---

# 🚀 Features

## 🔐 Authentication & Authorization

* User Registration
* User Login
* JWT Token Authentication
* Protected API Endpoints
* Secure Password Hashing

## ✅ Task Management

* Create Tasks
* Retrieve All User Tasks
* Get Task By ID
* Update Tasks
* Delete Tasks
* Mark Tasks as Completed/Pending
* Filter Tasks by:

  * Status
  * Category

---

# 🛠️ Technologies Used

* ASP.NET Core Web API
* Entity Framework Core
* SQLite Database
* JWT Bearer Authentication
* RESTful API Design
* Scalar / OpenAPI

---

# 📂 Project Structure

```bash
TaskManagerApp/
│
├── Controllers/
├── Models/
├── DTOs/
├── Data/
├── Migrations/
├── Program.cs
└── appsettings.json
```

---

# ⚙️ Installation & Setup

## 1️⃣ Clone the Repository

```bash
git clone https://github.com/your-username/TaskManagerApp.git
```

## 2️⃣ Navigate to the Project

```bash
cd TaskManagerApp
```

## 3️⃣ Restore Packages

```bash
dotnet restore
```

## 4️⃣ Apply Database Migrations

```bash
dotnet ef database update
```

## 5️⃣ Run the Application

```bash
dotnet run
```

---

# 🔑 Authentication

After logging in successfully, the API returns a JWT token.

Use the token in the Authorization header:

```http
Authorization: Bearer YOUR_TOKEN
```

---

# 📌 API Endpoints

## 👤 Authentication

| Method | Endpoint           | Description       |
| ------ | ------------------ | ----------------- |
| POST   | /api/auth/register | Register new user |
| POST   | /api/auth/login    | Login user        |

---

## 📝 Tasks

| Method | Endpoint        | Description     |
| ------ | --------------- | --------------- |
| GET    | /api/tasks      | Get all tasks   |
| GET    | /api/tasks/{id} | Get task by ID  |
| POST   | /api/tasks      | Create new task |
| PUT    | /api/tasks/{id} | Update task     |
| DELETE | /api/tasks/{id} | Delete task     |

---

# 🧪 Example Task JSON

```json
{
  "title": "Learn ASP.NET Core",
  "description": "Build a Web API project",
  "category": "Work",
  "status": "Pending"
}
```

---

# 📖 Learning Objectives

This project helps in understanding:

* RESTful API Development
* JWT Authentication
* ASP.NET Core Middleware
* Entity Framework Core
* Database Migrations
* CRUD Operations
* API Security Best Practices

---

# 🤝 Contributing

Contributions are welcome!

Feel free to fork the repository and submit a pull request.

---

# 📄 License

This project is licensed under the MIT License.

---

# 👨‍💻 Author

Developed by Islam Fares
