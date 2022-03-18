open System

let DividersProcessingWithCondition x f predicate init = 
    let rec DividersProcessingWithCondition1 x f predicate init currentDivider = 
        if currentDivider = 0 then init
        else 
            if x % currentDivider = 0 && predicate currentDivider then 
                let newInit = f init currentDivider 
                let newDivider = currentDivider - 1
                DividersProcessingWithCondition1 x f predicate newInit newDivider
            else  
                let newDivider = currentDivider - 1
                DividersProcessingWithCondition1 x f predicate init newDivider
    DividersProcessingWithCondition1 x f predicate init x


let PrimeNumberProcessingWithCondition x f predicate init = 
    let rec PrimeNumberProcessingWithCondition1 x f predicate init current = 
        if current = 0 then init
        else
            let newInit = if Program.NOD x current = 1 && predicate current then f init current
                          else init
            let newCurrent = current - 1
            PrimeNumberProcessingWithCondition1 x f predicate newInit newCurrent
    PrimeNumberProcessingWithCondition1 x f predicate init x


[<EntryPoint>]
let main argv =
    
    Console.WriteLine(DividersProcessingWithCondition 12 (fun x y -> x + y) (fun x -> x%2  = 0) 0)//сумма чётных делителей числа
    Console.WriteLine(PrimeNumberProcessingWithCondition 33 (fun x y -> x + y) (fun x -> x%10 = 1) 0)//сумма взаимнопростых элементов, последняя цифра которых 1
    0 