﻿using Microsoft.Extensions.Options;
using RestSharp;
using Sap.B1Client.System.Abstracts;
using Sap.B1Client.System.Constants;
using Sap.B1Client.System.Models;

namespace Sap.B1Client.Services;

public class B1ItemService(IOptions<ConfigOptionModel> options) : B1ClientBase(options)
{
    public RestResponse AddNewItem(object entity)
    {
        _request.Resource = Constant.B1S_Path_Item;
        _request.Method = Method.Post;
        _request.AddHeader(Constant.B1S_Label_Cookie, _hCookieString);
        _request.AddJsonBody(entity);

        _response = _client.Execute(_request);
        return _response;
    }

    public RestResponse RetrieveAllItem(string requiredTemplate)
    {
        _request.Resource = Constant.B1S_Path_Item + requiredTemplate;
        _request.Method = Method.Get;
        _request.AddHeader(Constant.B1S_Label_Cookie, _hCookieString);

        _response = _client.Execute(_request);
        return _response;
    }

    public RestResponse RetrieveItem(string identity)
    {
        _request.Resource = string.Format(Constant.B1S_Path_Item + Constant.B1S_SID, identity);
        _request.Method = Method.Get;
        _request.AddHeader(Constant.B1S_Label_Cookie, _hCookieString);

        _response = _client.Execute(_request);
        return _response;
    }

    public RestResponse AlterItem(string identity, object contentObjt)
    {
        _request.Resource = string.Format(Constant.B1S_Path_Item + Constant.B1S_SID, identity);
        _request.Method = Method.Patch;
        _request.AddHeader(Constant.B1S_Label_Cookie, _hCookieString);
        _request.AddHeader(Constant.B1S_Label_ReplaceOnPatch, true.ToString());
        _request.AddJsonBody(contentObjt);

        _response = _client.Execute(_request);
        return _response;
    }
}