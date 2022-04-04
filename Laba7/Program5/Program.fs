open System

//48

//сколько x в list
let Frequency list x = 
    let rec Frequence list x count = 
        match list with 
        []->count
        |head :: tail -> if head = x then Frequence tail x (count+1)
                         else Frequence tail x count
    Frequence list x 0

//самый часто встрочающийся элемент list
let MaxFrequencyElem list = 
    let rec MaxFrequencyElem1 list maxElem maxCount = 
        match list with 
        []-> maxElem
        |head :: tail -> if Frequency list head > maxCount then 
                            MaxFrequencyElem1 tail head (Frequency list head)
                         else MaxFrequencyElem1 tail maxElem maxCount
    MaxFrequencyElem1 list list.Head (Frequency list list.Head)


//индексы самого часто встречающегося элемента массива
let MaxFrequencyElemIndexes list = 
    let rec MaxFrequencyElemIndexes1 list maxElem currentIndex resultList = 
        match list with
        [] -> resultList
        |head :: tail -> if head = maxElem then
                            MaxFrequencyElemIndexes1 tail maxElem (currentIndex+1)(List.append resultList [currentIndex]) 
                         else 
                            MaxFrequencyElemIndexes1 tail maxElem (currentIndex+1) resultList
    MaxFrequencyElemIndexes1 list (MaxFrequencyElem list) 0 []
 
[<EntryPoint>]
let main argv = 


    let list = Program.ReadData
    Program.WriteList list
    Console.WriteLine(Frequency list 5)
    Console.WriteLine(MaxFrequencyElem list)
    Program.WriteList(MaxFrequencyElemIndexes list)


    0
