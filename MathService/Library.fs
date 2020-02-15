namespace MathService

module MyMath =
    let private isOdd = (fun x -> x % 2 <> 0)
    let private square = (fun x -> x * x)
    let squaresOfOdds xs =
      xs |> Seq.filter isOdd
         |> Seq.map square
