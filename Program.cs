using System.Reflection;
using generics.classes;

namespace Generics;

class Program
{
    static void Main(string[] args)
    {
        TextBanner slide = new TextBanner();
        slide.Fill("This is a line");
        slide.Show();
        slide.RotateLeft();

    }
}



