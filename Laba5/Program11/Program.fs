open System


let f = function
    | "f#" | "prolog"       -> "Подлиза!"
    | "java"                -> "Серьёзный дядя"
    | "r"                   -> "эээёёёёр"
    | "python"              -> "Я спрашивал про язык программирования"
    | "c++"| "c#"           -> "Красавчик"
    | "pascal"| "pascalabc" -> "Поздравляю, вы прошли программирование"
    | "русский"             -> "Хороший выбор!"
    | _                     -> "Ну ты и выдал"

[<EntryPoint>]
let main argv =
    
    Console.WriteLine("Ваш любимый язык программирования?")
    let lang = Console.ReadLine().ToLower()
    Console.WriteLine(f lang)
 
    0 