# BagStore

## Project Structure

```
/src
- ApplicationCore
- Infrastructure
- Web

/tests
- UnitTests
```

## Packages
```
/ApplicationCore
Install-Package Ardalis.Specification

/Infrastructure
Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.AspNetCore.Identity.EntityFrameworkCore
Install-Package Npgsql.EntityFrameworkCore.PostgreSQL
Install-Package Ardalis.Specification.EntityFrameworkCore

/Web
Install-Package Npgsql.EntityFrameworkCore.PostgreSQL

```
/UnitTests
install-package Moq

## Migrations
```
/Infrastructure
Add-Migration IdentityInitialCreate -Context AppIdentityDbContext -OutputDir "Identity\Migrations"
Update-Database -Context AppIdentityDbContext 

Add-Migration BagStoreInitialCreate -Context BagStoreContext -OutputDir "Data\Migrations"
Update-Database -Context BagStoreContext 
```

## Useful Links

* https://github.com/dotnet-architecture/eShopOnWeb
* https://gist.github.com/kottenator/9d936eb3e4e3c3e02598
* https://gist.github.com/yigith/c6f999788b833dc3d22ac6332a053dd1
* https://sweetalert2.github.io
* https://learn.microsoft.com/en-us/aspnet/core/mvc/models/model-binding?view=aspnetcore-6.0#dictionaries-1
* https://github.com/dotnet/aspnetcore/issues/16663
* https://learn.microsoft.com/en-us/aspnet/core/fundamentals/middleware/write?view=aspnetcore-6.0
* https://getbootstrap.com/docs/5.2/examples/checkout/
* https://stackoverflow.com/questions/69961449/net6-and-datetime-problem-cannot-write-datetime-with-kind-utc-to-postgresql-ty