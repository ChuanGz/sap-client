using Microsoft.Extensions.Options;
using RestSharp;
using Sap.B1Client.Services;
using Sap.B1Client.System.Interfaces;
using Sap.B1Client.System.Models;

namespace Sap.B1Client.Adapters;

public class B1ItemAdapter(IOptions<ConfigOptionModel> options) : B1ItemService(options), IB1Client
{
    public RestResponse AddNew(object entity)
    {
        return AddNewItem(entity);
    }

    public RestResponse RetrieveAll(string requiredTemplate)
    {
        return RetrieveAllItem(requiredTemplate);
    }

    public RestResponse Retrieve(string id)
    {
        return RetrieveItem(id);
    }

    public RestResponse Alter(string id, object changeContent)
    {
        return AlterItem(id, changeContent);
    }
}