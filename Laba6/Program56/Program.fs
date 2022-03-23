open System

let IsPrime x = 
    let rec IsPrime1 x currentDivider = 
        if currentDivider = 1 then true
        elif x%currentDivider = 0 then false
        else IsPrime1 x (currentDivider-1)
    IsPrime1 x (x-1)


   //среднее арифметическое простых элементов списка
let ArithmeticMeanPrime (list: 'a list) = 
      let rec ArithmeticMeanPrime1 (list: 'a list) sum count = 
          match list with
          []-> if count = 0 then 0
               else sum/count
          |head :: tail-> if IsPrime head then ArithmeticMeanPrime1 tail (sum+head) (count+1)
                          else ArithmeticMeanPrime1 tail sum count
      ArithmeticMeanPrime1 list 0 0


let ArithmeticMeanWithCondition (list: 'a list) condition = 
      let rec ArithmeticMeanWithCondition1 (list: 'a list) sum count condition = 
          match list with
          []-> if count = 0 then 0
               else sum/count
          |head :: tail-> if not(IsPrime head) && head > condition then ArithmeticMeanWithCondition1 tail (sum+head) (count+1) condition
                          else ArithmeticMeanWithCondition1 tail sum count condition
      ArithmeticMeanWithCondition1 list 0 0 condition
[<EntryPoint>]
let main argv =
    

    let list = Program.ReadData
    
    Program.WriteList list 
    //Console.WriteLine(ArithmeticMeanPrime list)
    Console.WriteLine(ArithmeticMeanWithCondition list (ArithmeticMeanPrime list))
    0