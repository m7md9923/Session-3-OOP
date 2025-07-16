namespace ASS.Classes;

internal class Rectangle
{
    public int Height { get; set; }
    public int Width { get; set; }

    public Rectangle()
    {
        Width = 0;
        Height = 0;
    }
    public Rectangle(int height, int width)
    {
        Height = height;
        Width = width;
    }

    public Rectangle(int val)
    {
        Height = val;
        Width = val;
    }
}
