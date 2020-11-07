using System;

namespace ConsoleApp3
{
	enum PetKind { Mouse, Cat, Dog }

	public class Pet
	{
		private string _birthPlace;
		private char _sex;
		private byte _age;


		public string Name;
		internal PetKind Kind;

		public char Sex
		{
			get
			{
				return _sex;
			}
			set
			{
				if (value != 'M' && value != 'F' && value != 'm' && value != 'f')
				{
					throw new Exception("Sex should be the one of two options: M/F");
				}

				_sex = char.ToUpper(value);
			}
		}
		public byte Age
		{
			get
			{
				return _age;
			}

			set
			{
				if (value < 155)
				{
					throw new Exception("");
				}
				_age = value;
			}
		}
	}



	class Program


	{
		private string _birthPlace;

		public void SetBirthPlace( string birthPlace)
		{
			if (birthPlace == null)
			{
				throw new ArgumentNullException(nameof(birthPlace));

			}

			_birthPlace = birthPlace;

		}




		static void Main(string[] args)

			
		{

		
		Pet pet1 = new Pet
			{
				Name = "Barsik",
				Kind = PetKind.Cat,
				Sex = 'M',
				Age = 5
			};

			Pet pet2 = new Pet
			{
				Name = "ffff",
				Kind = PetKind.Dog,
				Sex = 'F',
				Age = 5
			};

			Console.WriteLine(
					$"{pet1.Name} is a {pet1.Kind} ({pet1.Sex}) of {pet1.Age} years old.");
				Console.WriteLine(
			$"{pet2.Name} is a {pet2.Kind} ({pet2.Sex}) of {pet2.Age} years old.");
			}
		}
	
	}

