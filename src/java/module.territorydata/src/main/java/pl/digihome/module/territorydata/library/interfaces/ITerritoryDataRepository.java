package pl.digihome.module.territorydata.library.interfaces;

import pl.digihome.module.territorydata.library.models.*;
import pl.digihome.module.territorydata.library.*;

public interface ITerritoryDataRepository
{
	Country GetCountry(String countryCode);
	CountryList GetCountryList();
	Zone1 GetZone1(String zone1Code);
	Zone1List GetZone1List(SearchParams searchParams);
	Zone2 GetZone2(String zone2Code);
	Zone2List GetZone2List(SearchParams searchParams);
	Zone3 GetZone3(String zone3Code);
	Zone3List GetZone3List(SearchParams searchParams);
	City GetCity(String cityCode);
	CityList GetCityList(SearchParams searchParams);
	Address Address(String addressCode);
	AddressList GetAddressList(SearchParams searchParams);

}