module ListSearch

/// Returns position of an element in a list (starting from 0) or None if no such element is present
let find list element  =
    let rec findRecursive list position =
        match list with
        | [] -> None
        | h :: _ when h = element -> Some position
        | _ :: t -> findRecursive t (position + 1)
    findRecursive list 0
