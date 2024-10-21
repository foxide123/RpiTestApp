using RpiTestApp.Services.Implementations.ErrorHandler;

namespace RpiTestApp.Services
{
    public interface IErrorHandler
    {
        void HandleError(StatusMessageModel statusMessageModel);
    }

    public class StatusMessageModel
    {
    }
}