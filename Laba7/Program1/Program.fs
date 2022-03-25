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
            Console.WriteLine()
            0
    | (head : int)::tail -> 
                       System.Console.Write(head)
                       System.Console.Write(" ")
                       WriteList tail  
let Min2 (list: 'a list) =     
    let minIndex1 = List.findIndex (fun x -> x = List.min list) list
    let list = List.removeAt minIndex1 list
    let minIndex2 = List.findIndex (fun x -> x = List.min list) list
    if minIndex2 >= minIndex1 then (minIndex1, (minIndex2+1))
    else (minIndex1, minIndex2)

    
    
    
[<EntryPoint>]
let main argv =
    
    let list = ReadData
    WriteList list
    
    Console.WriteLine(Min2 list)
    

    0 