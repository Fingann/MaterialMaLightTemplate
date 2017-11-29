using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notifications.Wpf;

namespace FingannTemplate.Services.Notification
{
    public class NotificationService : INotificationService
    {
        private readonly NotificationManager _notificationManager = new NotificationManager();


        public void Exception(
            Exception ex,
            string areaName = "WindowArea",
            TimeSpan? expirationTime = null,
            Action onClick = null,
            Action onClose = null)
        {

            var content = new NotificationContent
            {
                Title = ex.GetType().FullName,
                Message = ex.Message,
                Type = NotificationType.Error
            };
            _notificationManager.Show(content, areaName, expirationTime, onClick, onClose);
        }

        public void Info(
            string title,
            string message,
            string areaName = "WindowArea",
            TimeSpan? expirationTime = null,
            Action onClick = null,
            Action onClose = null)
        {
            var content = new NotificationContent
            {
                Title = title,
                Message = message,
                Type = NotificationType.Information
            };
            _notificationManager.Show(content, areaName, expirationTime, onClick, onClose);
        }

        public void Warning(
            string title,
            string message,
            string areaName = "WindowArea",
            TimeSpan? expirationTime = null,
            Action onClick = null,
            Action onClose = null)
        {
            var content = new NotificationContent
            {
                Title = title,
                Message = message,
                Type = NotificationType.Warning
            };
            _notificationManager.Show(content, areaName, expirationTime, onClick, onClose);
        }

        public void Success(
            string title,
            string message,
            string areaName = "WindowArea",
            TimeSpan? expirationTime = null,
            Action onClick = null,
            Action onClose = null)
        {
            var content = new NotificationContent
            {
                Title = title,
                Message = message,
                Type = NotificationType.Success
            };
            _notificationManager.Show(content, areaName, expirationTime, onClick, onClose);
        }
    }
}
