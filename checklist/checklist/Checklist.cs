using System;
using System.Collections.Generic;

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
            _itemsChecked.Add(false);
        }
        
        public void RemoveItem(int index)
        {
            _items.RemoveAt(index);
            _itemsChecked.RemoveAt(index);
        }

        public void CheckItem(int index)
        {
            _itemsChecked[index] = true;
        }
    }
}
