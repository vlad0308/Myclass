using System;

namespace Myclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Makushenko avatar = new Makushenko();
            avatar.Can();

        }
    }
    class Makushenko
    {
        string name;
        string sourname;
        int old;
        float weight;

        public void Can()
        {
            Console.WriteLine($"name : {name}");
            Console.WriteLine($"sourname : {sourname}");
            Console.WriteLine($"")
        }
    }
}
