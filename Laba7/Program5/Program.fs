open System

//48

//самый часто встречающийся элемент list
let MaxFrequencyElem list = 
    let rec MaxFrequencyElem1 list maxElem maxCount = 
        match list with 
        []-> maxElem
        |head :: tail -> if List.fold (fun acc elem -> if elem = head then acc+1 else acc+0) 0 list > maxCount//если частота встречи head > maxCount 
                            then MaxFrequencyElem1 tail head (List.fold (fun acc elem -> if elem = head then acc+1 else acc+0) 0 list)
                         else MaxFrequencyElem1 tail maxElem maxCount
    MaxFrequencyElem1 list list[0] 0


//индексы самого часто встречающегося элемента массива
let MaxFrequencyElemIndexes list = 
    List.filter (fun x->x<>(-1)) (List.mapi (fun i x -> if x = (MaxFrequencyElem list) then i else -1 ) list)
    
    


[<EntryPoint>]
let main argv = 
    
    let list = Program.ReadData
    Program.WriteList list
    Console.WriteLine(MaxFrequencyElem list)
    Program.WriteList(MaxFrequencyElemIndexes list)

    0
