open System

//18

//элементы до N
let ElemBeforeMin list = 
    let rec ElemBeforeMin1 list currentIndex minIndex resultList = 
        match list with
        []->resultList
        |head :: tail -> 
                         if (currentIndex < minIndex) then 
                            ElemBeforeMin1 tail (currentIndex+1) minIndex (List.append resultList [head])
                         else resultList
                         
    ElemBeforeMin1 list 0  (List.findIndex (fun x->x = (List.min list)) list) []





[<EntryPoint>]
let main argv =
    
    let list = Program.ReadData 
    Program.WriteList list 
    let a = ElemBeforeMin list
    Program.WriteList a
    0