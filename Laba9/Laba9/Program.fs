open System
open System.Windows.Forms
open System.Drawing
open System.IO

let form = new Form(Width=1000, Height = 600, Text = "F# main form", Menu = new MainMenu())//создал форму

let TextBox1= new TextBox(Top= 50,Width =300,Height = 300)//создал текстбокс
form.Controls.Add(TextBox1)//добавил текстбокс на форму form

let Button1 = new Button(Text="добавить",Top=120,Width=200,Height=30)
form.Controls.Add(Button1)

let Narot = new TextBox(Text="",Top=200,Width=200,Height=300)
let Narot1 = new ListBox(Text="",Top=300,Width=200,Height=300)
form.Controls.Add(Narot1)



let ClickButton click1 = 
    Narot1.Items.Insert(0, TextBox1.Text)
    TextBox1.Clear()

let click1 = Button1.Click.Add(ClickButton)
Application.Run(form)