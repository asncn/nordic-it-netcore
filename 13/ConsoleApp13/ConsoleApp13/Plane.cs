using System;

namespace ConsoleApp13
{
    class Plane : FlyingObject //н
    {
        public byte EnginesCount { get; private set; } // свойство

        public Plane(int maxHeight, byte bladesCount) // конструктор
          : base(maxHeight)
        {
            EnginesCount = bladesCount;
            Console.WriteLine("It's a plane, welcome aboard!");
        }

        public override void WriteAllProperties()
        {
            Console.WriteLine(EnginesCount);
            base.WriteAllProperties();
        }


    }


}
