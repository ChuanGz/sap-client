using Microsoft.Extensions.Options;
using RestSharp;
using Sap.B1Client.B1SalesPerson;
using Sap.B1Client.System.Interfaces;
using Sap.B1Client.System.Models;

namespace Sap.B1Client.Adapters;

public class B1SalesPersonAdapter : B1SalesPersonService, IB1Client
{
    public B1SalesPersonAdapter(IOptions<ConfigOptionModel> options) : base(options)
    {
    }

    public RestResponse AddNew(object entity)
    {
        return AddNewSalesPerson(entity);
    }

    public RestResponse RetrieveAll(string requiredTemplate)
    {
        return RetrieveAllSalesPerson(requiredTemplate);
    }

    public RestResponse Retrieve(string id)
    {
        return RetrieveSalesPerson(id);
    }

    public RestResponse Alter(string id, object changeContent)
    {
        return AlterSalesPerson(id, changeContent);
    }
}