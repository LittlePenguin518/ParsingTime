
namespace ParsingDT
{
   
    public class Utilities : IUtilities
    {
 

  
        public void PrintMainMenu()
        {
            Console.WriteLine("---Main Menu ---\n");
            Console.WriteLine("Press 1 to parse now()+1d");
            Console.WriteLine("Press 2 to parse now()-1d");
            Console.WriteLine("Press 3 to parse now()@d");
            Console.WriteLine("Press 4 to parse now()-1y@mon");
            Console.WriteLine("Press 5 to parse now()+10d+12h");
            Console.WriteLine("Press 100 for exit\n");
        }

        public DateTime Parsing(string vParseVal) 
        {
            DateTime result = DateTime.Now;
            string number = string.Empty;
            if (vParseVal.Substring(0, 5) == "now()")
            {
                if (vParseVal.Substring(5, 1) == "+")
                {
                    number = getNumber(vParseVal.Remove(0,6));
                   
                    if (vParseVal.Substring(6, number.Length + 1) == "s")
                    {
                        result= result.AddSeconds(Convert.ToInt32(number));
                    }
                    if (vParseVal.Substring(6, number.Length + 1) == "m")
                    {
                        result = result.AddMinutes(Convert.ToInt32(number));
                    }
                    if (vParseVal.Substring(6, number.Length + 1) == "h")
                    {
                        result = result.AddHours(Convert.ToInt32(number));
                    }
                    if (vParseVal.Substring(6, number.Length + 1) == "d")
                    {
                        result = result.AddDays(Convert.ToInt32(number));
                    }
                    if (vParseVal.Substring(6, number.Length + 1) == "mon")
                    {
                        result = result.AddMonths(Convert.ToInt32(number));
                    }
                    if (vParseVal.Substring(6, number.Length + 1) == "y")
                    {
                        result = result.AddYears(Convert.ToInt32(number));
                    }

                }
                else if (vParseVal.Substring(5, 1) == "-")
                {
                    number = getNumber(vParseVal.Remove(0, 6));
                    if (vParseVal.Substring(6, number.Length + 1) == "s")
                    {
                        result = result.AddSeconds(-Convert.ToInt32(number));
                    }
                    if (vParseVal.Substring(6, number.Length + 1) == "m")
                    {
                        result = result.AddMinutes(-Convert.ToInt32(number));
                    }
                    if (vParseVal.Substring(6, number.Length + 1) == "h")
                    {
                        result = result.AddHours(-Convert.ToInt32(number));
                    }
                    if (vParseVal.Substring(6, number.Length + 1) == "d")
                    {
                        result = result.AddDays(-Convert.ToInt32(number));
                    }
                    if (vParseVal.Substring(6, number.Length + 1) == "mon")
                    {
                        result = result.AddMonths(-Convert.ToInt32(number));
                    }
                    if (vParseVal.Substring(6, number.Length + 1) == "y")
                    {
                        result = result.AddYears(-Convert.ToInt32(number));
                    }
                }
                else if (vParseVal.Substring(5, 1) == "@")
                {
                    if (vParseVal.Substring(6, 1) == "s")
                    {
                        result = Convert.ToDateTime(result.ToString("yyyyMMddHHmmss"));
                    }
                    if (vParseVal.Substring(6, 1) == "m")
                    {
                        result = Convert.ToDateTime(result.ToString("yyyyMMddHHmm"));
                    }
                    if (vParseVal.Substring(6, 1) == "h")
                    {
                        result = Convert.ToDateTime(result.ToString("yyyyMMddHH"));
                    }
                    if (vParseVal.Substring(6, 1) == "d")
                    {
                        result = Convert.ToDateTime(result.ToString("yyyyMMdd"));
                    }
             
                }
            }
            
            return result;
        }

        public string getNumber(string valToExtract )
        {
            string str = string.Empty;
            for (int i = 0; i < valToExtract.Length; i++)
            {
                if (Char.IsDigit(valToExtract[i])) str += valToExtract[i];
                else break;
                
            }
            return str;
        }
        
    }
}
