open System
open System.Windows
open System.Windows.Controls
open System.Windows.Markup
open System.Windows.Media.Imaging
//Главная форма
let mwXaml = " 
<Window 
xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation'
 xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'
 Title='F# WPF' Height='500' Width='500'>
 <Grid>
    <Grid.ColumnDefinitions>
        <ColumnDefinition Width='156*' />
        <ColumnDefinition Width='163' />
    </Grid.ColumnDefinitions>
 <GroupBox Header='[Добавление в список элементов:]' Height='400' HorizontalAlignment='Left' Name='groupBox1' VerticalAlignment='Top' Width='400' 
 Grid.ColumnSpan='2'>
  <Grid>
    <Grid.ColumnDefinitions>
        <ColumnDefinition Width='38*' />
        <ColumnDefinition Width='453*' />
    </Grid.ColumnDefinitions>
  
  <TextBox Height = '20' HorizontalAlignment = 'Left' Margin = '30,-170,0,0' Name = 'textBox1' Width = '250' Grid.ColumnSpan='2' />
  
  <ListBox Height = '200' HorizontalAlignment = 'Left' Margin = '30,100,0,0' Name = 'listBox1' Width = '250' Grid.ColumnSpan='2' />
  </Grid>
  </GroupBox>
    <GroupBox Header='[Кнопки]' Height='92' HorizontalAlignment='Left' Margin='0,400,0,0' Name='groupBox2' VerticalAlignment='Top' 
Width='313' Grid.ColumnSpan='2'>
        <Grid>
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width='74*' />
                <ColumnDefinition Width='227' />
            </Grid.ColumnDefinitions>
 <Button Content='Добавить в список ' Height='23' HorizontalAlignment='Left' 
Margin='6,6,0,0' Name='button1' VerticalAlignment='Top' Width='138' 
Grid.ColumnSpan='2' />
 </Grid>
 </GroupBox>
 
 
 </Grid>
</Window>
" 
let getWindow(mwXaml) =
    let xamlObj=XamlReader.Parse(mwXaml)
    xamlObj :?> Window

let win = getWindow(mwXaml)

let TextBox1 = win.FindName("textBox1") :?> TextBox
let ListBox1 = win.FindName("listBox1") :?> ListBox
let Button1 = win.FindName("button1") :?> Button

let ClickButton click1 = 
    ListBox1.Items.Insert(0, TextBox1.Text)
    TextBox1.Clear()

let click1 = Button1.Click.Add(ClickButton)



[<STAThread>] ignore <| (new Application()).Run win 