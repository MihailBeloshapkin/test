module test

open NUnit.Framework
open FsUnit
open Polymdrom
open System
open System.Collections
open System.Collections.Generic

[<Test>]
let ``empty string test`` () =
    Polymdrom.checkThatPseudoPolyndr "" |> should be False

[<Test>]
let ``sinhle char test`` () =
    Polymdrom.checkThatPseudoPolyndr "a" |> should be False

[<Test>]
let ``very simple test`` () =
    Polymdrom.checkThatPseudoPolyndr "abca" |> should be True

[<Test>]
let ``another simple test`` () =
    Polymdrom.checkThatPseudoPolyndr "abcba" |> should be False

[<Test>]
let ``should be false`` () =
    Polymdrom.checkThatPseudoPolyndr "yddyio" |> should be False

[<Test>]
let ``another simple test that should be true`` () =
    Polymdrom.checkThatPseudoPolyndr "abcdba" |> should be True


[<Test>]
let ``this huge str should be a pseudo polyndrom`` () =
    Polymdrom.checkThatPseudoPolyndr "aguokepatgbnvfqmgmlcupuufxoohdfpgjdmysgvhmvffcnqxjjxqncffvmhvgsymdjgpfdhooxfuupuculmgmqfvnbgtapekouga"
                                     |> should be True