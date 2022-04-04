open System

//можно ли представить элемент списка как сумма двух других
let FormElem (list: 'a list) elem = 
    let rec FormElem1 (list: 'a list) elem (list1: 'a list) n= 
        if list1.Length = n then false
        else 
            let x = List.tryFind (fun x -> x + list.Head = elem) list1 //ищем  элемент в list1 такой, что даёт в сумме с list.Head искомый элемент
            if x <> None then true
            else FormElem1 list.Tail elem (list1@[list.Head]) n
    FormElem1 list elem [] list.Length

//количество таких элементов
let CountElem (list: 'a list) = 
    let rec CountElem1 (list: 'a list) count currentIndex = 
        if currentIndex = list.Length then count
        else 
            if FormElem list list.[currentIndex] then CountElem1 list (count+1) (currentIndex+1)
            else CountElem1 list count (currentIndex+1)
    CountElem1 list 0 0



[<EntryPoint>]
let main argv = 

    let list = Program.ReadData

    Program.WriteList list

    Console.WriteLine(CountElem list)


    0