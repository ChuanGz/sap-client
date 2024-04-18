using Microsoft.Extensions.Options;
using RestSharp;
using Sap.B1Client.System.Abstracts;
using Sap.B1Client.System.Constants;
using Sap.B1Client.System.Models;

namespace Sap.B1Client.Services;

public class B1WarehouseService(IOptions<ConfigOptionModel> options) : B1ClientBase(options)
{
    public RestResponse AddNewWarehouse(object entity)
    {
        _request.Resource = Constant.B1S_Path_Warehouse;
        _request.Method = Method.Post;
        _request.AddHeader(Constant.B1S_Label_Cookie, _hCookieString);
        _request.AddJsonBody(entity);

        _response = _client.Execute(_request);
        return _response;
    }

    public RestResponse RetrieveAllWarehouse(string requiredTemplate)
    {
        _request.Resource = Constant.B1S_Path_Warehouse + requiredTemplate;
        _request.Method = Method.Get;
        _request.AddHeader(Constant.B1S_Label_Cookie, _hCookieString);
        _request.AddHeader("Prefer", "odata.maxpagesize=600");

        _response = _client.Execute(_request);
        return _response;
    }

    public RestResponse RetrieveWarehouse(string identity)
    {
        _request.Resource = string.Format(Constant.B1S_Path_Warehouse + Constant.B1S_SID, identity);
        _request.Method = Method.Get;
        _request.AddHeader(Constant.B1S_Label_Cookie, _hCookieString);

        _response = _client.Execute(_request);
        return _response;
    }

    public RestResponse AlterWarehouse(string identity, object contentObjt)
    {
        _request.Resource = string.Format(Constant.B1S_Path_Warehouse + Constant.B1S_SID, identity);
        _request.Method = Method.Patch;
        _request.AddHeader(Constant.B1S_Label_Cookie, _hCookieString);
        _request.AddHeader(Constant.B1S_Label_ReplaceOnPatch, true.ToString());
        _request.AddJsonBody(contentObjt);

        _response = _client.Execute(_request);
        return _response;
    }
}