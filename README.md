# Airline Management System

The **Airline Management System** is a robust application designed to manage airline operations efficiently. The system supports two primary roles: **Passengers** and **Admins**. Each role has specific functionalities to ensure smooth operation and management.

## Features

### **Passenger Features**
- **Register Account**: Passengers can create an account to access the system.
- **View Flights**: Browse available flights with details such as destination, timing, and price.
- **Book Tickets**: Request and confirm ticket bookings for available flights.
- **Cancel Tickets**: Cancel previously booked tickets.
- **View Booking Details**: Check the details of current and past bookings.

### **Admin Features**
- **Manage Passengers**:
- ![Screenshot (420)](https://github.com/user-attachments/assets/a425f023-78de-41bf-8383-e405415f215b) 
  - Add new passengers.
  - Remove existing passengers.
  - Update passenger details.
- **Manage Flights**:
  - Add new flights.
  - Remove flights.
  - Update flight details.
- **Manage Tickets**:
- ![Screenshot (429)](https://github.com/user-attachments/assets/883af86b-7931-43cd-96b3-1d39c46a228f)
  - View all ticket bookings.
  - Clear canceled tickets.
- **View System Data**:
  - View all registered passengers.
  - View flight schedules and details.
  - View bookings and cancellations.

## Technologies Used
- **Programming Language**: C#
- **Database**: MongoDB

## Installation and Setup

### **Prerequisites**
1. Install [.NET SDK](https://dotnet.microsoft.com/download).
2. Install MongoDB and ensure it is running.
3. Install a MongoDB GUI tool like [Compass](https://www.mongodb.com/products/compass) (optional).

### **Steps to Run**
1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/airline-management-system.git
   cd airline-management-system
   ```
2. Configure the MongoDB connection string in the `appsettings.json` file:
   ```json
   {
       "ConnectionStrings": {
           "MongoDb": "mongodb://localhost:27017/airlineDB"
       }
   }
   ```
3. Build and run the project:
   ```bash
   dotnet build
   dotnet run
   ```

## Usage

### **Passenger Login**
![Screenshot (425)](https://github.com/user-attachments/assets/c93ed991-6388-4dc6-b7d7-ce0c473fcbe3)
- Passengers can register and log in to their accounts.
- Access features like viewing flights, booking tickets, and managing their bookings.

### **Admin Login**
![Screenshot (428)](https://github.com/user-attachments/assets/7fc36f4e-be05-4a8e-9e31-c70069e18b67)
- Admins can log in to manage passengers, flights, and tickets.
- Access detailed reports on flights, passengers, and cancellations.

## Project Structure
- **Controllers**: Handles user input and sends it to the appropriate services.
- **Services**: Contains business logic.
- **Models**: Defines data structures for passengers, flights, tickets, etc.
- **Database**: Handles interactions with MongoDB.

## Contributing
Contributions are welcome! Please follow these steps:
1. Fork the repository.
2. Create a feature branch: `git checkout -b feature-name`.
3. Commit your changes: `git commit -m "Add some feature"`.
4. Push to the branch: `git push origin feature-name`.
5. Open a pull request.

## License
This project is licensed under the [MIT License](LICENSE).

## Contact
For any queries or suggestions, feel free to contact:
- **Email**: [sktfscm21557034l@gmail.com](mailto:sktfscm21557034@gmail.com)
- **GitHub**: [mohAhmadRaza](https://github.com/mohAhmadRaza)
