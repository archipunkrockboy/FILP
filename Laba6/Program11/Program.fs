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


//переделал
let f1 list f =
    let rec f11 list f resultList = 
        match list with 
        []->resultList
        |head :: a :: b :: tail -> f11 tail f (resultList@[f head a b])
        |head :: a :: tail -> f11 tail f (resultList@[f head a 1])
        |head :: tail -> f11 tail f (resultList@[f head 1 1])
    f11 list f []
    

[<EntryPoint>]
let main argv =

    let list = ReadData
    WriteList list
    WriteList(f1 list (fun x y z -> x + y + z))
    WriteList (ListProcessing list)

    0