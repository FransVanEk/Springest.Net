using System;
namespace Springest.Net
{
    public interface ISpringestApi
    {
        string ApiKey { get; set; }
        dataformat DataFormat { get; set; }
        string DataFormatString { get; }
        string Endpoint { get; set; }
        T GetCall<T>(string webApiUrl);
    }
}
