module Fibonacci

/// Calculates nth Fibonacci number
let fibonacci n =
    let rec fibonacciRecursive counter previous current =
        if counter >= n then
            current
        else
            fibonacciRecursive (counter + 1) current (previous + current)
    if n <= 0 then
        invalidArg "n" "Parameter shall be positive"
    else
        fibonacciRecursive 2 1 1

[<EntryPoint>]
let main args =
    printfn "fibonacci 5 = %d" <| fibonacci 5
    0