module Bob
open System

let isUpper str = 
    match str |> Seq.filter Char.IsLetter |> Seq.toList with
    | [] ->  false
    | x  -> x |> Seq.forall Char.IsUpper

let (|IsYelling|WithoutSayingAnything|AnythingElse|) (str:string) = 
    match str with
    | _ when String.IsNullOrWhiteSpace(str) -> WithoutSayingAnything
    | _ when isUpper str                    -> IsYelling
    | _                                     -> AnythingElse

let (|IsQuestion|_|) (str:string) = 
    match str.Trim().EndsWith "?" with
    | true  -> Some IsQuestion
    | false -> None

let response (input: string): string = 
    match input with
    | WithoutSayingAnything  -> "Fine. Be that way!"
    | IsYelling & IsQuestion -> "Calm down, I know what I'm doing!"
    | IsQuestion             -> "Sure." 
    | IsYelling              -> "Whoa, chill out!"
    | AnythingElse           -> "Whatever."