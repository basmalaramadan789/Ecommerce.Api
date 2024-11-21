E-Commerce API
Overview
This is a RESTful API for an e-commerce platform built using .NET Core 8. The application follows an N-Tier Architecture design pattern and uses a Generic Repository pattern for maintainable and scalable data access. It also integrates Stripe Payment Gateway for secure and seamless transactions.

Features
User Management
User registration and login with secure password hashing.
Role-based authorization (Admin, Customer).
JWT-based authentication with refresh token support.
Product Management
Add, update, delete, and view products.
Pagination, filtering, and sorting for product listings.
Order Management
Place, view, update, and cancel orders.
Manage order details and track statuses.
Cart Management
Add, update, and remove items in the cart.
View the current cart.
Category Management
Add, update, delete, and view categories.
Payment Integration
Stripe Payment Gateway: Secure online payments.
Technologies Used
.NET Core 8: Framework for building the API.
Entity Framework Core: ORM for database operations.
JWT: Authentication and authorization.
SQL Server: Database for storing application data.
Stripe API: Payment gateway integration.
N-Tier Architecture: Modular design with separation of concerns.
Generic Repository Pattern: Abstraction for common CRUD operations.
Specific Repository Pattern: Custom data access methods for specific use cases.
Swagger/OpenAPI: API documentation and testing.
Architecture
The project is designed using N-Tier Architecture for better scalability and maintainability:

Presentation Layer: Responsible for API endpoints and request handling.
Business Logic Layer: Contains service classes for implementing business rules.
Data Access Layer: Includes repositories (Generic and Specific) for interacting with the database.
Database Layer: Stores the application data.
