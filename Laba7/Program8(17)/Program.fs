open System

//17




[<EntryPoint>]
let main argv = 

    
    let list = Program.ReadData

    Console.WriteLine (List.fold (fun acc elem -> if elem%2=0 then acc + elem else acc+0) 0 list)
    0
