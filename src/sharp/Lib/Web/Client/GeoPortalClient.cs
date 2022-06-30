namespace TerritoryData.Lib.Web.Client
{
    public class GeoPortalClient
    {
        public Energy.Base.Url BaseUrl { get; } = new Energy.Base.Url($"http://mapy.geoportal.gov.pl/wss/service/SLN/guest/sln");
        public string GeoNamespace { get; } = "PL.PZGIK.200";

    }
}
