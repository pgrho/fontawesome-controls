namespace Shipwreck.FontAwesomeControls.Demo.Maui;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFontAwesome();
            });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
