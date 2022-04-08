﻿open System

//28

//элементы между первым и последним максимальным
let ElemBetweenFirstLastMax list= 
    let rec ElemBetweenFirstLastMax1 list maxIndex resultList = 
        match list with    
        [] -> resultList
        |head :: a :: tail -> if maxIndex <> 1 then 
                                            ElemBetweenFirstLastMax1 (List.removeAt 1 list) (maxIndex-1) (List.append resultList [a])
                                            //maxIndex-1 так как из list удалился элемент до него, т.е. он сместился влево
                              else resultList
        |head :: tail -> resultList
    ElemBetweenFirstLastMax1 list (List.findIndexBack (fun x-> x = (List.max list)) list) []
   


    


[<EntryPoint>]
let main argv =
    
    let list = Program.ReadData

    Program.WriteList list
    Program.WriteList (ElemBetweenFirstLastMax list)
    

    0 