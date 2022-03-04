# Separate your app with logical tires
This is an dotnet app template with seperation between the messages arrived from outside 

* Web - represent the presentation tier, contains the landing page and web apps navigations: "Home", "Privacy" and "Weather Forecast".
  * Pages - contains the UI pages.
* Api - reponsible to incoming HTTP messages.
  * Controllers - contains the RESTFul API's.
* Services - represent the transformation tier
* Data - contains the DB context and repository.
* Domain - contains the "domain" app, wich is the abstraction of the app.
  * Entities - 
  * Enums - 
  * General - 
  * Interfaces - 
  * Models - 

<pre>
│   dotnet-template.sln
│
├───DT.Api
│   │   Program.cs
│   │
│   ├───Controllers
│   │       WeatherForecastController.cs
│
├───DT.Data
│       DataContext.cs
│       Repository.cs
│
├───DT.Domain
│   ├───Entities
│   │       WeatherForecast.cs
│   │
│   ├───Enums
│   │       OrderByType.cs
│   │
│   ├───General
│   │       IEntity.cs
│   │       OperationStatus.cs
│   │
│   ├───Interfaces
│   │       IRepository.cs
│   │       IService.cs
│   │       IViewModel.cs
│   │       IWeatherForecastService.cs
│   │
│   └───Models
│           WeatherForecastViewModel.cs
│
├───DT.Services
│       WeatherForecastService.cs
│
└───DT.Web
    │   Program.cs
    │
    ├───Pages
    │   │   Error.cshtml
    │   │   Index.cshtml
    │   │   Privacy.cshtml
    │   │   WeatherForecast.cshtml
    │   │   _ViewImports.cshtml
    │   │   _ViewStart.cshtml
    │   │
    │   └───Shared
    │           _Layout.cshtml
    │           _ValidationScriptsPartial.cshtml
</pre>
