using System;

namespace Homework
{
    public class Rectangle : Point
    {
        /// <summary>
        /// Конструктор окружности
        /// </summary>
        /// <param name="color">цвет фигуры</param>
        /// <param name="isVisible">видимость фигуры</param>
        /// <param name="center">центр фигуры</param>
        /// <param name="topOfFigure">вершина фигуры</param>
        public Rectangle(Color color, bool isVisible, (int, int) center, (int, int) topOfFigure) :
            base(color, isVisible, center, topOfFigure)
        {

        }

        public override double GetSquare()
        {
            return Math.Sqrt(Math.Pow((double) center.Item1 - topOfFigure.Item1, 2) *
                             Math.Pow((double) center.Item2 - topOfFigure.Item2, 2));
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Площадь - {GetSquare()}");
            base.ShowInfo();
        }
    }
}
