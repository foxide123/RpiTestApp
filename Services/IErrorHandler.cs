using RpiTestApp.Services.Implementations.ErrorHandling

namespace RpiTestApp.Services
{
    public interface IErrorHandler
    {
        void HandleError(Status MessageModel statusMessageModel);
    }
}