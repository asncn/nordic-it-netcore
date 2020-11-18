public class Passport : BaseDocument
{
	public string Country { get; set; }

	public string PersonName { get; set; }

	public override string PropertiesString
	{
		get
		{
			return $"{DocName} #{DocNumber} issued "
				   + $"{IssueDate:dd-MM-yy} in "
				   + $"{Country} for {PersonName}";
		}
	}
}
