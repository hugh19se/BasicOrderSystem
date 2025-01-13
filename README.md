# BasicOrderSystem
A Full Stack Solution To Show Basic Order Information

## Wiki
The [Wiki](https://github.com/hugh19se/BasicOrderSystem/wiki) contains guides on how to set up the solution and the optional SQL Server 2022 instance, as well as a reference for the API.

## Known Issues

### Service Separation
There are places on the service layer in the Web API where customer data retrieval is being managed by the order data retrieval classes. This can be fixed by making a new service for customer related requests and splitting out the logic.

## Tech Stack
Frontend - Windows Forms\
Backend - ASP.NET Core Web API\
Database - Microsoft SQL Server 2022

## Optional SQL Server 2022 instance
I understand that it might not be ideal for some people running this to also have to run a SQL Server instance. That is why I've also included an implementation of the order retrieval service that uses JSON files with the same data. While this would not be common place in a typical production environment, it works well for testing purposes.

I reccomend running the following commands so that subsequent changes made to the `Orders.json` and `Customers.json` files aren't tracked
```
git update-index --assume-unchanged ./BasicOrderSystem.WebAPI/JSONDB/Orders.json
```
```
git update-index --assume-unchanged ./BasicOrderSystem.WebAPI/JSONDB/Customers.json
```