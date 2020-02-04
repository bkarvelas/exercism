module CollatzConjecture

let steps (number: int): int option = 
    match number with
    | n when n <= 0 -> None
    | _ ->  let result = 
                let rec conjecture x acc =  
                    match x with
                    | n when n = 1 -> acc 
                    | n when n <= 0 -> 0
                    | n when n % 2 = 0 -> conjecture (n / 2) (acc + 1)
                    | n -> conjecture ((n * 3) + 1) (acc + 1)
                conjecture number 0
            Some result
