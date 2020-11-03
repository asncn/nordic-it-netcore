using System;

public class Program
{
	public static void Main()
	{
		// получаем массив для тестов
		int[] initialArray = GetTestArray();

		// выводим на экран его первоначальное состояние
		WriteArrayState("Initial state:", initialArray);

		// клонируем массив для тестирования сортировки "пузырьком"
		int[] bubbleSortedArray = (int[])initialArray.Clone();
		// делаем сортировку "пузырьком"
		BubbleSort(initialArray);

		// выводим на экран его отсортированное состояние
		WriteArrayState("Sorted state:", bubbleSortedArray);
	}

	// функция создания массива для тестирования сортировки
	private static int[] GetTestArray()
	{
		const int length = 5;
		const int maxValue = 100;
		var arr = new int[length];

		var rnd = new Random();
		for (var i = 0; i < arr.Length; i++)
		{
			arr[i] = rnd.Next(maxValue);
		}

		return arr;
	}

	// функция вывода на экран элементов массива с названием состояния
	private static void WriteArrayState(string message, int[] arr)
	{
		Console.WriteLine(message);
		for (var i = 0; i < arr.Length; i++)
		{
			Console.WriteLine(arr[i]);
		}
	}

	// функция собственно со ти овки "пузырьком"
	private static void BubbleSort(int[] arr)
	{
		// i нам нужна уже не для доступа к массиву, а всего лишь
		// для уменьшения лимита внутреннего цикла
		for (int i = 0; i < arr.Length - 1; i++)
		{
			// перебираем массив по j, не доходя до последнего элемента
			// до него мы доберемся через выражение j + 1
			int limit = arr.Length - 1 - i;
			for (int j = 0; j < limit; j++)
			{
				// сравниваем текущий и последующий элементы
				// если текущий больше последующего, меняем их местами
				if (arr[j] > arr[j + 1])
				{
					int temp = arr[j + 1];  // обмен значений
					arr[j + 1] = arr[j];    // двух переменных
					arr[j] = temp;          // через третью
				}
			}
		}
	}
}
