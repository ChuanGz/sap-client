using Microsoft.Extensions.Options;
using RestSharp;
using Sap.B1Client.B1BusinessPlace;
using Sap.B1Client.System.Interfaces;
using Sap.B1Client.System.Models;

namespace Sap.B1Client.Adapters;

public class B1BusinessPlaceAdapter : B1BusinessPlaceService, IB1Client
{
    public B1BusinessPlaceAdapter(IOptions<ConfigOptionModel> options) : base(options)
    {
    }

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