using Microsoft.Extensions.Logging;
using Vibra.Notification.Pages.Extensions;
using Vibra.Notification.Servces.Extensions;
using Vibra.Notification.ViewModels.Extensions;

namespace Vibra.Notification;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .ConfigureViewModels()
            .ConfigurePages()
            .ConfigureServices()
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
