using Microsoft.Extensions.Options;
using RestSharp;
using Sap.B1Client.Services;
using Sap.B1Client.System.Interfaces;
using Sap.B1Client.System.Models;

namespace Sap.B1Client.Adapters;

public class B1StockExitAdapter(IOptions<ConfigOptionModel> options) : B1StockExitService(options), IB1Client
{
    public RestResponse AddNew(object entity)
    {
        return AddNewStockExit(entity);
    }

    public RestResponse RetrieveAll(string requiredTemplate)
    {
        return RetrieveAllStockExit(requiredTemplate);
    }

    public RestResponse Retrieve(string id)
    {
        return RetrieveStockExit(id);
    }

    public RestResponse Alter(string id, object changeContent)
    {
        return AlterStockExit(id, changeContent);
    }

    public RestResponse Remove(string id, object changeContent)
    {
        return AlterStockExit(id, changeContent);
    }

    public RestResponse Cancel(string id)
    {
        return RetrieveStockExit(id);
    }

    public RestResponse Close(string id)
    {
        return RetrieveStockExit(id);
    }
}