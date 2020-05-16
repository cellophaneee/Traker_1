using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker_1.Model;
namespace Tracker_1.Controller
{
    [Serializable]
    class ControllerFormCreate
    {
        private HabitList _habits;
        private FormCreate _form;



        public ControllerFormCreate(FormCreate sender)
        {
            _form = sender;
            _habits = HabitList.Initialize();                    
        }

        public  bool AddTracker()
        {
            if (_form.dateTimeEnd.Value < DateTime.Now || _form.textBoxName.Text.Trim() == "")
                return false;

                _habits.AddHabit(new HabitTracker() { Name = _form.textBoxName.Text, EndDate = _form.dateTimeEnd.Value, IsChecked = false  });
            
            return true;

           
        }
        
    }
}
