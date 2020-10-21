using System;
using System.Globalization;
using System.Text;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            //double radius = 15;
            //double j = Math.PI;

            //double square = radius * radius * Math.PI;
            //Console.WriteLine(
            //    "Square of the circle with the radius " +
            //    i + " equals to " + Math.Round(square, 3));

            //string stringRadius = radius.ToString(
            //    "C",
            //    CultureInfo.GetCultureInfo("ru-RU"));

            //Console.WriteLine(stringRadius);

            //string outputResult = string.Format(
            //    "Square of the circle with the radius {0:#.000} equals to {1:#.000}",
            //    radius,
            //    square);

            //Console.WriteLine(outputResult);

            //double i;
            //double j;
            //string input;

            //Console.WriteLine("Enter two real numbers to multiply them: ");
            //input = Console.ReadLine();
            //i = double.Parse(input);
            //input = Console.ReadLine();
            //j = double.Parse(input);

            //Console.WriteLine(i.ToString("0.#") + " * " + j.ToString("0.#") + " = " + (i * j).ToString("0.#"));

            //string s = String.Format("{0:0.##} + {1:0.##} = {2:0.##} ", i, j, i+j);
            //Console.WriteLine(s);

            //var c = $"{i:#.##} - {j:#.##} = {i - j:#.##}";
            //Console.WriteLine(c);

            //var test = "test string";
            //Console.WriteLine(test.Contains(" ")); //true
            //Console.WriteLine(test.StartsWith("te")); // true
            //Console.WriteLine(test.EndsWith("s")); // false

            //Console.WriteLine(test.IndexOf("s")); //2
            //Console.WriteLine(test.LastIndexOf("s")); //5



            //Console.WriteLine("Введите слово: ");
            //string word = Console.ReadLine();
            //Console.WriteLine("Введите букву: ");
            //string letter = Console.ReadLine();


            //string result = 
            // int letterNumber = 0;


            // for(int i = 0; i < word.Length; i++)
            //{
            // int indexOfLetter = 0;
            // do
            // {

            //    indexOfLetter = word.IndexOf(letter, indexOfLetter);

            //    if (indexOfLetter < 0)
            //        break;

            //   Console.WriteLine(indexOfLetter);
            //   indexOfLetter++;

            //if (letter == word[i].ToString())
            // letterNumber++;
            // }while (true);

            // }

            //Console.WriteLine(
            //    $"Количество букв \"{letter}\" " +

            //   $"в слове \" {word}\":{letterNumber}");



            //Console.WriteLine("enter email");
            //string email = Console.ReadLine();
            //Console.WriteLine(email.ToLower());

            //Console.WriteLine("enter card holder name");
            //string name = Console.ReadLine();
            //Console.WriteLine(name.ToUpper());


            //string text = "   lorem   ipsum   dolor     sit   amet ";     
            //while (text.Contains("  "))
            //{
            //    text = text.Replace("  ", " ");
            //}
            // text = text.Trim();

            //string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //words[1] = words[1].ToUpper();
            //Console.WriteLine(string.Join(' ', words)); // | string result = string.Join(" ", words); Console.WriteLine(result);


            // string textClean = text.TrimEnd(); 
            // int lastSpaceIndex = textClean.LastIndexOf(' '); 
            // textClean = textClean.Substring(0, lastSpaceIndex); 
            // textClean = textClean.TrimEnd(); 
            // Console.WriteLine(textClean);

            // string[] words = "this is my great example" .Split(' ');


            //var exampleBuilder = new StringBuilder(100);
            // foreach (var word in words)
            // {
            //     exampleBuilder
            //         .Append(word)
            //         .Append(" , ");

            // }

            // exampleBuilder.Remove(
            //     exampleBuilder.Length - 2,
            //     2);
            // exampleBuilder.Replace(',', '*');
            // Console.WriteLine(exampleBuilder.ToString());

            string text = " lorem ipsum dolor sit amet    ";
            var resultBuilder = new StringBuilder(text.Length);

            for (int i = 0; i < text.Length; i++)
            {
                resultBuilder.Append(text[i]);
                if (resultBuilder [resultBuilder.Length - 1]
            }


        }
    }
}
