"# CrudTesteTecnico2019" 

dotnet new sln -n CrudTesteTecnico2019

dotnet new web -n CrudTesteTecnico2019.Web
dotnet new classlib -n CrudTesteTecnico2019.Infrastructure
dotnet new classlib -n CrudTesteTecnico2019.Domain
dotnet new classlib -n CrudTesteTecnico2019.Application
dotnet new classlib -n CrudTesteTecnico2019.Database


dotnet sln CrudTesteTecnico2019.sln add .\CrudTesteTecnico2019.Web
dotnet sln CrudTesteTecnico2019.sln add .\CrudTesteTecnico2019.Infrastructure\CrudTesteTecnico2019.Infrastructure.csproj
dotnet sln CrudTesteTecnico2019.sln add .\CrudTesteTecnico2019.Domain\CrudTesteTecnico2019.Domain.csproj
dotnet sln CrudTesteTecnico2019.sln add .\CrudTesteTecnico2019.Application\CrudTesteTecnico2019.Application.csproj
dotnet sln CrudTesteTecnico2019.sln add .\CrudTesteTecnico2019.Database\CrudTesteTecnico2019.Database.csproj

cd .\CrudTesteTecnico2019.Infrastructure && dotnet add ..\CrudTesteTecnico2019.Domain\CrudTesteTecnico2019.Domain.csproj reference CrudTesteTecnico2019.Infrastructure.csproj

cd .\CrudTesteTecnico2019.Domain && dotnet add ..\CrudTesteTecnico2019.Database\CrudTesteTecnico2019.Database.csproj reference CrudTesteTecnico2019.Domain.csproj
adicionar referencia de todos os projetos improtantes no application

### adicionar pacotes

dotnet add CrudTesteTecnico2019.Database package Microsoft.EntityFrameworkCore.SqlServer
dotnet add CrudTesteTecnico2019.Database package Microsoft.EntityFrameworkCore.Tools.DotNet
dotnet add CrudTesteTecnico2019.Database package Microsoft.EntityFrameworkCore.Design
dotnet add CrudTesteTecnico2019.Database package Microsoft.EntityFrameworkCore.Tools
dotnet add .\CrudTesteTecnico2019.Domain\CrudTesteTecnico2019.Domain.csproj package MediatR
dotnet add .\CrudTesteTecnico2019.Application\CrudTesteTecnico2019.Application.csproj package MediatR
dotnet add .\CrudTesteTecnico2019.Web\CrudTesteTecnico2019.Web.csproj package MediatR

dar um restore e entrar no projeto de banco, pois apenas lá o ef funcionara

dotnet ef migrations add InitialCreate
Add-Migration
Update-database