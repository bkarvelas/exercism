module RnaTranscription


let rnaTranscriptor dnaNucleotide = 
    match dnaNucleotide with
    | 'G' -> "C"
    | 'C' -> "G"
    | 'T' -> "A"
    | 'A' -> "U"
    | _ -> ""

let toRna (dna: string) = 
    dna |> Seq.map rnaTranscriptor |> String.concat ""