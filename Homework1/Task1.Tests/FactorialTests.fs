namespace Tests

open NUnit.Framework
open FsUnit
open Factorial

[<TestFixture>]
type TestClass () =

    [<Test>]
    member this.``factorial(6) should be equal 720`` () =
        factorial 6 |> should equal 720

    [<Test>]
    member this.``factorial(-1) should throw`` () =
        (fun () -> factorial -1 |> ignore) |> should throw typeof<System.ArgumentException>
