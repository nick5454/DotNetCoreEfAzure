## Referencing

You can reference Cake.DotNetCoreEfAzure in your build script as a cake addin:

```cake
#addin "Cake.DotNetCoreEfAzure"
```

or nuget reference:

```cake
#addin "nuget:https://www.nuget.org/api/v2?package=Cake.DotNetCoreEfAzure"
```

### Database Update

```csharp
#addin nuget:Cake.DotNetCoreEfAzure

var target = Argument("target", "Default");

Task("Default")
  .Does(() =>
{
    var settings = new DotNetCoreEfDatabaseUpdateSettings
    {
        Context = "BloggingContext"
    };

    DotNetCoreEfDatabaseUpdate("./src/ConsoleApp1", settings);
});

RunTarget(target);
```

```csharp
#addin nuget:Cake.DotNetCoreEfAzure

var target = Argument("target", "Default");

Task("Default")
  .Does(() =>
{
    DotNetCoreEfDatabaseUpdate("./src/ConsoleApp1");
});

RunTarget(target);
```

### Database Drop

```csharp
#addin nuget:Cake.DotNetCoreEfAzure
var target = Argument("target", "Default");

Task("Default")
  .Does(() =>
{
    var settings = new DotNetCoreEfDatabaseDropSettings
    {
        Context = "BloggingContext",
        Force = true
    };

    DotNetCoreEfDatabaseDrop("./src/ConsoleApp1", settings);
});

RunTarget(target);
```

```csharp
#addin nuget:Cake.DotNetCoreEfAzure
var target = Argument("target", "Default");

Task("Default")
  .Does(() =>
{
    DotNetCoreEfDatabaseDrop("./src/ConsoleApp1");
});

RunTarget(target);
```