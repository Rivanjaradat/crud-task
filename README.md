# Task CRUD Project

This project demonstrates basic CRUD (Create, Read, Update, Delete) operations using Entity Framework with a Code First approach. The project involves creating a database with two tables: `Product` and `Order`. It includes operations to add, retrieve, update, and delete records in these tables.

## Project Overview

### Database Schema

- **Product**
  - `Id` (int, primary key)
  - `Name` (string)
  - `Price` (decimal)

- **Order**
  - `Id` (int, primary key)
  - `Address` (string)
  - `CreatedAt` (DateTime)
