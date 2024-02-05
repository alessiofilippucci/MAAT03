namespace Sample3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int tot = GetTotal();
            //Console.WriteLine(tot);

            //int a = GetNumber();
            //int b = GetNumber();

            //Console.WriteLine($"A = {a}");
            //Console.WriteLine($"B = {b}");

            //// SWAP numeri
            //SwapNumbers(ref a, ref b);

            //Console.WriteLine($"A = {a}");
            //Console.WriteLine($"B = {b}");

            //Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            //int num1 = GetNumber();
            //int num2 = GetNumber();
            //int num3 = GetNumber();

            //int min, max, avg;

            //GetMinMaxAvg(out min, out max, out avg, num1, num2, num3);

            ////GetMinMaxAvg(out min, out max, out avg, num1, num2);

            //Log($"min = {min}");
            //Log($"max = {max}", "warn");
            //Log($"avg = {avg}", "error");
        }

        static void GetMinMaxAvg(out int min, out int max, out int avg, int a, int b, int? c = null)
        {
            if (c == null)
            {
                min = a < b ? a : b;
                max = a > b ? a : b;
                avg = (a + b) / 2;
            }
            else
            {
                // calcolo min
                if (a < b)
                {
                    if (a < c)
                        min = a;
                    else
                        min = c.Value;
                }
                else if (b < c)
                    min = b;
                else
                    min = c.Value;

                // calcolo max
                if (a > b)
                {
                    if (a > c)
                        max = a;
                    else
                        max = c.Value;
                }
                else if (b > c)
                    max = b;
                else
                    max = c.Value;

                // calcolo avg
                avg = (a + b + c.Value) / 3;
            }
        }

        static int GetNumber()
        {
            Console.WriteLine("Inserisci numero intero:");

            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch
            {
                return GetNumber();
            }
        }

        static void SwapNumbers(ref int x, ref int y)
        {
            int t = x;
            x = y;
            y = t;
        }

        static void Log(string msg, string type = "info")
        {
            if (type == "info")
                Console.WriteLine($"[{DateTime.Now:yyyyMMddHHmmss}] {msg}");
            else if (type == "error")
                Console.WriteLine($"[{DateTime.Now:yyyyMMddHHmmss}][Error] {msg}");
            else if (type == "warn")
                Console.WriteLine($"[{DateTime.Now:yyyyMMddHHmmss}][Warn] {msg}");
        }

        static int GetTotal(params int[] numbers)
        {
            int total = 0;
            foreach (int n in numbers)
                total += n;
            return total;
        }
    }
}