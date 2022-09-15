using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleZapros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину прямоугольника: ");
            //var height = ushort.Parse(Console.ReadLine());
            bool isWparsed = ushort.TryParse(Console.ReadLine(), out ushort Width);
            Console.Write("Введите ширину прямоугольника: ");
            //var width = ushort.Parse(Console.ReadLine());
            bool isHparsed = ushort.TryParse(Console.ReadLine(), out ushort Height);
            var x = (Console.WindowWidth-Width)/2;
            var y = (Console.WindowHeight - Height) / 2;
            var count = 1;
            Console.Clear();
            while (count <= Height)
            {
                Console.SetCursorPosition(x, y++);
                var str = new string('█', Width);
                Console.WriteLine(str);
                count++;
            }
            Console.ReadKey();
        }
    }
}
