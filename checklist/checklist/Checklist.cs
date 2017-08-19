using System;
using System.Collections.Generic;

namespace checklist
{
    public class Checklist 
    {
        public class Item
        {
            private int _index;
            private string _value;
            private bool _checked;

            public Item(int index, string valueString, bool checkedValue)
            {
                _index = index;
                _value = valueString;
                _checked = checkedValue;
            }

            public int Index
            {
                get
                {
                    return _index;
                }
            }
            
            public override string ToString()
            {
                var checkedValue = _checked ? "[X]": "[_]";

                return $"[{_index}] {_value} {checkedValue}";
            }
        }
        
        private List<string> _items;
        private List<bool> _itemsChecked;
        
        public Checklist()
        {
            _items = new List<string>();
            _itemsChecked = new List<bool>();
        }

        public Item AddItem(string item)
        {
            _items.Add(item);
            _itemsChecked.Add(false);

            return new Item(_items.Count - 1, item, false);
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

        public IEnumerable<string> GetAllItemValues()
        {
            foreach (string item in _items) 
            {
                yield return item;
            }
        }

        public IEnumerable<Item> GetAllItems()
        {
            var index = 0;
            
            foreach (string item in _items)
            {
                yield return new Item(index, item, _itemsChecked[index++]);
            }
        }
    }
}
