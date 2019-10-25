# Urban Engine API

[![Build Status](https://dev.azure.com/urbanengine/Urban%20Engine/_apis/build/status/urban-engine-api?branchName=master)](https://dev.azure.com/urbanengine/Urban%20Engine/_build/latest?definitionId=2&branchName=master)

# DEV Notes

This section will contain any notes to be aware of for developing Urban Engine API

## Results

To make things consistent objects in the [Results](Core/Common/Results) folder are used. Use this to return responses from API endpoints to provide consistent return types

* FailureResult: used to indicate a failure occurred, for example an exception was thrown
* CommandResult: used to indicate result of a command such as an Insert, Update, Delete
* QueryResult: used to indicate result of a query that was performed, returns data and paging information if applicable

## CRUD Operations End to End for simple Entity

If creating an entity and all that is needed are basic CRUD operations follow this checklist to add various interfaces and classes at the appropriate layers

- 

## Exception Handling for API Controllers

To provide a common response when exceptions occur and to ensure exceptions are logged and sensitive error messages are not returned to the client
an exception handler is added in the [Startup.cs](Services/UrbanEngineApi/Startup.cs) file. This allows the capture of any exceptions
thrown by controller endpoints without having to add `try/catch` and `logging` statements in your controllers themselves.

Example:

```csharp
	// see Configure method in Startup.cs
    app.UseExceptionHandler(errorApp =>
    {
        errorApp.Run(async context =>
        {
			// ...see implementation details in Startup.cs file...
        });
    });
```

## Migrate

When the UrbanEngineApi starts up it is currently set to call `Migrate` to update the database. Whether this is run or not is controll by an Environment Variable
called `APPLY_MIGRATIONS` and if this is set to the value of `True` then Migrations will be applied on application start up. This is good to have turned on for any 
development or testing environments but should be disabled in Production and applied only when expected. To see the code where migrations are run go to 
the [Program.cs](Services/UrbanEngineApi/Program.cs) file in the UrbanEngineApi project and look for the `CreateOrMigrateDatabase` method.

## EF Migrations

Run the following command to create a migration, replace `InitialCreate` with name of a migration you want to use. 
NOTE: if you are using SQL Lite it only allows one migration and you will have to remove migrations

```console
dotnet ef migrations add InitialCreate --startup-project Services\UrbanEngineApi --project Infrastructure\Persistence --output-dir Data\Migrations
```

To remove the last migration

```console
dotnet ef migrations remove --startup-project Services\UrbanEngineApi --project Infrastructure\Persistence
```

If working with the local SQL Lite database you'll have to delete the *.db file first as well

## Seed Data

The [SeedDataGenerator](Infrastructre/Persistence/Data/SeedDataGenerator.cs) is used to seed the database
with any initial data. Use this to add any data that should always be present in the database
