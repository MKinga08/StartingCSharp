using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartingCSharp
{
    class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("The chef makes Pasta");
        }
        public override void MakeSpecialDisch()
        {
            Console.WriteLine("The chef makes something special");
        }
    }
}
