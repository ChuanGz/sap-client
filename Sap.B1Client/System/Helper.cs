using System.Text;
using Microsoft.Extensions.Options;
using Sap.B1Client.System.Models;

namespace Sap.B1Client.System;

public static class SAPHelper
{
    public static IOptions<ConfigOptionModel> BuildB1Option(string serviceRootUrl, string serviceDB, string serviceUserName, string servicePassword)
    {
        return Options.Create(new ConfigOptionModel()
        {
            Host = serviceRootUrl,
            ConnectionTimeout = -1,
            Credentials = new CredentialModel()
            {
                CompanyDB = serviceDB,
                UserName = serviceUserName,
                Password = servicePassword
            }
        });
    }

    public static string OutputLogBuilder(string scope_module, string scope_function, string app_route, string final_mess)
    {
        StringBuilder logSentence = new StringBuilder();
        logSentence.Append($"Module {scope_module}");
        logSentence.Append("---");
        logSentence.Append($"Function {scope_function}");
        logSentence.Append("---");
        logSentence.Append($"Route {app_route}");
        logSentence.Append("---");
        logSentence.Append($"Message {final_mess}");
        return logSentence.ToString();
    }

    public static string OutputLogBuilder(string scope_function, string final_mess)
    {
        StringBuilder logSentence = new StringBuilder();
        logSentence.Append($"Function {scope_function}");
        logSentence.Append("---");
        logSentence.Append($"Message {final_mess}");
        return logSentence.ToString();
    }
}