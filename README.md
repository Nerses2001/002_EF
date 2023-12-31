# 002_EF
## Using Entity Framework Core

The project uses Entity Framework Core to work with the database, which is an object-oriented tool for data access.

1. **Installing the necessary packages**

    To work with Entity Framework Core, you need to install the corresponding NuGet packages:

    ```bash
    Install-Package Microsoft.EntityFrameworkCore.Design -Version 7.0.11
    Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 7.0.11
    Install-Package Microsoft.EntityFrameworkCore.Tools -Version 7.0.11
    ```

2. **Generating classes from the database**

    To automatically generate classes based on an existing database, the `scaffold-dbcontext` command is used in the Package Manager Console:

    ```bash
    scaffold-dbcontext "server=.;database=EF;Trusted_Connection=True;TrustServerCertificate=true;" Microsoft.EntityFrameworkCore.SqlServer
    ```

    This command creates model and data context classes (`User.cs` and `EfContext.cs`) based on the database schema.

3. **Project Structure**

    - `User.cs`: Class representing the user model.
    - `EfContext.cs`: Database context class for working with users.
    - `UserRepository.cs`: Class with methods for working with users in the database.

    ```
    ├── _002_EF
    │   ├── User.cs
    │   ├── EfContext.cs
    │   ├── UserRepository.cs
    └── Program.cs
    ```
