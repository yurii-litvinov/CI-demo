namespace Tests

open NUnit.Framework
open FsUnit
open Fibonacci

[<TestFixture>]
type TestClass () =

    [<Test>]
    member this.``fibonacci(1) should be equal 1`` () =
        fibonacci 1 |> should equal 1

    [<Test>]
    member this.``fibonacci(0) should throw`` () =
        (fun () -> fibonacci 0 |> ignore) |> should throw typeof<System.ArgumentException>

    [<Test>]
    member this.``fibonacci(5) should be equal 5`` () =
        fibonacci 5 |> should equal 5

    [<Test>]
    member this.``fibonacci(10) should be equal 55`` () =
        fibonacci 10 |> should equal 55
