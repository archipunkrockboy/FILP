open System


let CloselyToX (list: 'a list) x = 
    let rec CloselyToX (list: 'a list) x minDifference elem = 
        match list with
        []-> elem
        |head :: tail-> if abs(head - x) < minDifference then CloselyToX tail x (abs(head - x)) head 
                        else CloselyToX tail x minDifference elem
    CloselyToX list x list.Head list.Head

[<EntryPoint>]
let main argv =
   
   let list = Program.ReadData2

   Console.WriteLine(CloselyToX list 5.0)
   
   0