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
        /// <param name="topOfFigure">левая верхняя вершина фигуры</param>
        public Rectangle(Color color, bool isVisible, (int, int) center, (int, int) topOfFigure) :
            base(color, isVisible, center, topOfFigure)
        {

        }


    }
}
