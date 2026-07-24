**Sprint 1 - Authentication Foundation**  
**Goal**  
Build the initial authentication flow and understand the architecture of an ASP.NET Core application.  
**Features Implemented**  
- Authentication endpoint (POST /api/authentication/login)  
- Login request and response models  
- Initial authentication flow  
- API testing using Rider .http files  
- Dependency Injection configuration  
**New Knowledge**  
- Clean Architecture basics  
- Responsibilities of Domain, Application, Infrastructure, and API layers  
- What a Use Case is and why it exists  
- Dependency Injection fundamentals  
- Controllers and HTTP responses (200, 401)  
- How an HTTP request travels through the application  
**Architecture**  
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
**Challenges**  
- Understanding why business logic should not be inside controllers.  
- Understanding constructor injection.  
**Reflection**  
Before this sprint I thought controllers contained most of the application logic. Now I understand that controllers should only receive requests and delegate the work to the appropriate use case.  
**Sprint 2 - Database Integration**  
**Goal**  
Replace the hardcoded authentication with a real SQLite database using Entity Framework Core.  
**Features Implemented**  
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
**New Knowledge**  
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
**Architecture**  
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
**Challenges**  
- Understanding why DbContext should be injected instead of instantiated manually.  
- Understanding how EF translates C# classes into database tables.  
- Learning async database access with FirstOrDefaultAsync().  
**Reflection**  
This sprint helped me understand how a web application communicates with a relational database without writing SQL directly. I also learned how responsibilities are separated between the application and infrastructure layers.  
   
  **Sprint 2.5 – Frontend Login Integration**  
**Goal**  
Connect a simple web interface to the authentication API.  
**Features Implemented**  
- Login page  
- Fetch API integration  
- Dashboard placeholder  
- Error handling  
- CORS configuration  
**New Knowledge**  
- Browser-server communication  
- Fetch API  
- JSON serialization  
- CORS  
- DOM manipulation  
- Form event handling  
**Architecture**  
Browser  
↓  
Fetch  
↓  
ASP.NET Core API  
↓  
Application Layer  
↓  
Infrastructure  
↓  
SQLite  
↓  
JSON Response  
↓  
Dashboard  
**Challenges**  
- Understanding how the frontend sends data to the backend using HTTP and JSON.  
- Separating the responsibilities of reading the form, calling the API, and updating the interface.  
- Learning the difference between a network error and an authentication error such as `401 Unauthorized`.  
- Understanding why the browser blocks requests between different origins and how CORS solves this problem.  
- Running the frontend through a local web server instead of opening the HTML file directly.  
**Reflection**  
This sprint helped me understand how the frontend and backend communicate as parts of the same application. I learned how data entered in an HTML form is converted into JSON, sent through an HTTP request, processed by the ASP.NET Core API, and returned to the browser as a response.  
I also understood that a successful backend is not enough by itself: the browser introduces additional concerns such as CORS, origins, network errors, and DOM updates.   
For the first time, I connected HTML, CSS, JavaScript, ASP.NET Core, Entity Framework Core, and SQLite in a complete full-stack flow.  
