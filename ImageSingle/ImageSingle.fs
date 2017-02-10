namespace ImageSingle

open Xamarin.Forms
open System

type App() as this = 
    inherit Application()

    let stack = StackLayout(VerticalOptions = LayoutOptions.Center)
    let image = Image(Aspect = Aspect.AspectFit, Source = ImageSource.FromFile("simple.png"))
    do 
        stack.Children.Add(image)
        this.MainPage <- ContentPage(Content = stack)