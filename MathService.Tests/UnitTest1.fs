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
