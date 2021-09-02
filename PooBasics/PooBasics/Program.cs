using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooBasics
{
    class Box
    {
        private int width;
        private int length;
        private int height;

        public int Width
        {
            get => width;
            
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("negative or zero value");
                }

                width = value;
            }
        }

        public int Length
        {
            get => length;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("negative or zero value");
                }

                length = value;
            }
        }

        public int Height
        {
            get => height;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("negative or zero value");
                }

                height = value;
            }
        }

        public int Volume { get => width * length * height; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Box b = new Box();
            b.Width = 2;
            b.Length = 1;
            b.Height = 3;

            Console.WriteLine($"Volume: {b.Volume}");
        }

        static void MainOld(string[] args)
        {
            //Console.WriteLine("Primer programa de consola en C#");

            int x = -10;
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"abs(x) = {Math.Abs(x)}");

            Console.WriteLine(String.Compare("HoLa", "HOLa", true));

            //char[] data = { 'h', 'o', 'l', 'a' };
            //string texto = new String(data);
            string texto = "hola";
            Console.WriteLine(texto.ToUpper());
        }
    }
}
