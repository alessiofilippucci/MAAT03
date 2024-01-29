namespace ConditionalStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Inserisci l'operazione da effettuare (+,-,*,/):");
                string op = Console.ReadLine();

                if (op == "+" || op == "-" || op == "*" || op == "/")
                {
                    int res = 0;

                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case "+":
                            {
                                res = num1 + num2;
                                Console.WriteLine("Hai scelto la Somma " + num1);
                                break;
                            }
                        case "-":
                            {
                                res = num1 - num2;
                                Console.WriteLine("Hai scelto la Sottrazione");
                                break;
                            }
                        case "*":
                            {
                                res = num1 * num2;
                                Console.WriteLine("Hai scelto la Moltiplicazione");
                                break;
                            }
                        case "/":
                            {
                                res = num1 / num2;
                                break;
                            }
                    }

                    //Console.WriteLine(num1 + " " + op + " " + num2 + " = " + res);
                    Console.WriteLine("{0} {1} {2} = {3}", num1, op, num2, res);
                }
                else
                {
                    Console.WriteLine("Operazione non valida");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}