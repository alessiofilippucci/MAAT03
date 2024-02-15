namespace Sample4
{
    internal class Calcolatrice
    {
        List<float> nums;
        public float result;

        public Calcolatrice()
        {
        }

        // metodo Somma
        public void Somma(bool printResult = false)
        {
            result = num1 + num2;
            if (printResult)
                PrintResult("+");
        }

        // metodo Differenza
        public void Differenza(bool printResult = false)
        {
            result = num1 - num2;
            if (printResult)
                PrintResult("-");
        }

        // metodo Moltiplicazione
        public void Moltiplicazione(bool printResult = false)
        {
            result = num1 * num2;
            if (printResult)
                PrintResult("*");
        }

        // metodo Divisione
        public void Divisione(bool printResult = false)
        {
            if (num1 == 0 && num2 == 0)
                throw new Exception("Divisione per 0 è indefinita");

            if (num2 == 0)
                throw new Exception("Divisione per 0 è impossibile");

            result = num1 / num2;
            if (printResult)
                PrintResult("/");
        }

        private void PrintResult(string op)
        {
            Console.WriteLine($"{num1} {op} {num2} = {result}");
        }
    }
}
