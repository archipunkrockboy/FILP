open System

//38

//количество элементов на  отрезке А Б 
let CountElemOnAB list a b = 
    let rec CountElemOnAB1 list a b resultList= 
        match list with
        []-> resultList
        |head :: tail -> if head >= a && head <= b then 
                                                    CountElemOnAB1 tail a b (List.append resultList [head])
                         else CountElemOnAB1 tail a b resultList
    CountElemOnAB1 list a b []

[<EntryPoint>]
let main argv = 
    
    let list = Program.ReadData
    Program.WriteList list

    Program.WriteList (CountElemOnAB list 0 10)

    0