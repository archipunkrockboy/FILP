open System

//18

let ReadArray n =
    let rec read n arr = 
        match n with 
        |0 -> arr
        |_->
            let newEl=Console.ReadLine()|>Convert.ToInt32
            let newArr = Array.append arr [|newEl|]
            read (n-1) newArr
    read n [||]

let WriteArray arr = 
    printfn "%A" arr

let SimmetrRazn (arr1: int array) (arr2: int array) = 
    Array.append (Array.fold (fun acc elem1 -> if (Array.tryFind (fun y -> y = elem1) arr2) <> None then (Array.append acc [||]) else Array.append acc [|elem1|])  [||] arr1) (Array.fold (fun acc elem2 -> if (Array.tryFind (fun y -> y = elem2) arr1) <> None then (Array.append acc [||]) else Array.append acc [|elem2|])  [||] arr2)
     


[<EntryPoint>]
let main argv = 
    Console.WriteLine("Первый массив:")
    let arr1 = Console.ReadLine() |> Convert.ToInt32 |>ReadArray 
    Console.WriteLine("Второй массив:")
    let arr2 = Console.ReadLine() |> Convert.ToInt32 |>ReadArray 
    WriteArray (SimmetrRazn arr1 arr2)
    0

