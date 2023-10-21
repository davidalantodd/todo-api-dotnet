# To Do API
A To Do List API to manage tasks using .NET Core and C#

## Run Locally

Clone the project

```bash
  git clone https://github.com/davidalantodd/todo-api-dotnet
```

Go to the project directory

```bash
  cd todo-api-dotnet
```

Trust HTTP certificate

```bash
  dotnet dev-certs https --trust
```

Start the server

```bash
  dotnet run --launch-profile https
```

Test the API endpoints by visting the https URL with /swagger appended. (e.g. https://localhost:1234/swagger)


Created using this [Microsoft tutorial](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-7.0&tabs=visual-studio-code)
