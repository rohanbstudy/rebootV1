# rebootV1

1. Created Project based on shell script present in DevAssest folder
2. Created Domain entity, installed '', created DBContext class added in services by rebuilding project with command and also add db connection string acordingly.
        > dotnet restore
3. To work with ef form visual studio code we need to install dotnet-ef 
        > dotnet tool list -g    // this is command to check what tools are installed
        > dotnet tool install dotnet-ef --global --version 7.0.0    // comand to install dotnet-ef
        > dotnet tool update  dotnet-ef --global --version 7.0.2

4.  Now to run migrations following is command
        > dotnet ef migrations add 'Initial Create' -s API -p Persistence
        Note
            -s : this flag is used to specify startup project
            -p : this flat is to specify where the DB Context class (or EF package is installed.)
        Note
            to use above program, Microsoft.EntityFrameworkCore.Design package should be available in startup project to run

5. 
        