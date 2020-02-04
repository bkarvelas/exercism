[<Fact>]
let ``Stating something`` () =
    response "Tom-ay-to, tom-aaaah-to." |> should equal "Whatever."