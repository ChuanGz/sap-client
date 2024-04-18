using Microsoft.Extensions.Options;
using RestSharp;
using Sap.B1Client.Services;
using Sap.B1Client.System.Interfaces;
using Sap.B1Client.System.Models;

namespace Sap.B1Client.Adapters;

public class B1OrderAdapter : B1OrderService, IB1Client, IB1Document
{
    public B1OrderAdapter(IOptions<ConfigOptionModel> options) : base(options)
    {
    }

    public RestResponse AddNew(object entity)
    {
        return AddNewDocument(entity);
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

    public RestResponse Cancel(string id)
    {
        return CancelDocument(id);
    }

    public RestResponse Close(string id)
    {
        return CloseDocument(id);
    }
}