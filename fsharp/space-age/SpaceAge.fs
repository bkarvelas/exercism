module SpaceAge

type Planet = 
  | Earth   
  | Mercury 
  | Venus   
  | Mars    
  | Jupiter 
  | Saturn  
  | Uranus  
  | Neptune 

let orbitalPeriod = function
  | Earth   -> 1.0  
  | Mercury -> 0.2408467
  | Venus   -> 0.61519726
  | Mars    -> 1.8808158
  | Jupiter -> 11.862615
  | Saturn  -> 29.447498
  | Uranus  -> 84.016846
  | Neptune -> 164.79132

let age (planet: Planet) (seconds:int64): float = 
  let onEarth x = (x / 60.0 / 60.0 / 24.0 / 365.25)
  let earthYears = (float seconds) |> onEarth
  planet |> orbitalPeriod |> (/) earthYears