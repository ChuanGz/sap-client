using RestSharp;

namespace Sap.B1Client.System.Interfaces;

public interface IB1Document
{
    RestResponse Cancel(string id);
    RestResponse Close(string id);
}
