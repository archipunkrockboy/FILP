[<EntryPoint>]


let main argv = 

    let list = Program.ReadData

    Program.WriteList list

    Console.WriteLine(CountElem list)


    0