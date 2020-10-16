using System;

namespace L05_C00_enum_methods
{
	class Program
	{
		[Flags]
		enum MyColor
		{
			Black = 0x1,
			Blue = 0x1 << 1,
			Cyan = 0x1 << 2,
			Grey = 0x1 << 3,
			Green = 0x1 << 4,
			Magenta = 0x1 << 5,
			Red = 0x1 << 6,
			White = 0x1 << 7,
			Yellow = 0x1 << 8,
		}

		static void Main(string[] args)
		{
			MyColor allColors = GetAllColors();
			DisplayColors(allColors, "Список возможных цветов:");

			MyColor favoriteColors = GetFavoriteColors();
			DisplayColors(favoriteColors, "Любимые цвета:");

			MyColor notFavoriteColors = allColors ^ favoriteColors;
			DisplayColors(notFavoriteColors, "Нелюбимые цвета:");

			Console.WriteLine("\nОтладочная информация:");
			WriteInt32ValueWithBits(allColors, nameof(allColors));
			WriteInt32ValueWithBits(favoriteColors, nameof(favoriteColors));
			WriteInt32ValueWithBits(notFavoriteColors, nameof(notFavoriteColors));
		}

		static void DisplayColors(MyColor colors, string message)
		{
			Console.Write(message);

			for (int bitIndex = 0; bitIndex < 32; bitIndex++)
			{
				int value = 0x1 << bitIndex;

				if (((int)colors & value) == value)
				{
					Console.Write(" " + (MyColor)value);
				}
			}

			Console.WriteLine();
		}

		static MyColor GetAllColors()
		{
			MyColor allColors = (MyColor)0;

			foreach (MyColor color in Enum.GetValues(typeof(MyColor)))
			{
				allColors |= color;
			}

			return allColors;
		}

		static MyColor GetFavoriteColors()
		{
			MyColor favoriteColors = (MyColor)0;

			for (int i = 0; i < 4; i++)
			{
				while (true)
				{
					object color;
					Console.Write($"Введите любимый цвет {i + 1}: ");

					bool ok = Enum.TryParse(typeof(MyColor), Console.ReadLine(), true, out color)
						&& ((int)color & (int)color - 1) == 0; // check that color is a power of 2

					if (ok)
					{
						favoriteColors |= (MyColor)color;
						break;
					}
					else
					{
						Console.WriteLine("Ошибка!");
					}
				}
			}

			return favoriteColors;
		}

		static void WriteInt32ValueWithBits(object value, string description)
		{
			Console.WriteLine(
				"Flags: {0} : {1}",
				Convert.ToString((int)value, 2).PadLeft(32, '0'),
				description);
		}
	}
}
