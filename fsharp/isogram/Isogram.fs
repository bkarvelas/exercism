module Isogram

open System
open System.Text.RegularExpressions

let isIsogram str =
    let strLower = Regex.Replace(str, "[^0-9a-zA-Z:,]+", "") |> Seq.map Char.ToLower
    let chars = strLower |> List.ofSeq
    let distChars = chars |> List.distinct
    chars = distChars
