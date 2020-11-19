using System;

namespace ConsoleApp13
{
    public class Helicopter: FlyingObject //н
    {
        public byte BladesCount { get; private set; } // свойство

        public Helicopter(int maxHeight, byte bladesCount) // конструктор
          :base(maxHeight)
        {
            BladesCount = bladesCount;
            Console.WriteLine("It's a helicopter, welcome aboard!");                
         }

        public override void WriteAllProperties() // метод
        {
            Console.WriteLine(BladesCount);
            base.WriteAllProperties();
        }


    }


}
