![FlUnit Logo](src/FlUnitIcon.png)

# FlUnit.Abstractions

[![NuGet version (FlUnit.Abstractions)](https://img.shields.io/nuget/v/FlUnit.Abstractions.svg?style=flat-square)](https://www.nuget.org/packages/FlUnit.Abstractions/) [![NuGet downloads (FlUnit.Abstractions)](https://img.shields.io/nuget/dt/FlUnit.Abstractions.svg?style=flat-square)](https://www.nuget.org/packages/FlUnit.Abstractions/)

This package contains abstractions shared between the core FlUnit library and test platform adapters.
FlUnit is a test framework in which tests are written using [builders](https://en.wikipedia.org/wiki/Builder_pattern) that expose a [fluent interface](https://en.wikipedia.org/wiki/Fluent_interface), like this:

```csharp
public static Test SumOfEvenAndOdd => TestThat
  .GivenEachOf(() => new[] { 1, 3, 5 })
  .AndEachOf(() => new[] { 2, 4, 6 })
  .When((x, y) => x + y)
  .ThenReturns()
  .And((_, _, sum) => (sum % 2).Should().Be(1))
  .And((x, _, sum) => sum.Should().BeGreaterThan(x))
  .And((_, y, sum) => sum.Should().BeGreaterThan(y));
```

Full documentation for FlUnit can be found via the [FlUnit repository readme](https://github.com/sdcondon/FlUnit).
