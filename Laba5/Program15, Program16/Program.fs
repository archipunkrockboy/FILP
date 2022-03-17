open System

let NOD x y =
    let rec NOD1 x y i currentNOD= 
        if x+1 = i || y+1 = i then currentNOD
        else 
            if x%i <> 0 || y%i <> 0 then NOD1 x y (i+1) currentNOD
            else 
                let nod = i
                NOD1 x y (i+1) nod
    NOD1 x y 1 1

let PrimeNumberProcessing x f init = 
    let rec PrimeNumberProcessing1 x f init current = 
        if current = 0 then init
        else
            let newInit = if NOD x current = 1 then f init current
                          else init
            let newCurrent = current - 1
            PrimeNumberProcessing1 x f newInit newCurrent
    PrimeNumberProcessing1 x f init x

let EulerNumber x = 
    PrimeNumberProcessing x (fun x y-> x + 1) 0


[<EntryPoint>]
let main argv =
    
    Console.WriteLine(PrimeNumberProcessing 25 (fun x y -> x + y) 0)
    Console.WriteLine(PrimeNumberProcessing  6 (fun x y -> x * y) 1)
    Console.WriteLine(EulerNumber 10)
    0 