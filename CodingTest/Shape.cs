// *Composite pattern* - Shape class acts as composite
// Children property is collection of other Shape objects (creating a tree-like structure)
namespace CodingTest;
public class Shape
{
    public string Color { get; set; }

    public string Name { get; set; }
    public List<Shape> Children { get; set; }
       
    public Shape(string color, string name)
    {
        if (string.IsNullOrEmpty(color))
        {
            throw new ArgumentException("Color cannot be null or empty");
        }

        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Name cannot be null or empty");
        }

        Color = color;
        Name = name;
        Children = new List<Shape>();
    }
}

