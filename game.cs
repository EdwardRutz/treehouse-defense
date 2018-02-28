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
            
            Point point = new Point(4,2);   //create a point on the map

            Console.WriteLine(point.DistanceTo(5,5));
         }
    }
}