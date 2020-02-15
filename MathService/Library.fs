﻿namespace MathService

module MyMath =
    let squaresOfOdds xs =
      xs |> Seq.filter (fun x -> x % 2 <> 0)
