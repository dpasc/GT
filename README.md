Grande Travel

Problem:
The price of travel is usually increased by B2B businesses selling services on behalf of larger companies.


Project Mission:
Provide a platform that allows organisations to sell travel packages direct to customers.


Methodology:
Customers will be able to:

    Create an account
    Search for travel packages and compare prices
    Purchase packages direct from vendors
    Leave reviews on purchase packages
    View previously purchased packages


Vendors can:

    Create a vendor account
    Configure travel packages for sale
    Remove travel packages


Architecture
User Interface:

This platform uses a basic web interface consisting of jQuery and Bootstrap.

Screen shot:
https://dpasc-site-pictures.s3-ap-southeast-2.amazonaws.com/GT_home.png

Server Side:
This project was build using .NET Core 3.0, Entity Framework Core and Identity Core. The project uses a Model, View, Controller architecture to create and deliver views to the client.

The data layer is built using Entity Framework Core and the repository design pattern; the combination of the two means that the data layer can adapt to use different data sources with ease when needed.

The server side portion of the platform also has a REST API; this was made so that in future mobile applications could easily be added if needed.


Database:

database design: https://dpasc-site-pictures.s3-ap-southeast-2.amazonaws.com/GT_DB_Diagram.PNG


This platform uses a Microsoft SQL relational database to store user information, sale items and purchases. The application also uses a stored procedure that works in conjunction with Entity Framework to retrieve search queries from the database. The benefit to this is, we allow the database to compute the search result and return only what is required.
Deployment

The program is set up to run on a single server, this seemed like a simple solution for a basic project. I recently began playing around with AWS services and put together a network diagram of how the platform could potentially operate using cloud services. This would mean slight changes to the architecture of the program.

Project Status:
The project is fully functional however, has some minor bugs. GT was a personal project that was put together for learning purposes. I will continue to work on this in my free time however, it is not of high importance. GT is also open for anyone to add to. The project is also a great tool for junior developers to experiment with.



Source code:
https://github.com/dpasc/GT



How to run program:

Ensure you have the .NET Core run time and Microsoft SQL installed on your machine.

1. Edit the connection string:

UI/appsettings.json

'Server=~YourServerName~;Database=GTDb;Trusted_Connection=true;'

2. Set up database:

Run Entity Framework ‘dotnet ef database update’ in /UI

3. Execute program:

Move to /UI

run 'dotnet run'
