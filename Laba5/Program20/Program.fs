open System

let ChoiceFunction = function
    | 1 -> Program.EulerNumber
    | 2 -> Program.Sum3
    | _ -> Program.MaxPrimeNumber


[<EntryPoint>]
let main argv =

    Console.WriteLine("Введите номер функции и число: ")
    let data = (Console.ReadLine() |> Int32.Parse, Console.ReadLine() |> Int32.Parse)
    let result = ChoiceFunction (fst data) (snd data)
    printfn "Ответ: %d"  result
    0