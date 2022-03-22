open System
//находит первый максимум и его индекс
let FirstMax (list: 'a list) = 
    let rec FirstMin1 (list: 'a list) maxElem maxIndex currentIndex= 
        match list with 
        []->(maxElem, maxIndex)

        |head::tail-> if head > maxElem then                       
                        FirstMin1 tail head currentIndex (currentIndex+1)
                      else
                        FirstMin1 tail maxElem maxIndex (currentIndex+1)
    FirstMin1 list list.Head 0 0

//есть ли элемент х в списке
let rec InList (list: 'a list) x = 
    match list with 
    []->false
    |head::tail-> if head = x then true
                  else
                    InList tail x


//формирует список из чисел между а и b, за исключением чисел, встречающихся в list
let MissingNumbers list a b = 
    let rec MissingNumbers1 list a b currentNumber result = 
        if currentNumber = b then result
        else 
            if not(InList list currentNumber) then MissingNumbers1 list a b (currentNumber+1) (result @ [currentNumber])
            else MissingNumbers1 list a b (currentNumber+1) result
    MissingNumbers1 list a b (a+1) []

let f20 list = 
    MissingNumbers list (fst(Program.FirstMin list)) (fst(FirstMax list))


[<EntryPoint>]
let main argv =
    let list = Program.ReadData
    Program.WriteList (f20 list)

    
    0