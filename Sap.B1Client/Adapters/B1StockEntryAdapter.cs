using Microsoft.Extensions.Options;
using RestSharp;
using Sap.B1Client.Services;
using Sap.B1Client.System.Interfaces;
using Sap.B1Client.System.Models;

namespace Sap.B1Client.Adapters;

public class B1StockEntryAdapter(IOptions<ConfigOptionModel> options) : B1StockEntryService(options), IB1Client
{
    public RestResponse AddNew(object entity)
    {
        return AddNewStockEntry(entity);
    }

    public RestResponse RetrieveAll(string requiredTemplate)
    {
        return RetrieveAllStockEntry(requiredTemplate);
    }

    public RestResponse Retrieve(string id)
    {
        return RetrieveStockEntry(id);
    }

    public RestResponse Alter(string id, object changeContent)
    {
        return AlterStockEntry(id, changeContent);
    }

    public RestResponse Remove(string id, object changeContent)
    {
        return AlterStockEntry(id, changeContent);
    }

    public RestResponse Cancel(string id)
    {
        return RetrieveStockEntry(id);
    }

    public RestResponse Close(string id)
    {
        return RetrieveStockEntry(id);
    }
}