namespace CodingTest;

public class Tree
{
    private static Tree _instance;
    private Shape _root;
    private IOutputMethod _OutputMethod;

    private Tree(Shape root, IOutputMethod outputMethod)
    {
        if (root == null)
        {
            throw new ArgumentNullException(nameof(root));
        }
        
        _root = root;
        _OutputMethod = outputMethod;

        Draw(_root, 0);       

    }

    public static Tree GetInstance(Shape root, IOutputMethod outputMethod)
    {
        if (_instance == null)
        {
            _instance = new Tree(root, outputMethod);
        }
        return _instance;
    }

    private void Draw(Shape shape, int depth)
    {
        _OutputMethod.Print(shape, depth);

        // iterate through children of shape
        foreach (var child in shape.Children)
        {
            // recursion to draw children 
            Draw(child, depth + 1);
        }
    }
}

