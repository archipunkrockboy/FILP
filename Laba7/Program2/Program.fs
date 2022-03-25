open System

[<EntryPoint>]
let main argv =
    
    let list = ReadData
    WriteList list 
    Console.WriteLine(Min2 list)
    Console.WriteLine(Min2 list)
    0