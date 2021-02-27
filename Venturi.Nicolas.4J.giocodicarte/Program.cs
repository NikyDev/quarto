using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venturi.Nicolas._4J.giocodicarte.models;

namespace Venturi.Nicolas._4J.giocodicarte
{
    class Program
    {
        static void Main(string[] args)
        {
            string strv1, strv2, strs1, strs2;
            int v1, v2;

            Console.WriteLine("inserisci il valore della prima carta da 2 a 14(14=asso)");
            strv1 = Console.ReadLine();
            v1 = Convert.ToInt32(strv1);
            Console.WriteLine("inserisci il seme della prima carta usando la prima lettera (C=cuori, Q=quadri, F=fiori, P=picche)");
            strs1 = Console.ReadLine();
            carta c1 = new carta(v1, strs1);
            Console.WriteLine(c1.visualizza(c1));
            Console.WriteLine("inserisci il valore della seconda carta da 2 a 14(14=asso)");
            strv2 = Console.ReadLine();
            v2 = Convert.ToInt32(strv2);
            Console.WriteLine("inserisci il seme della seconda carta usando la prima lettera (C=cuori, Q=quadri, F=fiori, P=picche)");
            strs2 = Console.ReadLine();
            carta c2 = new carta(v2, strs2);
            if (c1.vince(c1, c2))
            {
                Console.WriteLine("la prima carta vince sulla seconda");
            }
            else
            {
                Console.WriteLine("la seconda carta vince sulla prima");
            }
            Console.ReadLine();
        }
    }
}
