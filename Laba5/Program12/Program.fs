open System
[<EntryPoint>]

let main argv =
    let lower (s: string) = s.ToLower()
    let compareAnswer (s: string) =
        match s with
        | "f#" | "prolog"       -> "Подлиза!"
        | "java"                -> "Серьёзный дядя"
        | "r"                   -> "эээёёёёр"
        | "python"              -> "Я спрашивал про язык программирования"
        | "c++"| "c#"           -> "Красавчик"
        | "pascal"| "pascalabc" -> "Поздравляю, вы прошли программирование"
        | "русский"             -> "Хороший выбор!"
        | _                     -> "Ну ты и выдал"  
    //12.1
    printfn("Ваш любимый язык программирования?")
    (Console.ReadLine >> lower >> compareAnswer>> Console.WriteLine)()
    //12.2
    printfn("Ваш любимый язык программирования?")
    let result answer func out = out(func(answer()))
    result Console.ReadLine compareAnswer Console.WriteLine
    
    0 
