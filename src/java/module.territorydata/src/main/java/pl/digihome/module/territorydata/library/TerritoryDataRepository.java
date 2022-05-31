package pl.digihome.module.territorydata.library;

import pl.digihome.module.territorydata.library.interfaces.*;
import pl.digihome.module.territorydata.library.models.*;

public class TerritoryDataRepository implements ITerritoryDataRepository
{
	public final Address Address(String addressCode)
	{
		throw new UnsupportedOperationException();
	}

	public final AddressList GetAddressList(SearchParams searchParams)
	{
		throw new UnsupportedOperationException();
	}

	public final City GetCity(String cityCode)
	{
		throw new UnsupportedOperationException();
	}

	public final CityList GetCityList(SearchParams searchParams)
	{
		throw new UnsupportedOperationException();
	}

	public final Country GetCountry(String countryCode)
	{
		throw new UnsupportedOperationException();
	}

	public final CountryList GetCountryList()
	{
		CountryList countryList = new CountryList();
		Country tempVar = new Country();
		tempVar.setId(1);
		tempVar.setCode("pl");
		tempVar.setName("Poland");
		countryList.add(tempVar);
		Country tempVar2 = new Country();
		tempVar2.setId(1);
		tempVar2.setCode("de");
		tempVar2.setName("Germany");
		countryList.add(tempVar2);
		return countryList;
	}

	public final Zone1 GetZone1(String zone1Code)
	{
		throw new UnsupportedOperationException();
	}

	public final Zone1List GetZone1List(SearchParams searchParams)
	{
		throw new UnsupportedOperationException();
	}

	public final Zone2 GetZone2(String zone2Code)
	{
		throw new UnsupportedOperationException();
	}

	public final Zone2List GetZone2List(SearchParams searchParams)
	{
		throw new UnsupportedOperationException();
	}

	public final Zone3 GetZone3(String zone3Code)
	{
		throw new UnsupportedOperationException();
	}

	public final Zone3List GetZone3List(SearchParams searchParams)
	{
		throw new UnsupportedOperationException();
	}
}