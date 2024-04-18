using Microsoft.Extensions.Options;
using RestSharp;
using Sap.B1Client.B1StockEntry;
using Sap.B1Client.System.Interfaces;
using Sap.B1Client.System.Models;

namespace Sap.B1Client.Adapters;

public class B1StockEntryAdapter : B1StockEntryService, IB1Client
{
    public B1StockEntryAdapter(IOptions<ConfigOptionModel> options) : base(options)
    {
    }

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