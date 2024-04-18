using Microsoft.Extensions.Options;
using RestSharp;
using Sap.B1Client.Services;
using Sap.B1Client.System.Interfaces;
using Sap.B1Client.System.Models;

namespace Sap.B1Client.Adapters;

public class B1BusinessPartnerAdapter(IOptions<ConfigOptionModel> options) : B1BusinessPartnerService(options), IB1Client
{
    public RestResponse AddNew(object entity)
    {
        return AddNewBusinessPartner(entity);
    }

    public RestResponse RetrieveAll(string requiredTemplate)
    {
        return RetrieveAllBusinessPartner(requiredTemplate);
    }

    public RestResponse Retrieve(string id)
    {
        return RetrieveBusinessPartner(id);
    }

    public RestResponse Alter(string id, object changeContent)
    {
        return AlterBusinessPartner(id, changeContent);
    }
}