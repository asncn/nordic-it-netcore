using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace L10_C01_class_fields_and_properties_demo
{
	class CreditCard
	{
		private string _number;

		public string HolderName { get; set; }
		public string ValidBefore { get; set; }
		public ushort Cvc { get; set; }

		public string Number

		{
			get
			{
				//if (_number == null)
				//	return null;

				//string result = string.Empty;

				//for (int i = 0; i < _number.Length; i++)
				//{
				//	if (i > 0 && i % 4 == 0)
				//		result += " ";

				//	result += _number[i];
				//}

				//return result;

				return _number;
			}
			set
			{
				foreach (char ch in value)
				{
					if (!char.IsDigit(ch))
					{
						throw new Exception(
							"Value should contain only digits.");
					}
				}

				_number = value;
			}
		}

		private bool NumberIsValid()
		{
			return Number != null
				   && Number.Length >= 12
				   && Number.Length <= 26;
		}

		private bool ValidBeforeIsValid()
		{
			return ValidBefore != null;
		}

		private bool CvcIsValid()
		{
			return Cvc < 1000;
		}

		public bool IsValid()
		{
			return
				NumberIsValid()
				&& ValidBeforeIsValid()
				&& CvcIsValid();
		}
	}

	enum PetKind
	{
		Mouse,
		Cat,
		Dog
	}

	class Pet
	{
		private string _birthPlace;
		private char _sex;

		public PetKind Kind;
		public string Name;

		public char Sex
		{
			get { return _sex; }
			set
			{
				if (value != 'M' && value != 'm' && value != 'F' && value != 'f')
					throw new Exception("Sex should be one of two options: M/F.");
				
				_sex = char.ToUpper(value);
			}
		}

		public byte Age { get; set; }
	}


	class Program
	{
		static void Main()
		{
			//CreditCard creditCard = new CreditCard();
			//creditCard.HolderName = "Andrei Golyakov";
			//creditCard.Number = "111122223333444455";
			//creditCard.ValidBefore = "12/25";
			//creditCard.Cvc = 1234;

			//Console.WriteLine(creditCard.Number);

			//creditCard.Number += "9";
			//creditCard.Number = creditCard.Number + "9";

			//Console.WriteLine(creditCard.Number);
			//Console.WriteLine(creditCard.IsValid()
			//	? "Credit card is VALID"
			//	: "Credit card is NOT VALID");

			//CreditCard[] creditCards = new CreditCard[2];
			//creditCards[0] = creditCard;
		}
	}
}
