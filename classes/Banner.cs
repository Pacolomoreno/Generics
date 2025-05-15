using System.Collections;
using generics.interfaces;
namespace generics.classes;

public class Banner : Ring<string>, IRotable, IPrintable
{
    public void Show()
    {
        foreach (var item in _ring)
        {
            Console.Write($" {item}");
        }
        Console.WriteLine();
    }
}

