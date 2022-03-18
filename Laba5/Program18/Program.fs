open System 

//сумма цифр числа, делящихся на 3
let Sum3 x = 
    let rec Sum3 x sum = 
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



[<EntryPoint>]
let main argv =
    
    Console.WriteLine(Program.EulerNumber 20)//18.1
    Console.WriteLine(Sum3 133692)//18.2
    0 