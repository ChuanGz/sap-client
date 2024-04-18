using Microsoft.Extensions.Options;
using RestSharp;
using Sap.B1Client.System.Interfaces;
using Sap.B1Client.System.Models;

namespace Sap.B1Client.B1Warehouse
{
    public class B1WarehouseAdapter : B1WarehouseService, IB1Client
    {
        public B1WarehouseAdapter(IOptions<ConfigOptionModel> options) : base(options)
        {
        }

        public RestResponse AddNew(object entity)
        {
            return AddNewWarehouse(entity);
        }

        public RestResponse RetrieveAll(string requiredTemplate)
        {
            return RetrieveAllWarehouse(requiredTemplate);
        }

        public RestResponse Retrieve(string id)
        {
            return RetrieveWarehouse(id);
        }

        public RestResponse Alter(string id, object changeContent)
        {
            return AlterWarehouse(id, changeContent);
        }
    }
}