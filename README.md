# Bank Management System

The Bank Management System is a C# Windows Forms application designed to manage client accounts, transactions, and user data.
It includes a full front-end interface and a complete back-end implementation. 
The system currently uses file-based data handling with plans for future database integration.

## Table of Contents
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Future Enhancements](#future-enhancements)

## Features
- **Login Screen**: 
  - Authenticate users with username and password.
  - Display different main menus based on user permissions.

- **Manage Clients Screen**: 
  - Add, update, delete, and view a list of clients.
  - Context menu provides navigation to the Transaction Screen for operations like deposit, withdrawal, and transfer.
  
- **Manage Users**: 
  - Add, update, delete, and view a list of users.
  - Manage user permissions and roles within the system.

- **Transactions Screen**: 
  - Handle deposit, withdrawal, and transfer operations.
  - View transaction logs for tracking and auditing purposes.

- **Currency Exchange**: 
  - List all supported currencies.
  - Update exchange rates according to USD.
  - Currency calculator for converting between currencies.

## Technologies Used
- C#
- Windows Forms
- System.IO for file-based data handling
- .NET Framework

# Future Enhancements
- Integration with a SQL-based database for data storage.
- Implementation of additional user roles and permissions.
- Enhanced UI/UX for a more intuitive user experience.
- Addition of comprehensive unit and integration tests.
