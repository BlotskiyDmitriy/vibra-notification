using Vibra.Notification.ViewModels.SetupNotification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vibra.Notification.ViewModels.Extensions
{
    public static class ViewModelExtensions
    {
        public static MauiAppBuilder ConfigureViewModels(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<SetupNotificationViewModel>();

            return builder;
        }
    }
}
