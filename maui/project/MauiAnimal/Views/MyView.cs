using Comet;

namespace MauiAnimal;

public class MyView : Comet.View {

    Animal animal;

    public MyView()
    {
        
    }

    public MyView(Animal animal)
    {
        this.animal = animal;
    }

    [Body]
    Comet.View body() => new VStack{
        new Text(animal.Name)
            .FontSize(30)
            .FontWeight(FontWeight.Bold),
        
        new Comet.Image(animal.Image)
            .Frame(200, 200)
            .ClipShape(new Circle())
    }.Padding(20);
}