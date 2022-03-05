# Separate your app with logical tires
This is a dotnet app template with separation between the messages arrived from outside into application logic processing.

### Application Folder Structure
* **Web** - represent the presentation tier, contains the landing page and web apps navigations: "Home", "Privacy" and "Weather Forecast".
  * **Pages** - contains the UI pages.
* **Api** - responsible for incoming HTTP messages.
  * **Controllers** - contains classes that handle the RESTFul API's.
* **Services** - represent the transformation tier where incoming messages represented by ViewModels transform to Entities and vice versa.
* **Data** - contains the DB context and repository.
* **Domain** - contains the "domain" app, which is the abstraction of the app.
  * **Entities** - contains classes that reflect the DB schemas.
  * **Enums** - contains the application types.
  * **General** - contains classes for general use.
  * **Interfaces** - contains interfaces that represent the application abstraction.
  * **Models** - contains classes that represent data transfer object and views reflection.

### Application Diagram
![Application Diagram](/app-diagram.png)

### Running The Project
The solution contains two runnable project: **DT.Api** and **DT.Web**, in order to execute it through Visual Stuio you need to set multiple startup projects, you need to right click on the solution name, click on "Set Startup Projects", and then:
![set multiple startup projects](/set-multiple-startup-projects.png)

in order to execute it through CLIs (PowerShell), inside folder **DT.Api** and **DT.Web**, run **dotnet run**, e.g.:

```
dotnet-template-api\DT.Api> dotnet run
```

```
dotnet-template-api\DT.Web> dotnet run
```
