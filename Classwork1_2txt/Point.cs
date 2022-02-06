namespace Classwork1_2txt
{
    internal class Point
    {
        private int _x;
        private int _y;
        public static int CountInstance;

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
            CountInstance++;
        }

        public int X => _x;

        public int Y => _y;        

        //Расстояние между двумя точками
        public static double LengthPoints(Point point1, Point point2)
          => Math.Sqrt((point1.X - point2.X) * (point1.X - point2.X) + 
              (point1.Y - point2.Y) * (point1.Y - point2.Y));
    }
}
