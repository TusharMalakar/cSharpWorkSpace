using System;

namespace cSharpConsole{
    class Program 
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Linked List is running...");
            linkedList list = new linkedList();
            
            list.insert("jonson");
            list.insert("Mick");
            list.insert("Tushar");
            Console.WriteLine(list);
        }
    }
}
