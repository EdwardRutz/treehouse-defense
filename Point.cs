using System; //Allows the use of System methods such as System.Math.Sqrt

namespace TreehouseDefense
{
    class Point
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        //Calculate how far points are from each other using the cartesian distance formula

        public int DistanceTo(int x, int y)
        {
            return (int)Math.Sqrt(Math.Pow(X-x, 2) + Math.Pow(Y-y, 2)); //Refactored from below

           /*
           //Refactored the below code
           int xDiff = X - x; //Get differences between two points
           int yDiff = Y - y;

           int xDiffSquared = xDiff * xDiff;
           int yDiffSquared = yDiff * yDiff;

           return (int)Math.Sqrt(xDiffSquared + yDiffSquared);  //Returns a double so use (int) to truncate
           */
        }
    }
}