namespace MathService.Tests

open System
open NUnit.Framework
open MathService

[<TestFixture>]
type TestClass () =
    
    [<Test>]
    member this.TestMethodPassing() = Assert.True(true)

    [<Test>]
    member this.FailEveryTime() = Assert.True(false)


