# Red_Tech_Coding_Challenge_BackEnd
###BACKEND

Project Overview <br />
• Using .NET/.NET Core (3.1 or higher [5, 6, etc.]) and C#, create an “Orders” web API to view, create, update, and delete orders o An additional endpoint will be created to search by “Customer”
Deliverables <br />
• Implement an external data store for the orders data o Files, normalized/non-normalized databases, caching, etc., are acceptable o Preference will be given to normalized database implementations (SQL scripts are an ok deliverable) <br />
• Implement 5 endpoints o Create, read, update and delete endpoints for orders
Endpoints should offer basic input validation and error handling <br />
o A search endpoint to filter by Order Types<br />
  Order Types are Standard, SaleOrder, PurchaseOrder, TransferOrder, and ReturnOrder 
• Create and implement at least a repository layer using Dependency Injection (DI) o Feel free to use .NET’s native features or a 3rd party package if preferred <br />
• Entity models should not propagate to the end user, so mapping between entities and user-friendly models should occur <br />

Mandatory Features <br />
• A fully functional set of endpoints to match the expected deliverables <br />
• Any kind of external data store for source data <br />
• Basic DI Implementation for a data ingress class<br />
Above Average Features <br />
• A normalized data store for application entities. An SQL script is an acceptable deliverable. Special consideration is given for knowledge/implementation of Entity Framework. o Code-first or Database-first is acceptable <br />
• Install Swagger on top of the project <br />
• Demonstrated knowledge of DI lifetime management <br />
o A transient or scoped service layer to handle business logic or repository passthrough is acceptable • Unit tests for Controllers and DI classes
Exceptional Features <br />
• All of the Above Average deliverables <br />
• Host your Database and API in a location accessible remotely (i.e. publicly) <br />
• Implement authentication (username/password, token, etc.) for the API • Utilize containerization and/or a deployment pipeline to host the app programmatically<br />
