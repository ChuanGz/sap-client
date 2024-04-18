using Microsoft.Extensions.Options;
using RestSharp;
using Sap.B1Client.System.Abstracts;
using Sap.B1Client.System.Constants;
using Sap.B1Client.System.Models;

namespace Sap.B1Client.B1InventoryTransferRequest
{
    public class B1StockTrsfRequestService(IOptions<ConfigOptionModel> options) : B1ClientBase(options)
    {
        public RestResponse AddNewStockTrsfRequest(object entity)
        {
            // _request = new RestRequest(Constant.B1S_Path_Stock_Transfer_Request, Method.Post);
            _request.Resource = Constant.B1S_Path_Stock_Transfer_Request;
            _request.Method = Method.Post;
            _request.AddHeader(Constant.B1S_Label_Cookie, _hCookieString);
            _request.AddJsonBody(entity);

            _response = _client.Execute(_request);
            return _response;
        }

        public RestResponse RetrieveAllStockTrsfRequest(string requiredTemplate)
        {
            // _request = new RestRequest(Constant.B1S_Path_Stock_Transfer_Request + requiredTemplate, Method.Get);
            _request.Resource = Constant.B1S_Path_Stock_Transfer_Request + requiredTemplate;
            _request.Method = Method.Get;
            _request.AddHeader(Constant.B1S_Label_Cookie, _hCookieString);

            _response = _client.Execute(_request);
            return _response;
        }

        public RestResponse RetrieveStockTrsfRequest(string identity)
        {
            // _request = new RestRequest(string.Format(Constant.B1S_Path_Stock_Transfer_Request + Constant.B1S_IID, identity), Method.Get);
            _request.Resource = string.Format(Constant.B1S_Path_Stock_Transfer_Request + Constant.B1S_IID, identity);
            _request.Method = Method.Get;
            _request.AddHeader(Constant.B1S_Label_Cookie, _hCookieString);

            _response = _client.Execute(_request);
            return _response;
        }

        public RestResponse AlterStockTrsfRequest(string identity, object contentObjt)
        {
            // _request = new RestRequest(string.Format(Constant.B1S_Path_Stock_Transfer_Request + Constant.B1S_IID, identity), Method.Patch);
            _request.Resource = string.Format(Constant.B1S_Path_Stock_Transfer_Request + Constant.B1S_IID, identity);
            _request.Method = Method.Patch;
            _request.AddHeader(Constant.B1S_Label_Cookie, _hCookieString);
            _request.AddHeader(Constant.B1S_Label_ReplaceOnPatch, true.ToString());
            _request.AddJsonBody(contentObjt);

            _response = _client.Execute(_request);
            return _response;
        }
    }
}