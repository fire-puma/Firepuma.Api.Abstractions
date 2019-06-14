using System;

namespace Firepuma.Api.Abstractions.Errors
{
    public interface IErrorReportingService
    {
        void CaptureException(Exception exception);
        void CaptureWarning(string warningMsg);
    }
}
