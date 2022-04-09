open System

//17




[<EntryPoint>]
let main argv = 

    
    let list = Program.ReadData
    Console.WriteLine(List.countBy (fun x->x) list)
    
    0
