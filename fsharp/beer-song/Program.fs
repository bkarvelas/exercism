open BeerSong

module Program = let [<EntryPoint>] main _ = 
                    printfn "%A" (recite 1 1)
                    printfn "%A" (recite 91 4)
                    0