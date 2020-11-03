using System;
using System.Diagnostics;

public class Program
{
	public static void Main()
	{
		// получаем массив для тестов
		int[] initialArray = GetTestArray(10000, 1000000);

		// таймер для тестов
		Stopwatch stopwatch = new Stopwatch();

		// выводим на экран его первоначальное состояние
		// WriteArrayState("Initial state:", initialArray);

		// клонируем массив для тестирования сортировки "пузырьком"
		int[] bubbleSortedArray = (int[])initialArray.Clone();
		// делаем сортировку "пузырьком"
		stopwatch.Start();
		BubbleSort(bubbleSortedArray);
		stopwatch.Stop();
		// выводим на экран его отсортированное состояние
		//WriteArrayState($"Bubble sorted state:", bubbleSortedArray);
		Console.WriteLine($"Bubble sort done in {stopwatch.ElapsedMilliseconds} ms):");

		// клонируем массив для тестирования встроенной сортировки .NET
		int[] dotNetSortedArray = (int[])initialArray.Clone();
		// делаем сортировку через Array.Sort
		stopwatch.Restart();
		Array.Sort(dotNetSortedArray);
		stopwatch.Stop();
		// выводим на экран его отсортированное состояние
		//WriteArrayState($".NET sorted state:", dotNetSortedArray);
		Console.WriteLine($".NET sort done in {stopwatch.ElapsedMilliseconds} ms):");
	}

	// функция создания массива для тестирования сортировки
	private static int[] GetTestArray(int length, int maxValue)
	{
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
