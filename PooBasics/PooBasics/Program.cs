using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooBasics
{
    interface IBoxeable
    {
        int Volume { get; }

        void DoubleSize();
    }

    class Box : ICloneable, IBoxeable, IComparable
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

        public int Volume => width * length * height;

        // default constructor
        public Box() : this(1) { }

        public Box(int size) : this(size, size, size) {}

        public Box(int width, int length, int height)
        {
            Width = width;
            Length = length;
            Height = height;
        }

        // copy constructor
        public Box(Box box) : this(box.width, box.length, box.height) {}

        public void DoubleSize()
        {
            Width *= 2;
            Length *= 2;
            Height *= 2;
        }

        // Clone(Box this)
        public object Clone() => new Box(this);

        public int CompareTo(object obj) =>
            Volume.CompareTo((obj as Box).Volume);
    }

    class Program
    {
        static void Main(string[] args)
        {
            Box b1 = new Box(4, 2, 3);

            IBoxeable b3 = b1;
            Console.WriteLine($"Volume: {b3.Volume}");

            ICloneable c1 = b1;
            //c1.Clone();

            IComparable c2 = b1;
            //c2.CompareTo(null);

            // *********************************

            Box b2 = (Box)b1.Clone(); // Clone(b1)

            Box[] boxes =
            {
                new Box(1, 3, 5),
                new Box(3),
                new Box(),
                new Box(3, 2, 1),
                new Box(b1)
            };

            Array.Sort(boxes);

            foreach (Box box in boxes)
            {
                Console.WriteLine($"Volume: {box.Volume}");
            }

            int totalVolume = 0;
            foreach (Box box in boxes)
            {
                totalVolume += box.Volume;
            }

            Console.WriteLine($"\nTotal volume: {totalVolume}");
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
