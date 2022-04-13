open System

//19

let Method1 (str: string) = 
    let strLow = String.filter (fun x -> (Char.IsLower x)) str
    let sortList=Seq.toList(strLow)
    let result = List.map2(fun elem1 elem2-> elem1 <=elem2) sortList.[0..sortList.Length-2] sortList.[1..sortList.Length-1] 
    if (List.fold (fun acc x-> if x=false then acc + 1 else acc) 0 result) = 0 then Console.WriteLine("Строчные символы отсортированы")
    else Console.WriteLine("Строчные символы НЕ отсортированы")

let Method2 (str: string) = 
    (String.filter(fun x -> x ='A') str).Length


[<EntryPoint>]
let main argv = 

   
    0