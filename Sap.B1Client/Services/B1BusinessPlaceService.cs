using Microsoft.Extensions.Options;
using RestSharp;
using Sap.B1Client.System.Abstracts;
using Sap.B1Client.System.Constants;
using Sap.B1Client.System.Models;

namespace Sap.B1Client.Services;

public class B1BusinessPlaceService(IOptions<ConfigOptionModel> options) : B1ClientBase(options)
{
    public RestResponse AddNewBusinessPlace(object entity)
    {
        // _request = new RestRequest(Constant.B1S_Path_BusinessPlace, Method.Post);
        _request.Resource = Constant.B1S_Path_BusinessPlace;
        _request.Method = Method.Post;
        _request.AddHeader(Constant.B1S_Label_Cookie, _hCookieString);
        _request.AddJsonBody(entity);

        _response = _client.Execute(_request);
        return _response;
    }

    public RestResponse RetrieveAllBusinessPlace(string requiredTemplate)
    {
        // _request = new RestRequest(Constant.B1S_Path_BusinessPlace + requiredTemplate, Method.Get);
        _request.Resource = Constant.B1S_Path_BusinessPlace + requiredTemplate;
        _request.Method = Method.Get;
        _request.AddHeader(Constant.B1S_Label_Cookie, _hCookieString);

        _response = _client.Execute(_request);
        return _response;
    }

    public RestResponse RetrieveBusinessPlace(string identity)
    {
        // _request = new RestRequest(string.Format(Constant.B1S_Path_BusinessPlace + Constant.B1S_SID, identity), Method.Get);
        _request.Resource = string.Format(Constant.B1S_Path_BusinessPlace + Constant.B1S_SID, identity);
        _request.Method = Method.Get;
        _request.AddHeader(Constant.B1S_Label_Cookie, _hCookieString);

        _response = _client.Execute(_request);
        return _response;
    }

    public RestResponse AlterBusinessPlace(string identity, object contentObjt)
    {
        // _request = new RestRequest(string.Format(Constant.B1S_Path_BusinessPlace + Constant.B1S_SID, identity), Method.Patch);
        _request.Resource = string.Format(Constant.B1S_Path_BusinessPlace + Constant.B1S_SID, identity);
        _request.Method = Method.Patch;
        _request.AddHeader(Constant.B1S_Label_Cookie, _hCookieString);
        _request.AddHeader(Constant.B1S_Label_ReplaceOnPatch, true.ToString());
        _request.AddJsonBody(contentObjt);

        _response = _client.Execute(_request);
        return _response;
    }
}