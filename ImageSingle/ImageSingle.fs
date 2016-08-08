namespace ImageSingle

open Xamarin.Forms

type App() = 
    inherit Application()
    let stack = StackLayout(VerticalOptions = LayoutOptions.Center)
    let image = Image(Aspect = Aspect.AspectFill)
    do 
        let imageSource = ImageSource.FromFile("icon.png")
        image.Source <- imageSource
        stack.Children.Add(image)
        base.MainPage <- ContentPage(Content = stack)