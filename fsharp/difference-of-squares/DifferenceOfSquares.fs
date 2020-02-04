module DifferenceOfSquares

let squareOfSum (number: int): int = 
    let sum = [1..number]
            |> List.sum
    sum * sum

let sumOfSquares (number: int): int = 
    let listOfNumbers = [1..number]
                        |> List.sumBy (fun n -> n * n)
    int listOfNumbers

let differenceOfSquares (number: int): int = 
    (squareOfSum number) - (sumOfSquares number)