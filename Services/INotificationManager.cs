using RpiTestApp.Services.Implementations.Notifications

namespace RpiTestApp.Services
{
    public interface INotificationManager
    {
        void SendNotification();
        void ClearNotification();
        void DestroyService();
    }
}