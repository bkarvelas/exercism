module BeerSong

// define lyrics
let dot = "."
let comma = ", "
let bottlesOfBeerWall = " bottles of beer on the wall"
let bottleOfBeerWall = " bottle of beer on the wall"
let bottlesOfBeer = " bottles of beer"
let bottleOfBeer = " bottle of beer"
let takeOneDown = "Take one down and pass it around" 
let takeItDown = "Take it down and pass it around" 
let goToStore = "Go to the store and buy some more" 
let noMore = "no more"
let noMore'Upper = "No more"

let singularOrPlural = function
    | 1 -> bottleOfBeerWall
    | _ -> bottlesOfBeerWall

let recite (startBottles: int) (takeDown: int) = 
    let beerLyrics = function
        | 0 -> [
                noMore'Upper + bottlesOfBeerWall + comma + noMore + bottlesOfBeer + dot; 
                goToStore + comma + string 99 + singularOrPlural startBottles + dot;
                 ""
               ] |> List.rev
        | 1 -> [
                string 1 + bottleOfBeerWall + comma + string 1 + bottleOfBeer + dot; 
                takeItDown + comma + noMore + bottlesOfBeerWall + dot; 
                ""
                ] |> List.rev
        | n -> [
                string n + bottlesOfBeerWall + comma + string n + bottlesOfBeer + dot;
                takeOneDown + comma + string (n - 1) + singularOrPlural (n - 1) + dot; 
                ""
                ] |> List.rev
    [startBottles + 1 - takeDown .. startBottles] 
    |> List.collect beerLyrics
    |> List.tail
    |> List.rev