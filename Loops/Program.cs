namespace MAAT03.Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///////////
            // WHILE //
            ///////////

            int x = 1;

            // Exit when x becomes greater than 4
            while (x <= 4)
            {
                Console.WriteLine("HelloWorld");

                // Increment the value of x for
                // next iteration
                x++;
            }


            /////////
            // FOR //
            /////////

            // for loop begins when i=1
            // and runs till i <= 4
            for (int i = 1; i <= 4; i++)
                Console.WriteLine("{0} - HelloWorld", i);



            //////////////
            // DO WHILE //
            //////////////

            int y = 21;
            do
            {
                // The line will be printed even
                // if the condition is false
                Console.WriteLine("{0} - HelloWorld", y);
                y++;
            }
            while (y < 20);
        }
    }
}
