using Microsoft.Extensions.Options;
using RestSharp;
using Sap.B1Client.Services;
using Sap.B1Client.System.Interfaces;
using Sap.B1Client.System.Models;

namespace Sap.B1Client.Adapters;

public class B1StockTrsfRequestAdapter(IOptions<ConfigOptionModel> options) : B1StockTrsfRequestService(options), IB1Client
{
    public RestResponse AddNew(object entity)
    {
        return AddNewStockTrsfRequest(entity);
    }

    public RestResponse RetrieveAll(string requiredTemplate)
    {
        return RetrieveAllStockTrsfRequest(requiredTemplate);
    }

    public RestResponse Retrieve(string id)
    {
        return RetrieveStockTrsfRequest(id);
    }

    public RestResponse Alter(string id, object changeContent)
    {
        return AlterStockTrsfRequest(id, changeContent);
    }
}