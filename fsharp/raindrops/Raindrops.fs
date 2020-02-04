module Raindrops

type Raindrop = 
    | Raindrop of string Option

let factorsOf n = 
    let ns = [ 1..n ]
    ns |> List.filter (fun x -> n % x = 0)

let raindropTranslator = function
    | 3 -> Raindrop (Some "Pling")
    | 5 -> Raindrop (Some "Plang")
    | 7 -> Raindrop (Some "Plong")
    | _ -> Raindrop None

let chooseRaindrops (factors: int list): string list = 
    factors |> List.map (raindropTranslator >> (fun (Raindrop s) -> s)) |> List.choose id

let convert (number: int): string = 
    let raindrops = (factorsOf number) |> chooseRaindrops 
    match raindrops with
    | [] -> string number
    | r -> r |> String.concat ""