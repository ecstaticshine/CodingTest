class Program
{

    static void Main(string[] args)
    {
        int times = int.Parse(Console.ReadLine());

        for (int i = 0; i < times; i++)
        {
            string[] stringArray = (Console.ReadLine()).Split(' ');
            int a = 0;
            int b = 0;
            if (stringArray.Length == 2)
            {
                a = int.Parse(stringArray[0]);
                a %= 10;
                b = int.Parse(stringArray[1]);
            }

            // a0 대책
            int sum = 1;
            // b가 0일 때는 true
            bool isBzero = false;

            if (b == 0)
            {
                isBzero = true;
            }
            else { b %= 4; }


            if (b == 0 && !isBzero) b = 4;

            for (int j = 0; j < b; j++)
            {
                sum *= a;
            }

            sum %= 10;

            if (sum == 0)
            {
                sum = 10;
            }

            Console.WriteLine(sum);
        }

    }
}