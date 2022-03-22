open System
let rec ReadList2 n = 
    if n=0 then []
    else
    let Head = System.Convert.ToDouble(System.Console.ReadLine())
    let Tail = ReadList2 (n-1)
    Head::Tail

let ReadData2 = 
    let n=System.Convert.ToInt32(System.Console.ReadLine())
    ReadList2 n
let rec WriteList2 = function
    [] ->   let z = System.Console.ReadKey()
            0
    | (head : double)::tail -> 
                       System.Console.Write(head)
                       System.Console.Write(" ")
                       WriteList2 tail  







[<EntryPoint>]
let main argv =
    
    let list = ReadData2
    WriteList2 list

    0