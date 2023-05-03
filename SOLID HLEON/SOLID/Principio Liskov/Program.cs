// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region Forma Correcta de hacer llamado 
IShape shape = new Triangle2();
Console.WriteLine(shape.GetSides()); // Muestra "3"
shape = new Rectangle2();
Console.WriteLine(shape.GetSides()); // Muestra "4"
#endregion

#region No Debe hacerse de esta forma
Rectangle rectangle = new Triangle();
Console.WriteLine(rectangle.GetSides()); // Muestra "3", debería mostrar "4"

public class Rectangle
{
    public virtual string GetSides()
    {
        return "4";
    }
}

public class Triangle : Rectangle
{
    public override string GetSides()
    {
        return "3";
    }
}

#endregion


#region Forma Correcta de hacerlo 



public interface IShape
{
    string GetSides();
}
public class Rectangle2 : IShape
{
    public string GetSides()
    {
        return "4";
    }
}
public class Triangle2 : IShape
{
    public string GetSides()
    {
        return "3";
    }
}
#endregion