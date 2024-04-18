using Microsoft.Extensions.Options;
using RestSharp;
using Sap.B1Client.B1UnitOfMeasurement;
using Sap.B1Client.System.Interfaces;
using Sap.B1Client.System.Models;

namespace Sap.B1Client.Adapters;

public class B1UnitOfMeasurementAdapter : B1UnitOfMeasurementService, IB1Client
{
    public B1UnitOfMeasurementAdapter(IOptions<ConfigOptionModel> options) : base(options)
    {
    }

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