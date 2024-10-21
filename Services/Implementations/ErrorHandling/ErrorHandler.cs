using System;
using Serilog;

namespace RpiTestApp.Services.Implementations.ErrorHandler
{
	public class ErrorHandler : IErrorHandler
	{
		/*
		private readonly IStatusMessageService statusMessageService;

		public ErrorHandler(IStatusMessageService statusMessageService)
		{
			this.statusMessageService = statusMessageService;
		}
		*/

		public void HandleError(StatusMessageModel statusMessage)
		{
			ArgumentNullException.ThrowIfNull(statusMessage, nameof(statusMessage));

			//Log.Error("Exception triggered with message:{Message}", statusMessage.Message);

			//statusMessageService.ShowMessage(statusMessage);
		}
    }
}