AggregateSourceAsync
====================

This project differs from AggregateSource upon which is it heavily based. The async model has been enhanced to allow cancellation tokens to be passed and this is most useful when paired with the AggregateSourceAsync.NEventStoreAsync project which correctly exposes asynchronous operations.

The project is dependent upon .NET 4.6 or .NET Standard 2.0.

[![Gitter](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/yreynhout/AggregateSource?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

This library/code provides lightweight infrastructure for doing eventsourcing using aggregates. It's not a framework, and it never will be. Period.

The preferred way of using it, is copying it into your project and getting rid of all the cruft you don't need. That said, there are NuGet packages available for those of you that are pressed for time and don't mind following the prescribed recipe.

It's well suited for those scenarios where multiple aggregates need to collaborate and is lenient to saving multiple aggregates in one go should your underlying store allow you to do so or your problem domain require you to do so. Of course, nothing is holding you back from throwing when multiple aggregates have been changed. I just think this shouldn't interfere with the programming model you use. Granted, for affecting only one aggregate, there are simpler solutions and to be honest, what I bring you here is in no way unique:

* https://github.com/gregoryyoung/m-r
* https://github.com/joliver/CommonDomain
* https://github.com/Lokad/lokad-iddd-sample
* https://github.com/thinkbeforecoding/m-r
* https://github.com/elliotritchie/NES
* https://github.com/jhicks/EventSourcing
* https://github.com/tyronegroves/SimpleCQRS

## Core

Contains the core types that you will want interact with when building your domain model. A more thorough explanation can be found [here](src/Core/AggregateSource/README.md)

## Testing

Helps you write test specifications, using a simple, codified statechart and a fluent syntax.  A more thorough explanation can be found [here](src/Testing/AggregateSource.Testing/README.md)

## Contributors

* Adrian Lewis ([@dementeddevil](https://github.com/dementeddevil)): Maintainer
* Yves Reynhout ([@yreynhout](https://github.com/yreynhout)): Original creator
* Martijn Van den Broek ([@martijnvdbrk](https://github.com/martijnvdbrk)): ```Optional<T>``` as a struct
* James Nugent ([@jen20](https://github.com/jen20)): ```ConstructorScenarioFor<TAggregateRoot>```, GetEventStore integration
