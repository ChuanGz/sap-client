using Microsoft.Extensions.Options;
using RestSharp;
using Sap.B1Client.Services;
using Sap.B1Client.System.Interfaces;
using Sap.B1Client.System.Models;

namespace Sap.B1Client.Adapters;

public class B1BusinessPlaceAdapter(IOptions<ConfigOptionModel> options) : B1BusinessPlaceService(options), IB1Client
{
    public RestResponse AddNew(object entity)
    {
        return AddNewBusinessPlace(entity);
    }

    public RestResponse RetrieveAll(string requiredTemplate)
    {
        return RetrieveAllBusinessPlace(requiredTemplate);
    }

    public RestResponse Retrieve(string id)
    {
        return RetrieveBusinessPlace(id);
    }

    public RestResponse Alter(string id, object changeContent)
    {
        return AlterBusinessPlace(id, changeContent);
    }
}