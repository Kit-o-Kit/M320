namespace kgV und ggT
{
    internal class MyMath
    {
        static void Main(string[] args)
        {
            double a, b, z, kgv;
            int answ;


            do
            {
                Console.WriteLine("erste Zahl: ");
                a = Convert.ToDouble(Console.ReadLine());
                double z1 = a;
                
                Console.WriteLine("zweite Zahl ");
                b = Convert.ToDouble(Console.ReadLine());
                double z2 = b;

                while (b != 0)
                {
                    z = a % b;
                    a = b;
                    b = z;
                }

                kgv = (a * b) / a;

                Console.WriteLine($"der ggT von {z1} und {z2} ist {a}");
                Console.WriteLine($"der kgV von {z1} und {z2} ist {kgv}");
                Console.WriteLine("Möchten Sie einen weiteren ggT berechnen? (1 = ja, 0 = nein)");
                answ = Convert.ToInt32(Console.ReadLine());
            }
            while (answ != 0);
        }
    }

}