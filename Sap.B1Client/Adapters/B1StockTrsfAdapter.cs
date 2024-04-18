using Microsoft.Extensions.Options;
using RestSharp;
using Sap.B1Client.Services;
using Sap.B1Client.System.Interfaces;
using Sap.B1Client.System.Models;

namespace Sap.B1Client.Adapters;

public class B1StockTrsfAdapter(IOptions<ConfigOptionModel> options) : B1StockTrsfService(options), IB1Client
{
    public RestResponse AddNew(object entity)
    {
        return AddNewStockTrsf(entity);
    }

    public RestResponse Alter(string id, object changeContent)
    {
        return AlterStockTrsf(id, changeContent);
    }

    public RestResponse RetrieveAll(string requiredTemplate)
    {
        return RetrieveAllStockTrsf(requiredTemplate);
    }

    public RestResponse Retrieve(string id)
    {
        return RetrieveStockTrsf(id);
    }

    public RestResponse Cancel(string id)
    {
        return RetrieveStockTrsf(id);
    }

    public RestResponse Close(string id)
    {
        return RetrieveStockTrsf(id);
    }
}