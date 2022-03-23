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

let rec CheckZR list = 
    let rec CheckZR1 list t = 
        match list with 
        []->true
        |head :: tail -> if (abs(t%1.0) = 0.0) then 
                                                if (abs(head%1.0) <> 0.0) then CheckZR1 tail head
                                                else false
                         else
                            if (abs(head%1.0) = 0.0) then CheckZR1 tail head
                            else false
    CheckZR1 list list.[1]

let CheckList list = 
    Console.WriteLine()
    if CheckZR list then Console.WriteLine("Условие выполнено")
    else Console.WriteLine("Условие НЕ выполнено")


[<EntryPoint>]
let main argv =
    
    let list = ReadData2

    WriteList2 list

    CheckList list
    0