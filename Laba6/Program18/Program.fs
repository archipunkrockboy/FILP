open System

let FirstMin (list: 'a list) = 
    let rec FirstMin1 (list: 'a list) minElem minIndex currentIndex= 
        match list with 
        []->(minElem, minIndex)

        |head::tail-> if head < minElem then                       
                        FirstMin1 tail head currentIndex (currentIndex+1)
                      else
                        FirstMin1 tail minElem minIndex (currentIndex+1)
    FirstMin1 list list.Head 0 0

//элементы списка до N
let ElemBeforeN (list: 'a list) n = 
    let rec ElemBeforeN1 (list: 'a list) n currentIndex resultList = 
        if currentIndex = n then resultList
        else
            ElemBeforeN1 list.Tail n (currentIndex+1) (resultList@[list.Head])
    ElemBeforeN1 list n 0 []

[<EntryPoint>]
let main argv =
    
    let list = Program.ReadData
    Program.WriteList(list)
    Console.WriteLine(FirstMin list)
    

    Program.WriteList (ElemBeforeN list (snd(FirstMin list))) //в скобках второй элемент кортежа, т.е. индекс первого минимума в списке
    
    0