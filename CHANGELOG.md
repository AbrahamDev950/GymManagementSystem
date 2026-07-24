# **Sprint 1 - Authentication Foundation**  
### **Goal**  
Build the initial authentication flow and understand the architecture of an ASP.NET Core application.  
### **Features Implemented**  
-  Authentication endpoint (POST /api/authentication/login)   
- Login request and response models  
- Initial authentication flow  
-  API testing using Rider .http files   
- Dependency Injection configuration  
### **New Knowledge**  
- Clean Architecture basics  
- Responsibilities of Domain, Application, Infrastructure, and API layers  
- What a Use Case is and why it exists  
- Dependency Injection fundamentals  
- Controllers and HTTP responses (200, 401)   
- How an HTTP request travels through the application  
### **Architecture**  
HTTP Request  
      │  
      ▼  
AuthenticationController  
      │  
      ▼  
LoginUseCase  
      │  
      ▼  
LoginResponse  
### **Challenges**  
- Understanding why business logic should not be inside controllers.  
- Understanding constructor injection.  
### **Reflection**  
Before this sprint I thought controllers contained most of the application logic. Now I understand that controllers should only receive requests and delegate the work to the appropriate use case.  
# **Sprint 2 - Database Integration**  
### **Goal**  
Replace the hardcoded authentication with a real SQLite database using Entity Framework Core.  
### **Features Implemented**  
- SQLite integration  
- Entity Framework Core configuration  
- GymDbContext  
- Repository Pattern  
- IUserRepository  
- UserRepository  
- Database migrations  
- Database initializer  
- Seed administrator account  
- Async login using the repository  
### **New Knowledge**  
- Entity Framework Core fundamentals  
- DbContext  
- DbSet  
- Repository Pattern  
- LINQ queries  
- Async database operations  
- Migrations  
- Dependency Injection with EF Core  
- Database seeding  
- Connection strings  
### **Architecture**  
HTTP Request  
      │  
      ▼  
AuthenticationController  
      │  
      ▼  
LoginUseCase  
      │  
      ▼  
IUserRepository  
      │  
      ▼  
UserRepository  
      │  
      ▼  
GymDbContext  
      │  
      ▼  
SQLite  
### **Challenges**  
-  Understanding why DbContext should be injected instead of instantiated manually.   
- Understanding how EF translates C# classes into database tables.  
-  Learning async database access with FirstOrDefaultAsync().   
### **Reflection**  
This sprint helped me understand how a web application communicates with a relational database without writing SQL directly. I also learned how responsibilities are separated between the application and infrastructure layers.  
   
