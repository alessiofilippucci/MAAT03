namespace Sample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool run = true;

            while (run)
            {
                StartCalculator();

                Console.WriteLine("Voi fare altri calcoli? (si, no)");
                run = Console.ReadLine() == "si";
            }
        }

        static void StartCalculator()
        {
            Console.WriteLine("Benvenuto nella mia calcolatrice!");

            // richiesta operazione da effettuare
            string op = GetOperator();

            // richiesta 1° numero
            int num1 = GetNumber();

            // richiesta 2° numero
            int num2 = GetNumber();

            // esecuzione del calcolo
            int res = Calc(op, num1, num2);

            // output risultato
            ShowResult(op, num1, num2, res);
        }

        static string GetOperator()
        {
            string[] allowedOp = { "+", "-", "*", "/" };

            string op = "";

            while (!allowedOp.Contains(op))
            {
                Console.WriteLine("Scegli tra {0}", string.Join(",", allowedOp));
                op = Console.ReadLine();
            }

            return op;
        }

        static int GetNumber()
        {
            // richiesta numero

            int? num = null;

            while (num == null)
            {
                Console.WriteLine("Inserisci un numero intero");
                try
                {
                    num = int.Parse(Console.ReadLine());
                }
                catch { }
            }

            return num.Value;
        }

        static int Calc(string op, int num1, int num2)
        {
            int res = 0;

            switch (op)
            {
                case "+":
                    {
                        Sum(num1, num2);
                        break;
                    }
                case "-":
                    {
                        Diff(num1, num2);
                        break;
                    }
                case "*":
                    {
                        Mult(num1, num2);
                        break;
                    }
                case "/":
                    {
                        Div(num1, num2);
                        break;
                    }
            }

            return res;
        }

        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Diff(int num1, int num2)
        {
            return num1 - num2;
        }

        static int Mult(int num1, int num2)
        {
            return num1 * num2;
        }

        static int Div(int num1, int num2)
        {
            if (num2 == 0)
                throw new Exception("Cannot divide by 0");
            return num1 / num2;
        }

        static void ShowResult(string op, int num1, int num2, int res)
        {
            Console.WriteLine("{0} {1} {2} = {3}", num1, op, num2, res);
        }
    }
}
