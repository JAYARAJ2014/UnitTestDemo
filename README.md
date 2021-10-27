## Steps to recreate (All are done from commandline)

Create a folder UnitTestDemo

```
dotnet new sln
```

Create a folder FizzBuzz
Create a folder FizzBuzzTests //It is a common convention to suffix *Tests or *UnitTests
Inside FizzBuzz

```
dotnet new classlib
```

Inside FizzBuzzTests

```
dotnet new nunit
```

Add projects to the solution

```
dotnet sln add ./FizzBuzzTests/FizzBuzzTests.csproj
dotnet sln add ./FizzBuzz/FizzBuzz.csproj
```

Add reference of the main project to the test project (Because test classes calls the methods of the actual class)

```
dotnet add reference ../FizzBuzz/FizzBuzz.csproj
```

After all these are done, perform a quick build

```
    dotnet build
```

You should get `Build succeeded`

Rename the UnitTest1.cs to FizzBuzzTest

Rename the Test class to FizzBuzzTests

Rename the Class1 in FizzBuzz project to FizzBuzz

Rename the namespace to NumberGimmicks (To avoid confusion of class and namespace being same).

Run a `dotnet build` you should get build succeeded and `dotnet test` you should see passed and failed tests status on command line.

Nothing important at this moment.This is just a sanity check

Import NumberGimmicks namespace ` using FizzBuzz` in FizzBuzzTest
