using System;

namespace TreehouseDefense
{
    // Creating a MapLocation object also creates a Point object
    //The Point object requires passing x and Y coordinates to the constructor in order to be created
    //MapLocation will need a construct to receive and pass the x and y coordinates to the Point constructor
    //Name the constructor the same as the class name
    //constructor takes the same parameters of the Point class
    //": base()" calls the point class contructor and passes the parameters to it
    //Base is used because the Point class is the MapLocations "base" class

    class MapLocation : Point   //: Point specifies MapLocation is a sublcass of the Point class
    {
        public MapLocation(int x, int y) : base(x,y)   //constructor  
        {
        }
    }
}
