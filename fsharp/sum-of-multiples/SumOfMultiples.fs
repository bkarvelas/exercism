module SumOfMultiples

let sum (numbers: int list) (upperBound: int) = 
  numbers 
    |> Seq.collect (fun n -> if n <> 0 then [n..n..upperBound - 1] else [])
    |> Seq.distinct
    |> Seq.sum