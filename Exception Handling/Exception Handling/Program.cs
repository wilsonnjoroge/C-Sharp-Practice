using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = num1 / num2;
                Console.Write(Convert.ToString(result));

            } catch (DivideByZeroException e)
            {

                Console.Write( e.Message );

            } catch( FormatException e)
            {
                
                Console.Write(e.Message);
               
            } catch( Exception e )
            {
                Console.Write(e.Message);
            }



            Console.ReadLine();
            
        }
    }
}
