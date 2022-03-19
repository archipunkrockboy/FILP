open System 

//сумма цифр числа, делящихся на 3
let Sum3 x = 
    let rec Sum3 x sum  = 
        if x = 0 then sum
        else
            if x%10%3 = 0 then
                let sum1 = sum + x%10
                let x1 = x/10
                Sum3 x1 sum1
            else 
                let x1 = x/10
                Sum3 x1 sum
    Sum3 x 0

//подсчёт количества взаимнопростых чисел заданного числа с текущим делителем
let CountPrimeNumber x currentDivider = 
    let rec CountPrimeNumber1 x currentDivider count = 
        if x = 0 then count
        else 
            if Program.NOD (x%10) currentDivider = 1 then
                let x = x/10
                let count = count + 1
                CountPrimeNumber1 x currentDivider count
            else 
                let x = x/10
                CountPrimeNumber1 x currentDivider count
    CountPrimeNumber1 x currentDivider 0
//делитель, являющийся взаимнопростым с наибольшим количеством цифр заданного числа
let MaxPrimeNumber x = 
    let rec MaxPrimeNumber1 x currentDivider maxCount maxDivider = 
        if currentDivider = 0 then maxDivider
        else 
            if CountPrimeNumber x currentDivider > maxCount then
                let maxCount = CountPrimeNumber x currentDivider    
                let maxCount1 = maxCount
                let maxDivider = currentDivider
                let currentDivider1 = currentDivider - 1
                MaxPrimeNumber1 x currentDivider maxCount maxDivider
            else 
                let currentDivider1 = currentDivider - 1
                MaxPrimeNumber1 x currentDivider1 maxCount maxDivider
    MaxPrimeNumber1 x x 0 0

[<EntryPoint>]
let main argv =
    
    Console.WriteLine(Program.EulerNumber 20)//18.1
    Console.WriteLine(Sum3 133692)//18.2
    Console.WriteLine(MaxPrimeNumber 28)//18.3
    0 