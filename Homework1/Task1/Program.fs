module Factorial

/// Calculates factorial of given argument
let factorial n =
    let rec factorialRecursive n acc =
        match n with
        | 1 -> acc
        | _ -> factorialRecursive (n - 1) (acc * n)
    if n <= 0 then
        invalidArg "n" "Parameter shall be positive"
    else
        factorialRecursive n 1

[<EntryPoint>]
let main args =
    printfn "factorial 6 = %d" <| factorial 6
    0