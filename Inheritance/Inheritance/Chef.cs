using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
     class Chef
    {
        public void MakeChicken ()
        {
            Console.WriteLine("The chef makes Chicken");
        }

        public void MakeSalad ()
        {
            Console.WriteLine("The chef makes salad");
        }

        // The virtual means that it can overwritten in other sub classes
        public virtual void MakeSpecialDiet ()
        {
            Console.WriteLine("The chef makes bbq ribs");
        }
    }
}
