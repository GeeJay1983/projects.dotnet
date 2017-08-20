using System.Collections.Generic;
using checklist;

namespace checklist.mvc.ViewModels
{
    public class ChecklistViewModel
    {        
        private Checklist _checklist;
        
        public ChecklistViewModel(Checklist checklist)
        {
            _checklist = checklist;
        }

        public IEnumerable<Checklist.Item> Items
        {
            get
            {
                return _checklist.GetAllItems();
            }
        }
    }
}
