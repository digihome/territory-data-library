package module.territorydata.library.interfaces;

public interface TerritoryDataRepository
{
	models.Country GetCountry(String countryCode);
	models.CountryList GetCountryList();
	models.Zone1 GetZone1(String zone1Code);
	models.Zone1List GetZone1List(models.SearchParams searchParams);
	models.Zone2 GetZone2(String zone2Code);
	models.Zone2List GetZone2List(models.SearchParams searchParams);
	models.Zone3 GetZone3(String zone3Code);
	models.Zone3List GetZone3List(models.SearchParams searchParams);
	models.City GetCity(String cityCode);
	models.CityList GetCityList(models.SearchParams searchParams);
	models.Address Address(String addressCode);
	models.AddressList GetAddressList(models.SearchParams searchParams);

}