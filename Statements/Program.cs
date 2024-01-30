namespace MAAT03.ConditionalStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////
            // IF - ELSE IF - ELSE //
            /////////////////////////

            // taking two strings value
            string topic;
            string category;

            // taking topic name
            topic = "Inheritance";

            // using compare function of string class
            if ((string.Compare(topic, "Introduction to C#") == 0) ||
                (string.Compare(topic, "Variables") == 0) ||
                (string.Compare(topic, "Data Types") == 0))
            {
                category = "Basic";
            }

            // using compare function of string class
            else if ((string.Compare(topic, "Loops") == 0) ||
                     (string.Compare(topic, "If Statements") == 0) ||
                     (string.Compare(topic, "Jump Statements") == 0))
            {
                category = "Control Flow";
            }

            // using compare function of string class
            else if ((string.Compare(topic, "Class & Object") == 0) ||
                     (string.Compare(topic, "Inheritance") == 0) ||
                     (string.Compare(topic, "Constructors") == 0))
            {
                category = "OOPS Concept";
            }

            else
            {
                category = "Not Mentioned";
            }

            Console.Write("Category is " + category);


            ////////////
            // SWITCH //
            ////////////

            // taking two strings value
            string topic2;
            string category2;

            // taking topic name
            topic2 = "Inheritance";

            // using switch Statement
            switch (topic2)
            {
                case "Introduction to C#":
                case "Variables":
                case "Data Types":

                    category2 = "Basic";
                    break;

                case "Loops":
                case "If Statements":
                case "Jump Statements":

                    category2 = "Control Flow";
                    break;

                case "Class & Object":
                case "Inheritance":
                case "Constructors":

                    category2 = "OOPS Concept";
                    break;

                // default case 
                default:
                    category2 = "Not Mentioned";
                    break;

            }

            Console.Write("Category is " + category2);
        }
    }
}