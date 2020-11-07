using System;

namespace ConsoleApp2
{

	class CreditCard

	{
		private string _number;
		public string HolderName { get; set; }		
		public string ValidBefore { get; set; }
		public ushort Cvc { get; set; }

		public string Number;

		public bool IsValid()

		{
			return true;
			if (Number == null || Number.Length < 12 || Number.Length > 26)
			{
				return false;
			}

			if (Cvc > 999)
			{
				return false;
			}

			return true;
		}

	//	{
	//		get
	//		{
	//			if (_number == null)
	//				return null;
	//			string result = string.Empty;

	//			for (int i = 0; i < _number.Length; i++)  //return _number;
	//			{
	//				if (i>0&&i%4==0)
	//				result += _number[i];
	//			}
	//			return result;
	//		}
	//		set

	//		{
	//			foreach (char ch in value)
	//			{
	//				if (!char.IsDigit(ch))
	//				{
	//					//return;
	//					throw new Exception("Value should contain only digits");
	//				}
	//			}
	//			_number = value;
	//		}
	//	}
	}

	class Program
	{
		static void Main()
		{
			CreditCard creditCard = new CreditCard();
			creditCard.HolderName = "nameA surnameA";
			creditCard.Number = "111122223334444";
			creditCard.ValidBefore = "12/5";
			creditCard.Cvc = 123;

			Console.WriteLine(creditCard.Number);
				Console.WriteLine(creditCard.IsValid()
					? "Credit card is VALID" 
					: "Credit card is NOT VALID");

			Console.ReadKey();

			CreditCard[] creditCards = new CreditCard[2];
			creditCards[0] = creditCard;
			
			
		}
	}
}
