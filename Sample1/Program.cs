namespace MAAT03.Samples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[5];

            int oddCount = 0;
            int evenCount = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine("Inserisci un numero intero");
                intArray[i] = int.Parse(Console.ReadLine());

                if (intArray[i] % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }

            Console.WriteLine("");

            for (int i = intArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(intArray[i]);
            }

            // num % 2 == 0  -> pari
            // num % 2 != 0  -> dispari

            Console.WriteLine("Ci sono {0} numeri pari", evenCount);
            Console.WriteLine("Ci sono {0} numeri dispari", oddCount);

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine("Inserisci un numero intero");
                intArray[i] = int.Parse(Console.ReadLine());
            }

            foreach (int i in intArray.Reverse())
            {
                Console.WriteLine(i);
            }
        }
    }
}
