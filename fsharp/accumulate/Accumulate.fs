module Accumulate


let revList list =
    let rec revListHelper list acc = 
        match list with
        | [] -> acc
        | head::tail -> revListHelper tail (head::acc)
    revListHelper list []

let accumulate<'a, 'b> (func: 'a -> 'b) (input: 'a list): 'b list = 
    let rec mapFunc input acc = 
        match input with
        | [] -> acc
        | head::tail -> mapFunc tail (func head::acc)
    mapFunc input [] |> revList