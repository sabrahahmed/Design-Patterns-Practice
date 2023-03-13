namespace CodingTest;
public interface IOutputMethod
{
    void Print(Shape shape, int depth);
}

public class ConsoleOutput : IOutputMethod
{
    public void Print(Shape shape, int depth)
    {
        Console.WriteLine($"{depth} {shape.Color} {shape.Name}");
    }
}

public class FileOutput : IOutputMethod
{
    public void Print(Shape shape, int depth)
    {
        File.AppendAllText(@"C:\tree_shapes.txt", $"{depth} {shape.Color} {shape.Name}\n");
    }
}