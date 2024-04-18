﻿using Microsoft.Extensions.Options;
using RestSharp;
using Sap.B1Client.System.Interfaces;
using Sap.B1Client.System.Models;

namespace Sap.B1Client.B1StockTransfer
{
    public class B1StockTrsfAdapter : B1StockTrsfService, IB1Client
    {
        public B1StockTrsfAdapter(IOptions<ConfigOptionModel> options) : base(options)
        {
        }

        public RestResponse AddNew(object entity)
        {
            return AddNewStockTrsf(entity);
        }

        public RestResponse Alter(string id, object changeContent)
        {
            return AlterStockTrsf(id, changeContent);
        }

        public RestResponse RetrieveAll(string requiredTemplate)
        {
            return RetrieveAllStockTrsf(requiredTemplate);
        }

        public RestResponse Retrieve(string id)
        {
            return RetrieveStockTrsf(id);
        }

        public RestResponse Cancel(string id)
        {
            return RetrieveStockTrsf(id);
        }

        public RestResponse Close(string id)
        {
            return RetrieveStockTrsf(id);
        }
    }
}