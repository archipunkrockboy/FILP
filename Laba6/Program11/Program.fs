open System
let rec ReadList n = 
    if n=0 then []
    else
    let Head = System.Convert.ToInt32(System.Console.ReadLine())
    let Tail = ReadList (n-1)
    Head::Tail

let ReadData = 
    let n=System.Convert.ToInt32(System.Console.ReadLine())
    ReadList n

let rec WriteList = function
    [] ->   let z = System.Console.ReadKey()
            0
    | (head : int)::tail -> 
                       System.Console.Write(head)
                       System.Console.Write(" ")
                       WriteList tail  






[<EntryPoint>]
let main argv =
    


    0