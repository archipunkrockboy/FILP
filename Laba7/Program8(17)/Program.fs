open System
//17
let rec ReadList n = 
    if n=0 then []
    else
        let Head = Console.ReadLine() |> Convert.ToDouble
        let Tail = ReadList (n-1)
        Head::Tail

let rec WriteList = function
    | [] -> ()
    | head::tail -> 
        printf "%O " head
        WriteList tail
//обработка цифр отдельного числа
let rec f2 elem (frequencyList: 'a list) = 
    if elem = 0 then frequencyList
    else 
        f2 (elem/10) (List.mapi(fun i x-> if i=Convert.ToInt32(elem)%10 then x+1 else x) frequencyList)

//сколько раз встречается каждая цифра
let rec f1 (list: float list) frequencyList = 
    match list with 
    []->frequencyList
    |head :: tail-> f1 tail (List.map2 (fun x y->x+y) frequencyList (f2 (Convert.ToInt32(head)) (List.init 10 (fun x->0))))


let BuildFrequencyList (list: float list) = 
    let a = List.init 10 (fun x->0)
    f1 list a

//получаем среднее арифметическое из подхнодящих цифр
let f3 elem frequencyList = 
    let rec f33 (elem: float) (frequencyList: int list) (result: float) count = 
        if Convert.ToInt32(elem) = 0 then
            if count = 0 then 0.0 
            else result/(Convert.ToDouble(count))
        else 
            //проверяем  цифру elem%10 на то, встречается ли она чаще чем половина всех оставшихся
            if ((List.fold (fun acc x -> if (x > frequencyList[Convert.ToInt32(elem)%10]) then acc+1 else acc+0) 0 frequencyList) < 4) then f33 (Convert.ToDouble((Convert.ToInt32(elem))/10)) frequencyList (result+(Convert.ToDouble(Convert.ToInt32(elem)%10))) (count+1)
            else f33 (Convert.ToDouble((Convert.ToInt32(elem))/10)) frequencyList result count 
    f33 elem frequencyList 0.0 0

//строим список из средних арифметических 
let Condition (list: float list) = 
    let rec Condition1 (list: float list) n currentIndex resultList = 
        if currentIndex = n then List.filter (fun x->x<>0.0) resultList 
        else 
            Condition1 list n (currentIndex+1) (resultList@[f3 (Convert.ToInt32(list[currentIndex])) (BuildFrequencyList list)])
    Condition1 list (List.fold(fun acc x->acc+1) 0 list) 0 [] 
        
    
[<EntryPoint>]
let main argv = 
    
    printfn "Кол-во элементов:"
    let cnt = Console.ReadLine() |> Convert.ToInt32
    printfn "Список:"
    let list = ReadList cnt
    WriteList(list)
    Console.WriteLine("\nЧастота: ")
    WriteList (BuildFrequencyList list)
    Console.WriteLine("\nРезультирующий лист: ")
    WriteList(Condition list)
    0
