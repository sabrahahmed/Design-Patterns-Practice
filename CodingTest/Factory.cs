using CodingTest;

// Factory Method Pattern
public static class Factory
{
    public static Shape CreateShape(string color, string name)
    {
        return new Shape(color, name);
    }

    // Singleton pattern
    public static Tree CreateTree(Shape root, IOutputMethod outputMethod)
    {
        return Tree.GetInstance(root, outputMethod);
    }
}