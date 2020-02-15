namespace MathService.Tests

open System
open NUnit.Framework
open MathService

[<TestFixture>]
type TestClass () =

    [<Test>]
    member this.TestEventSequence() =
      let expected = Seq.empty<int>
      let actual = MyMath.squaresOfOdds [2; 4; 6; 8; 10]
      Assert.That(expected, Is.EqualTo(actual))

    [<Test>]
    member this.TestOnesAndEvents() = 
      let expected = [1; 1; 1; 1]
      let actual = MyMath.squaresOfOdds [2; 1; 4; 1; 6; 1; 8; 1; 10]
      Assert.That(actual, Is.EqualTo(expected))