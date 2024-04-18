using Microsoft.Extensions.Options;
using RestSharp;
using Sap.B1Client.System.Constants;
using Sap.B1Client.System.Models;
using Sap.B1Client.System.Abstracts;

namespace Sap.B1Client.Services;

public class B1OrderService(IOptions<ConfigOptionModel> options) : B1ClientBase(options)
{
    public RestResponse AddNewDocument(object entity)
    {
        // _request = new RestRequest(Constant.B1S_Path_Sales_Order, Method.Post);
        _request.Resource = Constant.B1S_Path_Sales_Order;
        _request.Method = Method.Post;
        _request.AddHeader(Constant.B1S_Label_Cookie, _hCookieString);
        _request.AddJsonBody(entity);

        _response = _client.Execute(_request);
        return _response;
    }

    public RestResponse RetrieveAllDocument(string requiredTemplate)
    {
        // _request = new RestRequest(Constant.B1S_Path_Sales_Order + requiredTemplate, Method.Get);
        _request.Resource = Constant.B1S_Path_Sales_Order + requiredTemplate;
        _request.Method = Method.Get;
        _request.AddHeader(Constant.B1S_Label_Cookie, _hCookieString);

        _response = _client.Execute(_request);
        return _response;
    }

    public RestResponse RetrieveDocument(string identity)
    {
        // _request = new RestRequest(string.Format(Constant.B1S_Path_Sales_Order + Constant.B1S_IID, identity), Method.Get);
        _request.Resource = string.Format(Constant.B1S_Path_Sales_Order + Constant.B1S_IID, identity);
        _request.Method = Method.Get;
        _request.AddHeader(Constant.B1S_Label_Cookie, _hCookieString);

        _response = _client.Execute(_request);
        return _response;
    }

    public RestResponse AlterDocument(string identity, object contentObjt)
    {
        // _request = new RestRequest(string.Format(Constant.B1S_Path_Sales_Order + Constant.B1S_IID, identity), Method.Patch);
        _request.Resource = string.Format(Constant.B1S_Path_Sales_Order + Constant.B1S_IID, identity);
        _request.Method = Method.Patch;
        _request.AddHeader(Constant.B1S_Label_Cookie, _hCookieString);
        _request.AddHeader(Constant.B1S_Label_ReplaceOnPatch, true.ToString());
        _request.AddJsonBody(contentObjt);

        _response = _client.Execute(_request);
        return _response;
    }

    public RestResponse CancelDocument(string identity)
    {
        // _request = new RestRequest(string.Format(Constant.B1S_Path_Sales_Order + Constant.B1S_IID + Constant.B1S_AcDoc_CANCEL, identity), Method.Post);
        _request.Resource = string.Format(Constant.B1S_Path_Sales_Order + Constant.B1S_IID + Constant.B1S_AcDoc_CANCEL, identity);
        _request.Method = Method.Post;
        _request.AddHeader(Constant.B1S_Label_Cookie, _hCookieString);

        _response = _client.Execute(_request);
        return _response;
    }

    public RestResponse CloseDocument(string identity)
    {
        // _request = new RestRequest(string.Format(Constant.B1S_Path_Sales_Order + Constant.B1S_IID + Constant.B1S_AcDoc_CLOSE, identity), Method.Post);
        _request.Resource = string.Format(Constant.B1S_Path_Sales_Order + Constant.B1S_IID + Constant.B1S_AcDoc_CLOSE, identity);
        _request.Method = Method.Post;
        _request.AddHeader(Constant.B1S_Label_Cookie, _hCookieString);

        _response = _client.Execute(_request);
        return _response;
    }
}