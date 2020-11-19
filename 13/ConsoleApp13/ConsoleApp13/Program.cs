namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Helicopter h = new Helicopter(10, 3);
            //Plane p = new Plane(50, 4);

            //h.TakeUpper(4);
            //h.WriteAllProperties();
            //h.TakeLower(4);


            //IFlyer f = new Helicopter(20,4);
            //f.TakeUpper(4);
            //f.TakeLower(4);

            //DoFlyerTest(h);
            //DoFlyerTest(p);

            using ConsoleWiter w = new ConsoleWiter();
            w.Write("Hello world");
            //w.Dispose();



            var v = new SimpleNumbersValidator();
            bool ok = v.Check(new[] { 1, 3, 5, 7, 9 });
            System.Console.WriteLine(ok);
        }

        

            


        public static void DoFlyerTest(IFlyer flyer)
        {
           flyer.TakeUpper(10);
           flyer.TakeLower(5);
           flyer.TakeLower(5);
        }        

    }


}
