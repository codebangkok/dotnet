using Comet;

namespace MauiAnimal;

public class AnimalView : Comet.View {
    Animals animals = new Animals();

    [Body]
    Comet.View body() => new NavigationView {
        new ListView<Animal>(animals) {
            ViewFor = (animal) => new HStack(Microsoft.Maui.Primitives.LayoutAlignment.Start, spacing: 2) {
                new Comet.Image(animal.Image)
                    .Frame(100, 100)
                    .ClipShape(new Circle()),

                new VStack(Microsoft.Maui.Primitives.LayoutAlignment.Start, spacing: 2) {
                    new Text(animal.Name)
                        .Color(Colors.Black)
                        .FontSize(25)
                        .FontWeight(FontWeight.Bold),

                    new Text(animal.Description)
                        .Color(Colors.Grey)
                        .FontSize(16),                    
                }
            }.Padding(10)
        }.OnSelectedNavigate((animal) => new MyView(animal))
    };
}