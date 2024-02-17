using System;

namespace HotChocoErrorFilterGeneratorSample.WebApi;

public class ErrorAttribute : Attribute
{
    public ErrorAttribute(int errorCode, string errorMessage)
    {
        ErrorCode = errorCode;
        ErrorMessage = errorMessage;
    }

    public int ErrorCode { get; private set; }

    public string ErrorMessage { get; private set; }


}