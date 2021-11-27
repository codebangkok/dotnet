using Comet;
using Microsoft.Maui;
using Microsoft.Maui.Graphics;

public class MyView : View {
    [State]
    readonly State<int> count = new State<int>();

    [Body]
    View body() => new VStack{
        new Text(
            () => $"Hello Maui {count.Value}"
        )
            .FontSize(20)
            .FontWeight(FontWeight.Bold),

        new Button(
            text: "Increment",
            clicked: () => count.Value++
        ),

        new Image("lion")
            .Frame(200,200)
            .ClipShape(new Circle())
    }.Padding(20);
}