# ApiHotelProject

ApiHotelProject is a comprehensive hotel management system developed using ASP.NET Core API, MS SQL Server, Rapid API, and API Consume. It provides a seamless experience for both hotel administrators and guests, offering features such as user authentication, booking management, and integration with external APIs.

## Solution Structure

The project is structured as follows:

- **ApiConsume**: Contains the backend of the application.

  - **Entity Layer**: Contains the entity models representing the core domain objects of the application, such as User, Booking, Room, Staff, Testimonial, Service, and more. These models define the structure of the data and the relationships between different entities.
  - **Data Access Layer**: Handles database operations using Entity Framework Core. Defines repositories and data access services responsible for querying and manipulating data in the database. Uses DbContext to interact with the underlying database.
  - **DTO Layer**: Contains Data Transfer Objects (DTOs) used for communication between different layers of the application. DTOs are lightweight objects that carry data between the frontend and backend, helping to minimize data transfer overhead.
  - **Business Layer**: Implements the business logic and services of the application. Contains service classes responsible for orchestrating business operations, such as user authentication, booking management, and external API integration. Encapsulates complex business rules and workflows to maintain a clean separation of concerns.
  - **Web API**: Hosts the ASP.NET Core API, which serves as the backend of the application. Defines RESTful endpoints for performing CRUD operations on various resources, such as users, bookings, rooms, and services. Utilizes controllers to handle incoming HTTP requests and generate appropriate responses.

- **Frontend**: Contains the frontend of the application.

  - **Web UI**: Implements the frontend web application using ASP.NET MVC. Consists of two main parts: "Admin" and "Default." The "Admin" part is responsible for managing the core functionalities of the system, including user management, booking management, and service management. The "Default" part provides a user-friendly interface for guests to browse hotel information, make bookings, and view testimonials.

- **JwtProject**: An external project for learning JSON Web Tokens (JWT).

- **RapidApi**: An external project for experimenting with Rapid API.

## Database Tables

The application interacts with the following tables in the database:

- **Users**: Stores information about registered users, including their username, email, password hash, and role.
- **Bookings**: Records details of hotel bookings made by guests, including the booking ID, guest ID, room ID, check-in date, check-out date, and status.
- **Rooms**: Contains information about available rooms in the hotel, such as room number, room type, price, and availability status.
- **Staff**: Stores data about hotel staff members, including their name, position, contact information, and role.
- **Testimonials**: Stores testimonials submitted by guests, including the guest's name, message, and rating.
- **Services**: Contains details of services offered by the hotel, such as service name, description, and price.

## Technologies Used

- **ASP.NET Core API**: For building the backend API.
- **MS SQL Server**: As the database management system.
- **Rapid API**: Utilized for accessing external services like hotel booking and exchange rate APIs.
- **API Consume**: Consumes the APIs provided by Rapid API.
- **ASP.NET Identity**: Used for user authentication and authorization.
- **Swagger**: Provides API documentation.
- **Postman**: Used for API testing and monitoring.
- **Fluent Validation**: For input validation.
- **AutoMapper**: Handles object-to-object mapping.
- **ASP.NET MVC**: For building the frontend web application.
- **Entity Framework Core**: For database access and operations.
- **Repository Design Pattern**: Organizes data access logic.
- **SMTP**: Used for sending emails.
- **File Upload**: Supports uploading photos and files.
- **View Component**: Used for rendering reusable UI components.

## Development Notes

- JWT is used as user authentication and authorization
- The project follows a layered architecture (NTier Architecture) for better organization and separation of concerns.
- DTO Layer is used for transferring data between layers to avoid tight coupling.
- The backend is developed using ASP.NET Core API, providing a robust and scalable architecture.
- Fluent Validation ensures that input data is validated before processing.
- AutoMapper simplifies the mapping between DTOs and entity models.
- View Component is used for rendering reusable UI components, improving code maintainability.


