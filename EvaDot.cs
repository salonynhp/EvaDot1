

namespace ConsoleApp1
{
    class EvaDot
    {
       public static void Main()  // Main method, entry point of the program
       {
            int i, num;  
            
            Console.Write("Enter the number to display its multiplication table : "); 
            num = Convert.ToInt32(Console.ReadLine());  

            Console.Write("\n"); 
            Console.Write("multiplication Table of "+num+" is:\n");
            for (i = 1; i <= 10; i++)  
            {
                Console.Write("{0} X {1} = {2} \n", num, i, num * i);  
            }
       }
    }
}

