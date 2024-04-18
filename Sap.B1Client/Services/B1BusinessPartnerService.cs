using Microsoft.Extensions.Options;
using RestSharp;
using Sap.B1Client.System.Abstracts;
using Sap.B1Client.System.Constants;
using Sap.B1Client.System.Models;

namespace Sap.B1Client.B1BusinessPartner
{
    public class B1BusinessPartnerService(IOptions<ConfigOptionModel> options) : B1ClientBase(options)
    {
        public RestResponse AddNewBusinessPartner(object entity)
        {
            // _request = new RestRequest(Constant.B1S_Path_BusinessPartner, Method.Post);
            _request.Resource = Constant.B1S_Path_BusinessPartner;
            _request.Method = Method.Post;
            _request.AddHeader(Constant.B1S_Label_Cookie, _hCookieString);
            _request.AddJsonBody(entity);

            _response = _client.Execute(_request);
            return _response;
        }

        public RestResponse RetrieveAllBusinessPartner(string requiredTemplate)
        {
            // _request = new RestRequest(Constant.B1S_Path_BusinessPartner + requiredTemplate, Method.Get);
            _request.Resource =Constant.B1S_Path_BusinessPartner + requiredTemplate;
            _request.Method = Method.Get;
            _request.AddHeader(Constant.B1S_Label_Cookie, _hCookieString);

            _response = _client.Execute(_request);
            return _response;
        }

        public RestResponse RetrieveBusinessPartner(string identity)
        {
            // _request = new RestRequest(string.Format(Constant.B1S_Path_BusinessPartner + Constant.B1S_SID, identity), Method.Get);
            _request.Resource = string.Format(Constant.B1S_Path_BusinessPartner + Constant.B1S_SID, identity);
            _request.Method = Method.Get;
            _request.AddHeader(Constant.B1S_Label_Cookie, _hCookieString);

            _response = _client.Execute(_request);
            return _response;
        }

        public RestResponse AlterBusinessPartner(string identity, object contentObjt)
        {
            // _request = new RestRequest(string.Format(Constant.B1S_Path_BusinessPartner + Constant.B1S_SID, identity), Method.Patch);
            _request.Resource = string.Format(Constant.B1S_Path_BusinessPartner + Constant.B1S_SID, identity);
            _request.Method = Method.Post;
            _request.AddHeader(Constant.B1S_Label_Cookie, _hCookieString);
            _request.AddHeader(Constant.B1S_Label_ReplaceOnPatch, true.ToString());
            _request.AddJsonBody(contentObjt);

            _response = _client.Execute(_request);
            return _response;
        }
    }
}