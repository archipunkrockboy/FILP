open System

let rec MultUp x = 
    if x = 0 then 1
    else x%10 * MultUp(x/10)

let MultDown x = 
    let rec MultDown1 x current =
        if x = 0 then current
        else
            let current1 = current * (x%10)
            let x1 = x/10
            MultDown1 x1 current1
    MultDown1 x 1


let rec FactUp x = 
    if x = 1 then 1
    else x*FactUp(x-1)

let FactDown x = 
    let rec FactDown1 x current = 
        if x = 1 then current
        else
            let current1 = current * (x)
            let x1 = x-1
            FactDown1 x1 current1
    FactDown1 x 1

[<EntryPoint>]
let main argv =
    Console.WriteLine(MultUp 12345)
    Console.WriteLine(MultDown 12345)
    Console.WriteLine()
    Console.WriteLine(FactUp 6)
    Console.WriteLine(FactDown 6)

    0