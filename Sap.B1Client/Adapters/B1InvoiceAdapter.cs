using Microsoft.Extensions.Options;
using RestSharp;
using Sap.B1Client.B1Invoice;
using Sap.B1Client.System.Interfaces;
using Sap.B1Client.System.Models;
using System.Threading.Tasks;

namespace Sap.B1Client.Adapters;

public class B1InvoiceAdapter : B1InvoiceService, IB1Client
{
    public B1InvoiceAdapter(IOptions<ConfigOptionModel> options) : base(options)
    {
    }

    public RestResponse RetrieveAll(string requiredTemplate)
    {
        return RetrieveAllDocument(requiredTemplate);
    }

    public RestResponse Retrieve(string id)
    {
        return RetrieveDocument(id);
    }

    public RestResponse Alter(string id, object changeContent)
    {
        return AlterDocument(id, changeContent);
    }

    RestResponse IB1Client.AddNew(object entity)
    {
        return AddNewDocument(entity);
    }
}