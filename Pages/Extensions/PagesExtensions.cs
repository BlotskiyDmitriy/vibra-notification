using Vibra.Notification.Pages.SetupNotification;

namespace Vibra.Notification.Pages.Extensions
{
    public static class PagesExtensions
    {
        public static MauiAppBuilder ConfigurePages(this MauiAppBuilder builder)
        {
            // main tabs of the app
            builder.Services.AddSingleton<SetupNotificationPage>();

            // pages that are navigated to
            //builder.Services.AddTransient<LoginPage>();

            return builder;
        }
    }
}
