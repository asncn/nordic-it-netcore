using System;

namespace ConsoleApp13
{
    public abstract class FlyingObject:IFlyer, IPropertiesWriter
    {
        public int MaxHeight { get; private set; }
        public int CurrentHeight { get; private set; }

        public FlyingObject(int maxHeight)
        {
            MaxHeight = maxHeight;
            CurrentHeight = 0;
        }

        public virtual void WriteAllProperties() // метод
        {
            Console.WriteLine(CurrentHeight);
            Console.WriteLine(MaxHeight);
        }


        public void TakeUpper(int delta) //метод
        {
            if (delta <= 0)
                throw new ArgumentOutOfRangeException();

            if ((CurrentHeight + delta) > MaxHeight)
            {
                CurrentHeight = MaxHeight;
            }
            else
                CurrentHeight = CurrentHeight + delta;
                                 
        }
        public void TakeLower(int delta) //метод

        {
            if (delta <= 0)
                throw new ArgumentOutOfRangeException();

            if ((CurrentHeight - delta) > 0)
            {
                CurrentHeight = CurrentHeight;
            }
            else if ((CurrentHeight - delta) == 0)
            {
                CurrentHeight = 0;
            }
            else if (CurrentHeight - delta < 0)
            {
                throw new InvalidOperationException("Crash!");
            }
        }
    }


}
