using Energy.Base;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Net;
using TerritoryData.Lib.Interface.Web.Client;
using TerritoryData.Lib.Web.Model;

namespace TerritoryData.Lib.Web.Client
{
    public class TerritoryDataClient : ITerritoryDataClient
    {
        private Url baseUrl;
        public Url BaseUrl
        {
            get { return baseUrl; } 
            private set { baseUrl = value; }
        }

        public TerritoryDataClient(Energy.Base.Url baseUrl)
        {

        }
        public CountryListResponse GetCountryList()
        {
            string queryUrl = Energy.Base.Url.Make(baseUrl.ToString(), null, null, null, Energy.Base.Url.Combine("country"), null, null);
            var response = Energy.Core.Web.Get(queryUrl);
            if (response == null)
                return null;
            return JsonConvert.DeserializeObject<CountryListResponse>(response.Body);
        }
    }
}
