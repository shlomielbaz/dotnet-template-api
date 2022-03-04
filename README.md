# Separate your app with logical tires
This is an dotnet app template with seperation between the messages arrived from outside into application logic processing.

* **Web** - represent the presentation tier, contains the landing page and web apps navigations: "Home", "Privacy" and "Weather Forecast".
  * **Pages** - contains the UI pages.
* **Api** - reponsible to incoming HTTP messages.
  * **Controllers** - contains the RESTFul API's.
* **Services** - represent the transformation tier where incoming messages represented by ViewModels transform to Entities and vice versa.
* **Data** - contains the DB context and repository.
* **Domain** - contains the "domain" app, wich is the abstraction of the app.
  * **Entities** - contains a classes that reflects the DB schemas.
  * **Enums** - contains the application types.
  * **General** - contains a classes for general use.
  * **Interfaces** - contains a interfaces that represent the application abstraction.
  * **Models** - contains a classes that represent data transfare object and views reflaction.


<br /><br />
## Application Diagram
![Application Diagram](/app-diagram.png)
