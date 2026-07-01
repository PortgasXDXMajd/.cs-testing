

class Box(int height, int width)
{
    public int Height { get; set; } = height;
    public int Width { get; set; } = width;
}

class BoxComparer : IEqualityComparer<Box> // we can use Box as record and get the semantic equality for free, but this is just an example of how to implement IEqualityComparer
{
    public bool Equals(Box? x, Box? y)
    {
        if (x is null || y is null)
            return false;

        return x.Height == y.Height && x.Width == y.Width;
    }

    public int GetHashCode(Box obj)
    {
        return HashCode.Combine(obj.Height, obj.Width);
    }
}