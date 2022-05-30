module Polymdrom
open System

// Checks that str is polymdrom.
let isPolyndrom inputString =
    let originalString = inputString |> Seq.toList
    let reversedString = originalString |> List.rev
    List.zip originalString reversedString |> List.forall (fun (x, y) -> x = y)

// Checks that str is pseudo polyndrom.
let checkThatPseudoPolyndr inputString =
    if isPolyndrom inputString then 
        false 
    else
        let originalString = inputString |> Seq.toList
        let reversedString = originalString |> List.rev
        let zipped = List.zip originalString reversedString
        let index = List.findIndex (fun (x, y) -> x <> y) zipped
        let newOriginal, newReversed = 
            zipped 
            |> List.indexed 
            |> List.filter (fun x -> fst x <> index) 
            |> List.map snd
            |> List.unzip
        (isPolyndrom newOriginal) || (isPolyndrom newReversed)

// aguokepatgbnvfqmgmlcupuufxoohdfpgjdmysgvhmvffcnqxjjxqncffvmhvgsymdjgpfdhooxfuupuculmgmqfvnbgtapekouga

let _  = 
    printfn "%A" (checkThatPseudoPolyndr "aguokepatgbnvfqmgmlcupuufxoohdfpgjdmysgvhmvffcnqxjjxqncffvmhvgsymdjgpfdhooxfuupuculmgmqfvnbgtapekouga")