module GradeSchool

let empty: Map<int, string list> = Map.empty 

let add (student: string) (grade: int) (school: Map<int, string list>): Map<int, string list> = 
    match school.TryFind grade with
    | None -> school.Add(grade, [student])
    | Some v -> school.Add(grade, student::v |> List.sort)

let roster (school: Map<int, string list>): (int * string list) list = 
    Map.toList school 

let grade (number: int) (school: Map<int, string list>): string list = 
    match school.TryFind number with
    | None -> []
    | Some g -> g