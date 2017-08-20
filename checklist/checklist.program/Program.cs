using checklist;
using System;

namespace checklist.checklist.program
{
    public static class Program
    {
        internal static void Main(string[] args)
        {
            // Maak een nieuwe lijst aan
            var checklist = new Checklist();

            // Zet er toilettas op
            var toilettasItem = checklist.AddItem("Toilettas");
            // Zet er luiers op
            var luiersItem = checklist.AddItem("Luiers");
            // Zet er nachtluiers op
            var nachtluiersItem = checklist.AddItem("Nachtluiers");
            // Zet er flesjes op
            var flesjesItem = checklist.AddItem("Flesjes");

            // Vink de luiers af
            checklist.CheckItem(luiersItem.Index);
            // Vink de flesjes af
            checklist.CheckItem(flesjesItem.Index);

            var stop = false;

            while (!stop)
            {
            
                // Vraag alle items van de lijst op
                var items = checklist.GetAllItems();

                // Toon elk item op het scherm
                foreach (var item in items)
                {          
                    Console.WriteLine(item);
                }

                Console.Write("Voer iets in om toe te voegen ('stop' om te stoppen): ");
                var newItem = Console.ReadLine();

                if (newItem == "stop") 
                {
                    stop = true;
                }
                
                checklist.AddItem(newItem);
            }
        }
    }
}
