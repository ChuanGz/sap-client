using RestSharp;

namespace Sap.B1Client.System.Interfaces;

public interface IB1Client
{
    RestResponse AddNew(object entity);

    RestResponse RetrieveAll(string requiredTemplate);

    RestResponse Retrieve(string id);

    RestResponse Alter(string id, object changeContent);
}