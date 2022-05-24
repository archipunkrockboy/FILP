open System
open System.Windows.Forms
open System.Drawing
open System.IO





let f x = 
    match x with
    | "f#" | "prolog"       -> "Подлиза!"
    | "java"                -> "Серьёзный дядя"
    | "r"                   -> "эээёёёёр"
    | "python"              -> "Я спрашивал про язык программирования"
    | "c++"| "c#"           -> "Красавчик"
    | "pascal"| "pascalabc" -> "Поздравляю, вы прошли программирование"
    | "русский"             -> "Хороший выбор!"
    | _                     -> "Ну ты и выдал"


let form = new Form(Width=400, Height = 400, Text = "F# main form", Menu = new MainMenu())//создал форму

let TextBox1= new TextBox(Top= 50,Width =300,Height = 300)//создал текстбокс
form.Controls.Add(TextBox1)//добавил текстбокс на форму form

let TextBox2= new TextBox(Top= 100,Width =300,Height = 300)//создал текстбокс
form.Controls.Add(TextBox2)//добавил текстбокс на форму form

let Button1 = new Button(Text="добавить",Top=140,Width=200,Height=30)
form.Controls.Add(Button1)

let ClickButton click1 = 
    TextBox2.Text <- f TextBox1.Text
    TextBox1.Clear()

let click1 = Button1.Click.Add(ClickButton)
Application.Run(form)

