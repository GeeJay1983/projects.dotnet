using checklist;
using System;

namespace checklist.checklist.program
{
    public static class Program
    {
        internal static void Main(string[] args)
        {
            var checklist = new Checklist();

            var item1 = checklist.AddItem("Toilettas");
            var item2 = checklist.AddItem("Babyspulletjes");

            checklist.CheckItem(item2.Index);

            var items = checklist.GetAllItems();

            foreach (var item in items)
            {          
                Console.WriteLine(item);
            }
        }
    }
}
