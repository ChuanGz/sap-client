using Microsoft.Extensions.Options;
using RestSharp;
using Sap.B1Client.System.Interfaces;
using Sap.B1Client.System.Models;

namespace Sap.B1Client.B1BusinessPartner
{
    public class B1BusinessPartnerAdapter : B1BusinessPartnerService, IB1Client
    {
        public B1BusinessPartnerAdapter(IOptions<ConfigOptionModel> options) : base(options)
        {
        }

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
}