using System;

namespace Homework
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var temp = new Circle(Color.Black, true, (5, 5), (1, 1));

            temp.ShowInfo();
        }
    }
}
