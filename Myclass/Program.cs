using System;

namespace Myclass
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Vlad";
            string sourname = "Makushenko";
            Makushenko myInformation = new Makushenko(name,sourname);
            myInformation.Can(name);

            
            
            Console.ReadKey();

        }
    }
    class Makushenko
    {

        
        int age;
        float weight;


        public Makushenko( string sourname)
        {
            if ( sourname == "Makushenko")
            {
                age = 22;
                weight = 85;
            }
            else { Console.WriteLine("information  is not available"); }
        }

        public Makushenko (string name,string sourname)
             :this( sourname)
        {
            Console.WriteLine("information about me");
            Console.WriteLine($"name : {name}");
            Console.WriteLine($"sourname : {sourname}");
            Console.WriteLine($"age : {age}");
            Console.WriteLine($"weight : {weight}");
            
            


        }
        public void Can(string name)
        {
            if (name == "Vlad" )
            {
                Console.WriteLine("I live in Cherkasy");
                Console.WriteLine("I'm learning programming");
            }
            else { Console.WriteLine("information  is not available") ; }

        }



    }
}
