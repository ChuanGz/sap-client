using Microsoft.Extensions.Options;
using RestSharp;
using Sap.B1Client.Services;
using Sap.B1Client.System.Interfaces;
using Sap.B1Client.System.Models;

namespace Sap.B1Client.Adapters;

public class B1UnitOfMeasurementAdapter(IOptions<ConfigOptionModel> options) : B1UnitOfMeasurementService(options), IB1Client
{
    public RestResponse AddNew(object entity)
    {
        return AddNewUnitOfMeasurement(entity);
    }

    public RestResponse RetrieveAll(string requiredTemplate)
    {
        return RetrieveAllUnitOfMeasurement(requiredTemplate);
    }

    public RestResponse Retrieve(string id)
    {
        return RetrieveUnitOfMeasurement(id);
    }

    public RestResponse Alter(string id, object changeContent)
    {
        return AlterUnitOfMeasurement(id, changeContent);
    }
}