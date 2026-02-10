using System;

    class Program
    {
        static void Main(string[] args)
        {
            int value = int.Parse(Console.ReadLine());
            for (int i = 0; i < value; i++)
            {
               int value2 = int.Parse(Console.ReadLine());
                fibonacci(value2);

            }
        }

        public static void fibonacci(int n)
        {

            if (n.Equals(0))
            {
                Console.WriteLine("1 0");
                return;
            }
            if(n.Equals(1))
            {
                Console.WriteLine("0 1");
                return;
            }
            //0일때 0과 1 카운트
            int x0 = 1;
            int y0 = 0;
            //1일때 0과 1카운트
            int x1 = 0;
            int y1 = 1;

            int zeroCount = 0;
            int oneCount = 0;

            for (int i = 2; i <= n; i++)
            {
                zeroCount = x0 + x1;
                oneCount = y0 + y1;

                x0 = x1;
                y0 = y1;

                x1 = zeroCount;
                y1 = oneCount;

            }
            Console.WriteLine($"{zeroCount} {oneCount}");
        }
    }

