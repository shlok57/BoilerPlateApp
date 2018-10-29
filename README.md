# BoilerPlateApp

A boilerplate application in C# .net framework to learn and demonstrate end-to-end application development as a ground-up base for an enterprise application while trying out various architectural patterns and framework. The application is a basic windows form app with basic CRUD functions to the connecting database. 

## Projects within solution 

1. BoilerPlate App -> Windows form application which takes in the data and displays them on UI. 
2. Business -> Project containing the business logic of the application.
3. Core -> Project containing the core platform functionality like Dependency Injection and security features. 
    * [Winsor Castle][1] used for dependency injection framework. (In Progress)
4. DBProviders -> Project containing DB provider classes and DB connection management classes.
5. Models -> Project containing the models used throughout the application.
6. Tests -> MS Test Project.
    * [Moq][2] framework used to mock out dependencies.

## TODO
* Add a setup project to install/clean-and-reinstall database.
* Add a windows service to let other parallel app to consume business logic of the application
* Add a web app and expose rest API


[1]: https://github.com/castleproject/Windsor
[2]: https://github.com/moq/moq
