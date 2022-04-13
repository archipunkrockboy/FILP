open System
let rec ReadList n = 
    if n=0 then []
    else
        let Head = Console.ReadLine()
        let Tail = ReadList (n-1)
        Head::Tail

let rec WriteList = function
    | [] -> ()
    | head::tail -> 
        printf "%O " head
        WriteList tail

//средний вес строки
let AverageWeight str = 
    let rec AverageWeight1 (str:string) (currentIndex: int) (sum: int) = 
        if currentIndex = str.Length then (Convert.ToDouble(sum))/Convert.ToDouble(str.Length)
        else AverageWeight1 str (currentIndex+1) (sum + Convert.ToInt32(str[currentIndex]))
    AverageWeight1 str 0 0

//сортировка строк по среднему весу
let Method1 (strList: string list) = 
    List.sortBy(fun x -> AverageWeight x) strList

//возвращает 3 подряд идущих символа строки, средний вес которых максимально близок к среднему весу всей строки
let MaxAverageWeight3 (str: string) = 
    let rec MaxAverageWeight31 (str: string) currentIndex currentMaxAverage maxAverageStr = 
        if currentIndex+2 = str.Length then maxAverageStr
        else 
            if abs((AverageWeight str)-(AverageWeight str[currentIndex .. currentIndex+2])) < currentMaxAverage then 
                MaxAverageWeight31 str (currentIndex+1) (abs((AverageWeight str)-(AverageWeight str[currentIndex .. currentIndex+2]))) str[currentIndex .. currentIndex+2]
            else  MaxAverageWeight31 str (currentIndex+1) currentMaxAverage maxAverageStr
    MaxAverageWeight31 str 0 (AverageWeight str) ""

let Method2 (strList: string list) = 
    List.sortBy(fun x -> (AverageWeight x - AverageWeight (MaxAverageWeight3 x) * (AverageWeight (MaxAverageWeight3 x) - AverageWeight x))) strList
   
   
[<EntryPoint>]
let main argv = 
    
    printfn "Кол-во элементов:"
    let cnt = Console.ReadLine() |> Convert.ToInt32
    printfn "Список:"
    let list = ReadList cnt
    
    0