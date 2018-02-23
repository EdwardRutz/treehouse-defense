namespace TreehouseDefense
{
    class Map
    {
        //These are instance variables because they exist as long as the object exists
        //Instance variables can be used by other variables and classes
        //Make the values read only so user can't change

        public readonly int Width;
        public readonly int Height;

        //Constructor method
        //User needs to specify the parameters for width and height
        //These variables with lower case are called method level variables because they only exist inside this method or "variable scope"
        //Method variables can only be used by the specific method the variables are located in
        //Make the constructor public so other classes can use it

        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }

        //OnMap method takes a point as a parameter and returns true if it is on the map and false if it is not
        //The OnMap method will return a boolean value, true or false.
        //The method is public and can be called outside the map class
        //The variable inBounds will hold the return value of the method

        public bool OnMap(Point point)
        {
            bool inBounds = point.X >= 0 && point.X < Width && point.Y < Height;

            return inBounds;
        }



    }
}