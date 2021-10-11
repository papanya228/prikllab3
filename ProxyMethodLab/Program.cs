using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProxyMethodLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter path to file: ");
            string path = Console.ReadLine();
            var bmp = new ProxyMyBitMap(@path);
            Console.WriteLine(bmp.GetDimensions());
            Console.ReadLine();
        }
    }
}
