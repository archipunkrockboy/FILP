open System

//let LocalMax list = 
    //let rec LocalMax1 list maxElem count = 
        //match list with
        //[]-> count
        //|head :: tail -> if head = maxElem then LocalMax1 tail maxElem  (count+1)
                         //else LocalMax1 tail maxElem count
    //LocalMax1 list (fst(Program.FirstMax list)) 0 


//переделал
let LocalMax list = 
    let rec LocalMax1 list count = 
        match list with
        []-> count
        |head :: a :: b :: tail -> if (a>b && a>head) then LocalMax1 list.Tail (count+1)
                                   else LocalMax1 list.Tail count
        |head :: a :: tail -> count
        |head :: tail -> count
    LocalMax1 list 0

//8 3 1 2 1 8 7 21 5 1 11 1
[<EntryPoint>]
let main argv =
    
    let list = Program.ReadData 
    Program.WriteList list
    Console.WriteLine(LocalMax list)

    0 