using Microsoft.Extensions.Options;
using RestSharp;
using Sap.B1Client.Services;
using Sap.B1Client.System.Interfaces;
using Sap.B1Client.System.Models;

namespace Sap.B1Client.Adapters;

public class B1WarehouseAdapter(IOptions<ConfigOptionModel> options) : B1WarehouseService(options), IB1Client
{
    public RestResponse AddNew(object entity)
    {
        return AddNewWarehouse(entity);
    }

    public RestResponse RetrieveAll(string requiredTemplate)
    {
        return RetrieveAllWarehouse(requiredTemplate);
    }

    public RestResponse Retrieve(string id)
    {
        return RetrieveWarehouse(id);
    }

    public RestResponse Alter(string id, object changeContent)
    {
        return AlterWarehouse(id, changeContent);
    }
}