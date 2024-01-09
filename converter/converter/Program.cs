using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of liters");
            int liters = 0;
            int.TryParse(Console.ReadLine(), out liters);
            Console.WriteLine("Select Units!");
            Console.WriteLine("1)ounces\n2)gills\n3)pints\n4)quarts\n5)gallons\n6)tablespoons\n7)teaspoons\n8)cups");
            int num=0;
            int.TryParse(Console.ReadLine(), out num);
            /* 
             if (num == 1)
             Console.WriteLine(meters* 3.2808 +"feet");
             if (num == 2)
                 Console.WriteLine(1.09361 * meters + "yards");

 */
            switch (num)
            {
                case 1:
                    Console.Write("\t" + liters * 33.814+" ounces");
                    break;

                    case 2:
                    Console.Write("\t" + liters * 8.45351 + " gills");
                        break;
                case 3:
                    Console.Write("\t" + liters * 2.11338 + " pints");
                    break;
                case 4:
                    Console.Write("\t" + liters * 1.05669 + " quarts");
                    break;
                case 5:
                    Console.Write("\t" + liters * 0.264172 + " gallons");
                    break;
                case 6:
                    Console.Write("\t" + liters * 67.628 + " tablespoons");
                    break;
                case 7:
                    Console.Write("\t" + liters * 202.884 + " teaspoons");
                    break;
                case 8:
                    Console.Write("\t" + liters * 4.22675 + " cups");
                    break;

                default:
                    Console.WriteLine("Invalid Units!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
