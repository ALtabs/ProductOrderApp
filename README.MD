# Product Order Web Application

This is a simple .NET 8 web application that displays products from a `products.json` file and orders from an `orders.json` file. It includes two views:

1. **Store**: Displays a list of all products.
2. **My Orders**: Displays a list of all orders with their respective IDs and net prices.


## Features

- List all products from `products.json`.
- List all orders from `orders.json` with total net price per order.
- Create a navbar for navigation.


## Prerequisites

- .NET 8 SDK installed. You can download it from [here](https://dotnet.microsoft.com/download).
- preferred IDE


## Setup Instructions

Follow these steps to set up the project on your local machine.

### 1. Clone the Repository

First, clone the repository to your local machine.

```bash
git clone https://github.com/ALtabs/ProductOrderApp.git
cd ProductOrderApp
dotnet restore
dotnet run