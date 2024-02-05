namespace MAAT03.Samples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            int?[] numbersPari = new int?[numbers.Length];
            int?[] numbersDispari = new int?[numbers.Length];

            int counterPari = 0;
            int counterDispari = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int? num = null;

                while (num == null)
                {
                    try
                    {
                        Console.WriteLine("Inserisci un numero:");
                        num = int.Parse(Console.ReadLine());
                        numbers[i] = num.Value;

                        if (num % 2 == 0)
                        {
                            numbersPari[i] = num.Value;
                            counterPari++;
                        }
                        else
                        {
                            numbersDispari[i] = num.Value;
                            counterDispari++;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Il numero non è valido");
                    }
                }
            }

            //Console.WriteLine("Ci sono " + counterPari + " numeri PARI e sono:");
            //Console.WriteLine("Ci sono {0} numeri PARI e sono", counterPari);
            Console.WriteLine($"Ci sono {counterPari} numeri PARI e sono:");

            for (int i = 0; i < numbersPari.Length; i++)
            {
                if (numbersPari[i] != null)
                {
                    Console.WriteLine($"{numbersPari[i]}");
                }
            }

            Console.WriteLine($"Ci sono {counterDispari} numeri DISPARI e sono:");

            for (int i = 0; i < numbersDispari.Length; i++)
                if (numbersDispari[i] != null)
                    Console.WriteLine($"{numbersDispari[i]}");

            // STATEMENT continue

            //string text = "Ciao, sono Alessio!";

            //for (int i = 0; i < text.Length; i++)
            //{
            //    var character = text[i];

            //    if (i >= 8 && i <= 10)
            //    {
            //        continue;
            //    }

            //    Console.WriteLine(character);
            //}

            bool continuaAggiuntaNumeri = true;

            List<int> numberList = new List<int>();

            Console.WriteLine("Inserisci dei numeri... (per uscire scrivi 'quit')");

            while (continuaAggiuntaNumeri)
            {
                int? num = null;

                while (num == null)
                {
                    try
                    {
                        var value = Console.ReadLine();

                        if (value == "quit")
                        {
                            continuaAggiuntaNumeri = false;
                            break;
                        }

                        num = int.Parse(value);
                        numberList.Add(num.Value);
                    }
                    catch
                    {
                        Console.WriteLine("Il numero inserito non è valido");
                    }
                };
            }

            numberList.Insert(0, 2);
            numberList.Insert(1, 8);


            List<int> numberList2 = new List<int>();

            numberList2.Add(888);
            numberList2.Add(999);

            numberList.InsertRange(2, numberList2);

            numberList.RemoveAt(0);


            var oper = Console.ReadLine();

            List<string> allowedOp = new List<string>() { "+", "-", "*", "/" };

            //allowedOp.Add("+");
            //allowedOp.Add("-");
            //allowedOp.Add("*");
            //allowedOp.Add("/");

            if (allowedOp.Contains(oper))
            {
                foreach (int num in numberList)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
