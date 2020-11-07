using System;


class Program
{
	static void Main(string[] args)
	{
		Pet pet1 = new Pet();
		pet1.Kind = Pet.AnimalKind.Cat;
		pet1.Name = "Tom";
		pet1.Sex = 'M';
		pet1.DateOfBirth = DateTimeOffset.Parse("2012-11-07 20:20:15.5488");
		pet1.SetBirthPlace("Moscow");
		Console.WriteLine(pet1.GetDescription());

		pet1.UpdateProperties("Bob");
		Console.WriteLine(pet1.GetDescription());


		Pet pet2 = new Pet
		{
			Kind = Pet.AnimalKind.Mouse,
			Name = "Minnie",
			Sex = 'F',
			DateOfBirth = DateTimeOffset.Parse("2012-11-07 20:20:15.5488")
		};
		pet2.SetBirthPlace("St.Petersburg");

		Console.WriteLine(pet2.GetDescription(isShort: true));
		pet2.UpdateProperties("Jerry", Pet.AnimalKind.Dog, 'M', DateTimeOffset.Parse("2017-09-05"));
		Console.WriteLine(pet2.GetDescription(isShort: true));

		
		Pet pet3 = new Pet("hhh", Pet.AnimalKind.Mouse, 'F', DateTimeOffset.Parse("2015-08-11"));
		Console.WriteLine(pet3.GetDescription(isShort: false));




		Console.ReadKey();
	}

}
