using MathGameMaui.Data;

namespace MathGameMaui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("2Dumb.ttf", "2DumbRegular");
			});

		string dbPath = Path.Combine(FileSystem.AppDataDirectory, "game.db");

		builder.Services.AddSingleton(s =>
		 ActivatorUtilities.CreateInstance<GameRepository>(s, dbPath));

		return builder.Build();
	}
}
