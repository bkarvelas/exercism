module ReverseString
open System

let reverse (input: string): string = 
    let charList = Seq.toList input
    let res = charList |> List.rev |> String.Concat
    res