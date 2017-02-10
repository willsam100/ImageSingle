namespace ImageSingle

open Xamarin.Forms
open System

type App() as this = 
    inherit Application()

    let stack = StackLayout(VerticalOptions = LayoutOptions.Center)
    let label = Label(Text = "Image", FontSize = 40.)
    let image = Image(Aspect = Aspect.AspectFit, BackgroundColor = Color.White, Source = ImageSource.FromFile("simple.png"))
    do 
        stack.Children.Add(label)
        stack.Children.Add(image)
        this.MainPage <- ContentPage(Content = stack)