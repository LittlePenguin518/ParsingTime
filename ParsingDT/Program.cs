
namespace ParsingDT
{
    public class Program
    {

        public static void Main(string[] args)
        {
            int Choice;
            Utilities getTool = new Utilities();

            Console.WriteLine("----- Welcome to Parsing Date Time App -----\n\n");

            getTool.PrintMainMenu();

            Console.WriteLine("Please enter your option");
            Choice = Convert.ToInt32(Console.ReadLine());
            int count = 1;

            DateTime result = new DateTime();
            while (Choice != 100)
            {   
                if (count != 1)
                {
                    getTool.PrintMainMenu();
                    Console.WriteLine("Please enter your option");
                    Choice = Convert.ToInt32(Console.ReadLine());
                }

                switch (Choice)
                {
                    case 1:
                        result = getTool.Parsing("now()+1d");
                        Console.WriteLine("Parsing result is " + result.ToString());
                        break;

                    case 2:
                        result = getTool.Parsing("now()-1d");
                        Console.WriteLine("Parsing result is " + result.ToString());
                        break;

                    case 3:
                        result = getTool.Parsing("now()@d");
                        Console.WriteLine("Parsing result is " + result.ToString());
                        break;

                    case 4:
                        result = getTool.Parsing("now()-1y@mon");
                        Console.WriteLine("Parsing result is " + result.ToString());
                        break;

                    case 5:
                        result = getTool.Parsing("now()+10d+12h");
                        Console.WriteLine("Parsing result is " + result.ToString());
                        break;

                    case 100:
                        break;
                }

                count++;
            }
        }

    }
}