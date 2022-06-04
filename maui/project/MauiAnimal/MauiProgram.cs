using Comet;

namespace MauiAnimal;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			// .UseMauiApp<App>()
			.UseCometApp<AnimalApp>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		return builder.Build();
	}
}

public class AnimalApp : Comet.CometApp {
	[Body]
	Comet.View view() => new AnimalView();
}