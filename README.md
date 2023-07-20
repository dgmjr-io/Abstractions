---
authors:
  - dgmjr
title: DGMJR Abstractions
description: A collection of abstractions for uses in onther projects.
date: 2023-03-29T04:13:07.344Z
project: Dgmjr.Types
slug: dgmjr-abstractions
type: readme
lastmod: 2023-03-29T04:13:07.344Z
license: MIT
keywords:
  - abstractions
  - interfaces
  - contracts
version: 0.0.1
---

# DGMJR Abstractions

A collection of abstractions/interfaces (i.e., data contracts) for uses in onther projects.

## Common Data Types

This library provides a set of interfaces that can be used to define common functionality for different types of objects.

## Interfaces

The following interfaces are defined in this library:

### [IAsyncDisposable](https://github.com/dgmjr-io/Dgmjr.Types/blob/main/Abstractions/IAsyncDisposable.cs)

Defines the `ValueTask DisposeAsync()` method (for .NET Standard 2.1+) or the `Task DisposeAsync()` method (for <= .NET Standard 2.0)

### [HaveA[Writable]Description](https://github.com/dgmjr-io/Dgmjr.Types/blob/main/Abstractions/HaveADescription.cs)

Defines the `string Description {get;}` property.

### [IHaveA[Writable]Name](https://github.com/dgmjr-io/Dgmjr.Types/blob/main/Abstractions/IHaveAName.cs)

Defines the `string Name {get;[set;]}` property.

### [IHaveA[Writable]Uri](https://github.com/dgmjr-io/Dgmjr.Types/blob/main/Abstractions/IHaveAUri.cs)

Defines the `System.Uri Uri {get;[set;]}` property.

### [IHaveA[Writable]Value](https://github.com/dgmjr-io/Dgmjr.Types/blob/main/Abstractions/IHaveAValue.cs)

Defines the `object Value {get;[set;]}` property.

### [IHaveA[Writable]Value{TValue}](https://github.com/dgmjr-io/Dgmjr.Types/blob/main/Abstractions/IHaveAValue{TValue}.cs)

Defines the `TValue Value {get;[set;]}` property.

### [IIdentifiable](https://github.com/dgmjr-io/Dgmjr.Types/blob/main/Abstractions/IIdentifiable.cs)

Defines the `object Id {get;}` property.

### [IHaveAWritableId](https://github.com/dgmjr-io/Dgmjr.Types/blob/main/Abstractions/IIdentifiable.cs)

Defines the `object Id {get;set;}` property.

### [IIdentifiable{TId}](https://github.com/dgmjr-io/Dgmjr.Types/blob/main/Abstractions/IIdentifiable.cs)

Defines the `TId Id {get;}` property.

### [IHaveAWritableId{TId}](https://github.com/dgmjr-io/Dgmjr.Types/blob/main/Abstractions/IIdentifiable.cs)

Defines the `TId Id {get;set;}` property.

### [ILog](https://github.com/dgmjr-io/Dgmjr.Abstractions/blob/main/Abstractions/ILog.cs)

Defines the `ILogger Logger {get;}` property

### [IUriConvertible](https://github.com/dgmjr-io/Dgmjr.Types/blob/main/Abstractions/IUriConvertible.cs)

Defines the `static abstract` methods `FromUri(string s)` and `FromUri(System.Uri uri)` for classes to be able to define a way to convert themselves from a URI (*.NET 7.0+ only*)

## Usage

To use these interfaces, simply add them to your class or struct definition. For example:

```c#
public class MyClass : IAsyncDisposable, IHaveADescription, IHaveAName, IHaveAUri, IHaveAValue, ILog
{
    public MyClass(ILogger<MyClass> logger)
    {
        Logger = logger;
    }

    public async Task DisposeAsync()
    {
        Logger.LogInformation($"Perfoming clean-up task on {nameof(MyClass)}...");
    }

    public ILogger Logger { get; }

    public string Description { get; }

    public string Name { get; }

    public Uri Uri { get; }

    public object Value { get; }
}
```

You can then use these interfaces to access the properties and methods of your class or struct. For example:

```c#
var myClass = new MyClass
{
    Description = "This is a description of my class";
    Name = "MyClass";
    Uri = new Uri("https://www.example.com");
    Value = "My value";
}

await myClass.DisposeAsync();
```

## Conclusion

These interfaces provide a way to define common functionality for different types of objects. By using these interfaces, you can make your code more consistent and easier to maintain.
