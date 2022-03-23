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

let ListProcessing list = 
    let rec ListProcessing1 list resultList = 
        match list with
        []->resultList
        |head :: a :: b :: tail -> ListProcessing1 tail (resultList@[head + a + b])
        |head :: a :: tail -> ListProcessing1 tail (resultList@[head + a + 1])                            
        |head :: tail -> ListProcessing1 tail (resultList@[head + 2])
                         
    ListProcessing1 list []

[<EntryPoint>]
let main argv =

    let list = ReadData
    WriteList list
    let list = ListProcessing list
    Console.WriteLine()
    WriteList list

    0