module ArmstrongNumbers
open System

let isArmstrongNumber (number:int): bool = 
    let strNumber = string number
    let numericList = strNumber |> Seq.toList |> List.map (Char.GetNumericValue)
    let numbersCount = numericList.Length
    numericList 
    |> List.sumBy (fun x -> (x ** float numbersCount) |> int) 
    |> (=) number