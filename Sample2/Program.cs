namespace Sample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] allowedOp = { "+", "-", "*", "/" };

            // richiesta operazione da effettuare
            string op = "";

            // while (op != "+" && op != "-")
            while (!allowedOp.Contains(op))
            {
                Console.WriteLine("Scegli tra {0}", string.Join(",", allowedOp));
                op = Console.ReadLine();
            }

            // richiesta 1° numero

            int? num1 = null;

            while (num1 == null)
            {
                Console.WriteLine("Inserisci un numero intero");
                try
                {
                    num1 = int.Parse(Console.ReadLine());
                }
                catch { }
            }

            // richiesta 2° numero

            int? num2 = null;

            while (num2 == null)
            {
                Console.WriteLine("Inserisci un altro numero intero");
                try
                {
                    num2 = int.Parse(Console.ReadLine());
                }
                catch { }
            }

            // esecuzione del calcolo

            int? res = null;

            switch (op)
            {
                case "+":
                    {
                        res = num1 + num2;
                        break;
                    }
                case "-":
                    {
                        res = num1 - num2;
                        break;
                    }
                case "*":
                    {
                        res = num1 * num2;
                        break;
                    }
                case "/":
                    {
                        res = num1 / num2;
                        break;
                    }
            }

            // output risultato

            Console.WriteLine("{0} {1} {2} = {3}", num1, op, num2, res);
        }
    }
}
