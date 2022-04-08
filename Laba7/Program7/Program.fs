open System

//19

let LowIsOrdered str = 
    let rec LowIsOrdered1 (str: string) currentIndex = 
        if currentIndex+1 = str.Length then true
        else
            if Char.IsLower str.[0] then 
                if (Char.GetNumericValue  str.[currentIndex] < Char.GetNumericValue str[currentIndex+1] ) then
                    LowIsOrdered1 str (currentIndex+1)
                else false
            else LowIsOrdered1 str (currentIndex+1)
    LowIsOrdered1 str 0





[<EntryPoint>]
let main argv = 

    let s = "sdaasdasds"

    let x = Char.ConvertToUtf32 s 5

    0