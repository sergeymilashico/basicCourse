namespace Logic
{
public struct Square
{
    public int SideLength { get; private set;}

    public int X { get; private set;}

    public int Y { get; private set;}

    
    public Square(int sideLength, int x, int y)
    {
        X = x;
        Y = y;
        SideLength = sideLength;
    }

    public double GetArea()
    {
        return Math.Pow(SideLength, 2);
    }
}
}