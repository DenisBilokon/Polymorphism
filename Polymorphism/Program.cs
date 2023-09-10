using System;
public abstract class Color
{
    public abstract void Describe(); //общий интерфейс для описания цветов
}

public class Red : Color
{
    public override void Describe() 
    {
        Console.WriteLine("Этот цвет - красный.");
    }
}

public class Blue : Color
{
    public override void Describe()
    {
        Console.WriteLine("Этот цвет - синий.");
    }
}

public class Green : Color
{
    public override void Describe()
    {
        Console.WriteLine("Этот цвет - зеленый.");
    }
}

class Program
{
    static void Main()
    {
        Color red = new Red();              
        Color blue = new Blue();            
        Color green = new Green();

        red.Describe();                     //полиморфизм: в зависимости от типа объекта будет вызван соответствующий метод 
        blue.Describe();                    // Describe(), что позволяет работать с разными цветами через единый интерфейс.
        green.Describe();
    }
}

