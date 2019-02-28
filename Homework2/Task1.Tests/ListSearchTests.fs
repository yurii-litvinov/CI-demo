namespace Tests

open NUnit.Framework
open FsUnit
open ListSearch

[<TestFixture>]
type TestClass () =

    [<Test>]
    member this.``find in empty list shall return None`` () =
        find [] 1 |> should equal None

    [<Test>]
    member this.``find 1 in [1; 2; 3] list shall return 0`` () =
        find [1; 2; 3] 1 |> should equal (Some 0)

    [<Test>]
    member this.``find 2 in [1; 2; 3] list shall return 1`` () =
        find [1; 2; 3] 2 |> should equal (Some 1)

    [<Test>]
    member this.``find 3 in [1; 2; 3] list shall return 2`` () =
        find [1; 2; 3] 3 |> should equal (Some 2)

    [<Test>]
    member this.``find 4 in [1; 2; 3] list shall return None`` () =
        find [1; 2; 3] 4 |> should equal None

    [<Test>]
    member this.``find some number in gigantic list shall return correct index`` () =
        find [100000..-1..1] 1 |> should equal (Some 99999)
    