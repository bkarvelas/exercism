module PhoneNumber
open System.Text.RegularExpressions

type Result<'uint64,'string> =
| Ok    of uint64
| Error of string

let clean (input: string): Result<uint64,string> = 
    let phoneNumber = Regex.Replace(input, @"[^A-Za-z0-9@:!]+", "")

    let ``10 digits filter`` (phoneNumber: string): Result<uint64, string> =
        match phoneNumber.[0] with
        | '0' -> Error "area code cannot start with zero"
        | '1' -> Error "area code cannot start with one"
        | _   -> 
                 match phoneNumber.[3] with
                 | '0' -> Error "exchange code cannot start with zero"
                 | '1' -> Error "exchange code cannot start with one"
                 | _   -> Ok (uint64 phoneNumber)

    let ``11 digits filter`` (phoneNumber: string): Result<uint64,string> = 
        match phoneNumber.[0] with
        | '1' -> ``10 digits filter`` phoneNumber.[1..]
        | _   -> Error "11 digits must start with 1" 

    match phoneNumber with
    | digits when digits.Length < 10                 -> Error "incorrect number of digits"
    | digits when digits.Length > 11                 -> Error "more than 11 digits"
    | digits when Regex.IsMatch(digits, @"[A-Za-z]+") -> Error "alphanumerics not permitted"
    | digits when Regex.IsMatch(digits, @"[@:!]+")   -> Error "punctuations not permitted"
    | digits when digits.Length = 11                 -> ``11 digits filter`` phoneNumber
    | digits when digits.Length = 10                 -> ``10 digits filter`` phoneNumber
    | _                                              -> Ok (uint64 phoneNumber)