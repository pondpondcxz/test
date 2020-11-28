using System;
using static TestFainal_01.Charecter;

namespace TestFainal_01
{
    public class SelectcCheracter
    {
        public void Selection()
        {
            
            Console.WriteLine("\n====== Please You Select, Who You Want ======");
            Console.WriteLine("=== >>(Knight)<<  >>(Mage)<<  >>(Archer)<< ==");
            Console.WriteLine("=============================================");
            Console.Write("You Selected Is :");

            while (true)
            {
               switch (Console.ReadLine())
               {
                   case "Knight" :
                       return;
                   case "Mage" :
                       return;
                   case "Archer" :
                       return;
                   case "K" :
                       goto case "Knight";
                   case "M" :
                       goto case "Mage";
                   case "A" :
                       goto case "Archer";
                   default:
                       Console.WriteLine("SORRY!! You Wrong! Please Try Again ");
                       Console.Write("You Selected Is :");
                       break;
                } 
            }
            
            
            
            
            
            
        }
    }
}