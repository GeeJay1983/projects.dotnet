using checklist;
using System;

namespace checklist.checklist.program
{
    public static class Program
    {
        internal static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var checklist = new Checklist();

            checklist.AddItem("Test item");
        }
    }
}
