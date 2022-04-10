using System;

namespace Homework
{
    public abstract class Point : Figure
    {

        /// <summary>
        /// Конструктор окружгости
        /// </summary>
        /// <param name="color">цвет фигуры</param>
        /// <param name="isVisible">видимость фигуры</param>
        /// <param name="center">центр фигуры</param>
        /// <param name="topOfFigure">левая верхняя вершина фигуры</param>
        protected Point(Color color, bool isVisible, (int, int) center, (int, int) topOfFigure)
        {
            this.color = color;
            this.isVisible = isVisible;
            this.center = center;
            this.topOfFigure = topOfFigure;
        }

        /// <summary>
        /// Перемещение фигуры по горизонтали
        /// </summary>
        /// <param name="x">на сколько сместить фигуру</param>
        public void MoveFigureHorizontal(int x)
        {
            topOfFigure.Item1 += x;
            center.Item1 += x;
        }

        /// <summary>
        /// смещение фигуры по вертикали
        /// </summary>
        /// <param name="y">на сколько сместить фигуру</param>
        public void MoveFigureVertical(int y)
        {
            topOfFigure.Item2 += y;
            center.Item2 += y;
        }

        /// <summary>
        /// Меняет состояние фигуры
        /// </summary>
        /// <param name="visible">видимость</param>
        public virtual void SetVisible(bool visible)
        {
            isVisible = visible;
        }

        /// <summary>
        /// Меняет цвет фигуры
        /// </summary>
        /// <param name="color">цвет фигуры</param>
        public void SetColorFigure(Color color)
        {
            this.color = color;
        }

        /// <summary>
        /// Вывод информации об объекте
        /// </summary>
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Цвет - {color}\n" +
                              $"Фигура видима - {isVisible}\n" +
                              $"Центр фигру  - {center}\n" +
                              $"Координата вершины x - {topOfFigure.Item1}\n" +
                              $"Координата вершины y - {topOfFigure.Item2}\n");
        }

        public abstract double GetSquare();
    }
}
