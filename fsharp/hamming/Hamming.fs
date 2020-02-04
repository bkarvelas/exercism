module Hamming

let compare2Lists (list1:char list) (list2: char list)  =
    let mutable acc = 0
    if list1.Length <> list2.Length then
        None
    else
        for i = 0 to list1.Length - 1 do
            if list1.Item(i) <> list2.Item(i) then
                acc <- acc + 1 
            elif list1 = list2 then
                acc <- 0
            else
                acc |> ignore
        Some acc

let distance (strand1: string) (strand2: string): int option = 
    let strand1List = strand1 |> Seq.toList
    let strand2List = strand2 |> Seq.toList
    compare2Lists strand1List strand2List