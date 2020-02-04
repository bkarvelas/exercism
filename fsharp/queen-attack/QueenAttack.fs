module QueenAttack

let create (position: int * int) = 
    match position with
    | (x,y) when x > 7 || x < 0 || y > 7 || y < 0 -> false
    | (_,_) -> true

let (|IsOrthogonalAttack|IsDiagonalAttack|CanNotPlaceTwoQueensInSameSpot|CanNotAttack|) (blackQueen, whiteQueen) = 
    match (blackQueen, whiteQueen) with
    | (bqx,bqy), (wqx,wqy) when bqx = wqx || bqy = wqy -> IsOrthogonalAttack
    | (bqx,bqy), (wqx,wqy) when (abs (bqx - wqx)) = (abs (bqy - wqy)) -> IsDiagonalAttack
    | bq, wq when bq = wq -> CanNotPlaceTwoQueensInSameSpot
    | _ -> CanNotAttack

let canAttack blackQueen whiteQueen = 
    match blackQueen, whiteQueen with
    | IsOrthogonalAttack -> true
    | IsDiagonalAttack -> true
    | CanNotPlaceTwoQueensInSameSpot -> failwith "You can't place two queens in the same square"
    | CanNotAttack -> false