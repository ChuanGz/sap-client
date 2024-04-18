using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sap.B1Client.System.Interfaces;

public interface IB1Document
{
    RestResponse Cancel(string id);
    RestResponse Close(string id);
}
