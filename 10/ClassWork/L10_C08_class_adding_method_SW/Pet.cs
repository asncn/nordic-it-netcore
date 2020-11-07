using System;

public class Pet
{
	public enum AnimalKind { Mouse, Cat, Dog }

	private string _birthPlace;
	private char _sex;

	public AnimalKind Kind;
	public string Name;


	public DateTimeOffset DateOfBirth;

	public byte GetAge()
	{
		TimeSpan liveTime = DateTimeOffset.Now.Subtract(DateOfBirth);
		return (byte)Math.Floor(liveTime.TotalDays / 365.25);
	}


	public char Sex
	{
		get
		{
			return _sex;
		}
		set
		{
			if (value == 'f' || value == 'F' || value == 'm' || value == 'M')
			{
				_sex = char.ToUpper(value);
			}
			else
			{
				throw new Exception("Invalid value");
			}
		}
	}

	public string Description
	{
		get
		{
			return $"{Name} is a {Kind} ({Sex}) of {GetAge()} years old" +
				$" (birth place: {_birthPlace}.";
		}
	}

	public void SetBirthPlace(string birthPlace)
	{
		_birthPlace = birthPlace;
	}


	public string ShortDescription
	{
		get
		{
			return $"{Name}, {GetAge()} years old";

		}
	}
	public string GetDescription(bool isShort = false)
	{
		if (isShort == true)
		{
			return ShortDescription;
		}
		return Description;
	}

	public void UpdateProperties(string name)
	{
		Name = name;
	}

	public void UpdateProperties(string name, AnimalKind kind, char sex, DateTimeOffset dateOfBirth)
	{
		Name = name;
		Kind = kind;
		Sex = sex;
		DateOfBirth = dateOfBirth;
	}




	public Pet() { }

	public Pet(string name, AnimalKind kind, char sex, DateTimeOffset dateOfBirth)
	{
		Name = name;
		Kind = kind;
		Sex = sex;
		DateOfBirth = dateOfBirth;
		
	}

	

}
