open System
open System.Windows.Forms
open System.Drawing
open System.IO

let ReadArray n =
    let rec read n arr = 
        match n with 
        |0 -> arr
        |_->
            let newEl=Console.ReadLine()|>Convert.ToInt32
            let newArr = Array.append arr [|newEl|]
            read (n-1) newArr
    read n [||]

let WriteArray arr = 
    printfn "%A" arr

let SimmetrRazn (arr1: string array) (arr2: string array) = 
    Array.append (Array.fold (fun acc elem1 -> if (Array.tryFind (fun y -> y = elem1) arr2) <> None then (Array.append acc [||]) else Array.append acc [|elem1|])  [||] arr1) (Array.fold (fun acc elem2 -> if (Array.tryFind (fun y -> y = elem2) arr1) <> None then (Array.append acc [||]) else Array.append acc [|elem2|])  [||] arr2)
     

let form = new Form(Width=1000, Height = 600, Text = "F# main form", Menu = new MainMenu())//создал форму

let TextBox1= new TextBox(Top= 50,Width =300,Height = 300)//создал текстбокс
form.Controls.Add(TextBox1)//добавил текстбокс на форму form
let TextBox2= new TextBox(Top= 100,Width =300,Height = 300)//создал текстбокс
form.Controls.Add(TextBox2)//добавил текстбокс на форму form
let TextBox3= new TextBox(Top= 150,Width =300,Height = 300)//создал текстбокс
form.Controls.Add(TextBox3)//добавил текстбокс на форму form



let Button1 = new Button(Text="добавить",Top=250,Width=200,Height=30)
form.Controls.Add(Button1)


let ClickButton click1 = 
    let a = (TextBox1.Text).Split( [|','|])
    let b = (TextBox2.Text).Split( [|','|]) 
    let rec ArrayToString (arr:string []) i acc:string =
            if (i = arr.Length) then acc
            else ArrayToString arr (i+1) (acc + "," + arr.[i])
    let result = SimmetrRazn a b
    let output = (ArrayToString result 0 "")
    TextBox3.Text <-  output.[1..]
let click1 = Button1.Click.Add(ClickButton)
Application.Run(form)