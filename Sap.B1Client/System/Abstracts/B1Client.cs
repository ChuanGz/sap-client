using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using RestSharp;
using Sap.B1Client.System.Constants;
using Sap.B1Client.System.Models;
using System.Net;

namespace Sap.B1Client.System.Abstracts;

public abstract class B1ClientBase(IOptions<ConfigOptionModel> options)
{
    public string _hCookieString {get; internal set;} = string.Empty;
    public string _hSessionString {get; internal set;}= string.Empty;
    public string _hRouteIDString {get; internal set;}= string.Empty;

    public RestClient _client {get{return new RestClient(options.Value.Host);} }
    public RestRequest _request {get{return new RestRequest();}}
    public RestResponse _response {get; set;} = new RestResponse();


    protected void LoginWebServer()
    {
        ServicePointManager.ServerCertificateValidationCallback += delegate { return true; };
        _request.Method = Method.Post;
        _request.AddJsonBody(options.Value.Credentials);
        _response = _client.Execute(_request);
        if (_response.IsSuccessful 
            && _response.StatusCode == HttpStatusCode.OK 
            && _response is not null
            && _response.Content is not null
            && _response.Cookies is not null
            && _response.Cookies.Any()) 
        {
            JObject jObject = JObject.Parse(_response.Content);
            if( jObject[Constant.B1S_Label_Session] is not null )
            {
                _hSessionString = jObject[Constant.B1S_Label_Session]!.ToString();
            }
            var m = Constant.B1S_Label_B1SESSION + _hSessionString + "; ";
            if (_response.Cookies.Count > 1)
            {
                _hRouteIDString = _response.Cookies[1].Value;
                m = m + Constant.B1S_Label_Route + _hRouteIDString + ";";
            }

            _hCookieString = m;
            Console.WriteLine($"..In Session.. {m}..");
        }
    }

    protected void LogoutWebServer()
    {
        var request = new RestRequest(Constant.B1S_Path_Logout, Method.Post);
        if(_client is not null)
        {
            _client.Execute(request);
        }
        _hCookieString = string.Empty;
    }

    private void ApplicationBeforeExitProcessAsync(object sender, EventArgs e)
    {
        LogoutWebServer();
    }
}