open System

//19

let Method1 (str: string) = 
    let strLow = String.filter (fun x -> (Char.IsLower x)) str
    let sortList=Seq.toList(strLow)
    let result = List.map2(fun elem1 elem2-> elem1 <=elem2) sortList.[0..sortList.Length-2] sortList.[1..sortList.Length-1] 
    if (List.fold (fun acc x-> if x=false then acc + 1 else acc) 0 result) = 0 then "1"//Console.WriteLine("Строчные символы отсортированы")
    else "0"//Console.WriteLine("Строчные символы НЕ отсортированы")

let Method2 (str: string) = 
    Convert.ToString((String.filter(fun x -> x ='A') str).Length)

let FindLastBackSlashIndex str = 
    let rec findLastBackSlashIndex (str:string) currentIndex lastBackSlashIndex = 
        if currentIndex = str.Length then lastBackSlashIndex 
        else
            //92 - это \
            if (Convert.ToInt32(str[currentIndex])) = 92 then findLastBackSlashIndex str (currentIndex+1) currentIndex
            else findLastBackSlashIndex str (currentIndex+1) lastBackSlashIndex
    findLastBackSlashIndex str 0 0

let FindLastDotIndex str = 
    let rec findLastDotIndex (str:string) currentIndex lastDotIndex = 
        if currentIndex = str.Length then lastDotIndex 
        else
            if (Convert.ToString(str[currentIndex])) = "." then findLastDotIndex str (currentIndex+1) currentIndex
            else findLastDotIndex str (currentIndex+1) lastDotIndex
    findLastDotIndex str 0 0

let Method3 (str: string) = 
    str[(FindLastBackSlashIndex str)+1 .. (FindLastDotIndex str)-1]


let ChooseMethod n = function
    |1 -> Console.WriteLine("Введите строку: ")
          let str = Console.ReadLine()
          Method1 str
    |2 -> Console.WriteLine("Введите строку: ")
          let str = Console.ReadLine()
          Method2 str
    |_ -> Console.WriteLine("Введите строку: ")
          let str = Console.ReadLine()
          Method3 str

[<EntryPoint>]
let main argv = 
    //let str = "C:\Users\Артур\source\repos\FILP\FILP\Laba7\Program2\Program.fs"
    printfn "Выберите метод: "
    let n = Console.ReadLine() |> Convert.ToInt32
    Console.WriteLine(ChooseMethod n)
    0