namespace Vibra.Notification.Servces.Extensions
{
    public static class ServiceExtensions
    {
        public static MauiAppBuilder ConfigureServices(this MauiAppBuilder builder)
        {
            //builder.Services.AddSingleton<ILogService, LogService>();

            return builder;
        }
    }
}
