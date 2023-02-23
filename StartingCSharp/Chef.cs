using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartingCSharp
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The chef makes chicken");
        }
        public void MakeSalad()
        { 
            Console.WriteLine("The chef makes Salad");
        }
        public virtual void MakeSpecialDisch() 
        {
            Console.WriteLine("The chef makes bbq ribs");
        }
    }
}
