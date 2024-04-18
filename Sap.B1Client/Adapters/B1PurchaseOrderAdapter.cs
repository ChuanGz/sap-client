using Microsoft.Extensions.Options;
using RestSharp;
using Sap.B1Client.System.Interfaces;
using Sap.B1Client.System.Models;

namespace Sap.B1Client.B1PurchaseOrder
{
    public class B1PurchaseOrderAdapter : B1PurchaseOrderService, IB1Client
    {
        public B1PurchaseOrderAdapter(IOptions<ConfigOptionModel> options) : base(options)
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
}