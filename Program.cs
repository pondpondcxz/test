
using TestFainal_01;


namespace TestFainal_01
{
    
    internal class Program
    {
        public static void Main()
        {
           var selectiion = new SelectcCheracter();
           selectiion.Selection();
           
            
           var Player1 = new Charecter.Knight(100,80,0,30, "Sword",false,5);
           Player1.ShowOverAllCheracter();
           
           
        }
    }
}