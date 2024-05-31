namespace SetGet
{
    class Rectangle
    {
        private int width;
        private int height;



        public int Width
        {
            set 
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("Enter +ve value");
                }
            }
            get
            {
                return width;
            }
        }

        public int Height
        {
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("Enter +ve value");
                }
            }
            get
            {
                return height;
            }
        }

        public int RectArea
        {
            get
            {
                return width * height;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.Width = 10;
            r1.Height = 10;

            int result = r1.Width * r1.Height;

            Console.WriteLine("Area is {0}",result);
        }
    }
}
