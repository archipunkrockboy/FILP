open System

let DividersProcessing x f init = 
    let rec DividersProcessing1 x f init currentDivider = 
        if currentDivider = 0 then init
        else 
            if x % currentDivider = 0 then 
                let newInit = f init currentDivider 
                let newDivider = currentDivider - 1
                DividersProcessing1 x f newInit newDivider
            else  
                let newDivider = currentDivider - 1
                DividersProcessing1 x f init newDivider
    DividersProcessing1 x f init x




[<EntryPoint>]
let main argv =
    

    Console.WriteLine(DividersProcessing 12 (fun x y -> x + y) 0)
    Console.WriteLine(DividersProcessing 12 (fun x y -> x * y) 1)
    0 