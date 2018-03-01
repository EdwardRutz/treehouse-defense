using System; //allows use of System methods such as Console.WriteLine

namespace TreehouseDefense
{
    class Game
    {
        public static void Main()  //Static Method
        {
            //The Map class defines what it means to be a Map
            //To access the map fields, create a map object
            //Now can access the field using dot notation
            //map.width can be used like a variable and assign a value
            //Create a variable area and assign it the area of the grid
            //Pass in arguements to constructor to initialize it with a width of 8 and height of 5

            Map map = new Map(8, 5);

            Point x = new MapLocation(4, 2);  //MapLocation is a subclass of point
            //Refactor: MapLocation x = new MapLocation(4, 2);  //refactored to assign a point to it
            //Refactor: Point point = new Point(4,2);   //create a point on the map
            //The Point and MapLocation classes have an "is" relationship because MapLocation is a Point

            Point p = x;
            map.OnMap(new MapLocation(0, 0));

            Console.WriteLine(x.DistanceTo(5, 5));  //refactored, Result: 3
            //refactor:  Console.WriteLine(point.DistanceTo(5,5));

            Console.WriteLine(x is MapLocation);        //type check, Result: True
            Console.WriteLine(x is Point);          //type check, True

            Point point = new Point(0, 0);
            Console.WriteLine(point is MapLocation);    //type check, Result: False
         }
    }
}