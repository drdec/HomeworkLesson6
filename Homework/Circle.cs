using System;
using System.Runtime.InteropServices;

namespace Homework
{
    public class Circle : Point
    {
        /// <summary>
        /// Конструктор окружности
        /// </summary>
        /// <param name="color">цвет фигуры</param>
        /// <param name="isVisible">видимость фигуры</param>
        /// <param name="center">центр фигуры</param>
        /// <param name="topOfFigure">левая верхняя вершина фигуры</param>
        public Circle(Color color, bool isVisible, (int, int) center, (int, int) topOfFigure) :
            base(color, isVisible, center, topOfFigure)
        {

        }

        /// <summary>
        /// Возвращает радиус окружности
        /// </summary>
        /// <returns></returns>
        public override double GetSquare()
        {
            return Math.PI * Math.Sqrt((center.Item1 - topOfFigure.Item1) + (center.Item2 - topOfFigure.Item2));
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Радиус - {GetSquare()}");
            base.ShowInfo();
        }
    }
}
