namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(0, 2, true)); 
        }

        //Step 1
        public static int Add(int num1, int num2)
        {

            return num1 + num2;

        }


        //Step 2
        public static decimal Add(decimal num1, decimal num2)
        {

            return num1 + num2;


        }


        //Step 3
        public static string Add(int num1, int num2, bool isMoney)
        {
            if (isMoney == true && num1 + num2 > 1) 
            {
                return $"{num1 + num2} dollars";
            }

            else if (isMoney == true && num1 + num2 == 1)
            {
                return $"{num1 + num2} dollar";
            }
            else
            {
                return $"{num1+num2}";
            }
           
           

        }



    }
}
