open System

let LocalMax list = 
    let rec LocalMax1 list maxElem count = 
        match list with
        []-> count
        |head :: tail -> if head = maxElem then LocalMax1 tail maxElem  (count+1)
                         else LocalMax1 tail maxElem count
    LocalMax1 list (fst(Program.FirstMax list)) 0 

[<EntryPoint>]
let main argv =
    
    let list = Program.ReadData 
    Console.WriteLine(LocalMax list)

    0 