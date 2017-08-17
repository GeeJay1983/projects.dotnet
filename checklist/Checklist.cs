using System;

namespace checklist
{
    public class Checklist 
    {
        private List<string> _items;
        private List<bool> _itemsChecked;
        
        public Checklist()
        {
            _items = new List<string>();
            _itemsChecked = new List<bool>();
        }

        public void AddItem(string item)
        {
            _items.Add(item);
        }
        
        public void RemoveItem(int index)
        {
            _items.RemoveAt(index);
        }
    }
}
