using System.Reflection;
using generics.classes;

namespace Generics;

class Program
{
    static void Main(string[] args)
    {
        Banner banner1 = [];
        banner1.Isert(" This ");
        banner1.Isert(" is ");
        banner1.Isert(" a ");
        banner1.Show();
        banner1.RotateLeft();
        banner1.Isert(" Sentence ");
        banner1.Show();
        banner1.RotateRight();
        banner1.RotateRight();
        banner1.Show();


    }
}



