package module.territorydata.library.models;

public class ZoneBase
{
	private long Id;
	public final long getId()
	{
		return Id;
	}
	public final void setId(long value)
	{
		Id = value;
	}
	private String Code;
	public final String getCode()
	{
		return Code;
	}
	public final void setCode(String value)
	{
		Code = value;
	}
	private String Name;
	public final String getName()
	{
		return Name;
	}
	public final void setName(String value)
	{
		Name = value;
	}
}