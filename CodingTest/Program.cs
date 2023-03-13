using Unity;

namespace CodingTest;

public class Program
{
    public static void Main(string[] args)
    {

        var root = Factory.CreateShape("Red", "Square");
        var blueCircle = Factory.CreateShape("Blue", "Circle");
        var yellowTriangle = Factory.CreateShape("Yellow", "Triangle");
        root.Children.Add(blueCircle);
        root.Children.Add(yellowTriangle);

        var greenCircle = Factory.CreateShape("Green", "Circle");
        var redTriangle = Factory.CreateShape("Red", "Triangle");
        var blueSquare = Factory.CreateShape("Blue", "Square");
        var greenTriangle = Factory.CreateShape("Green", "Triangle");

        blueCircle.Children.Add(greenCircle);
        blueCircle.Children.Add(redTriangle);
            
        yellowTriangle.Children.Add(blueSquare);
        yellowTriangle.Children.Add(greenTriangle);

        Factory.CreateTree(root, new ConsoleOutput());
        Factory.CreateTree(root, new FileOutput());
    }
}