using System.Reflection;
using generics.classes;

namespace Generics;

class Program
{
    static void Main(string[] args)
    {
        Banner banner1 = [];
        banner1.Push(" This ");
        banner1.Push(" is ");
        banner1.Push(" a ");
        banner1.Show();
        banner1.RotateLeft();
        banner1.Push(" Sentence ");
        banner1.Show();
        banner1.RotateRight();
        banner1.RotateRight();
        banner1.Show();


    }
}



