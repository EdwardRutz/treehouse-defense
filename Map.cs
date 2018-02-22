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
    }
}