using Microsoft.Extensions.Options;
using RestSharp;
using Sap.B1Client.B1InventoryTransferRequest;
using Sap.B1Client.System.Interfaces;
using Sap.B1Client.System.Models;

namespace Sap.B1Client.Adapters;

public class B1StockTrsfRequestAdapter : B1StockTrsfRequestService, IB1Client
{
    public B1StockTrsfRequestAdapter(IOptions<ConfigOptionModel> options) : base(options)
    {
    }

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