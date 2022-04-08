open System

//18

let SimmetrRazn list1 list2 = 
    let rec SimmetrRazn1 list1 list2 resultList = 
        if (list1 = [] && list2 = []) then resultList
        else 
            if List.f

let main argv = 


    let list1 = Program.ReadData
    let list2 = Program.ReadData
    Program.WriteList(SimmetrRazn list1 list2)


    0

