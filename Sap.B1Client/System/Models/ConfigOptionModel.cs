namespace Sap.B1Client.System.Models;

public class ConfigOptionModel
{
    public required string Host { get; set; }
    public int ConnectionTimeout { get; set; } = -1;
    public required CredentialModel Credentials { get; set; }
}