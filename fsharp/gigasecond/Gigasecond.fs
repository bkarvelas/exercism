module Gigasecond

open System

let add (beginDate: DateTime) = 
    beginDate.AddSeconds(Math.Pow(10.0,9.0))