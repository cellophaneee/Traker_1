using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker_1.Model;
using Tracker_1.Controller;
namespace Tracker_1.Controller
{
    [Serializable]
    class ControllerFormMain
    {
        private FormMain _form;
        private HabitList _habits;
        

        private List<HabitTracker> _habitList;
        public List<HabitTracker> Habit { get { return new List<HabitTracker>(_habitList); } }

        public ControllerFormMain(FormMain sender)
        {
            _habits = HabitList.Initialize();
            _form = sender;
            _habitList = new List<HabitTracker>();
            
        }

      

        public void AvtoDelete(DateTime EndDate)
        {
            _habits.AvtoDelete(EndDate);
        }

        public void UpdateDataGried()
        {             
            _form.dataGridViewTracker.DataSource = null;
            _form.dataGridViewTracker.DataSource = _habits.GetActiveTracker();

            _form.dataGridViewTracker.Columns["ID"].Visible = false;
            _form.dataGridViewTracker.Columns["Name"].HeaderText = "Название привычки";
            _form.dataGridViewTracker.Columns["EndDate"].HeaderText = "Будет удалена";
            _form.dataGridViewTracker.Columns["IsChecked"].HeaderText = "Выполнил?";

            _form.dataGridViewTracker.Columns["IsChecked"].DisplayIndex = 2;
            _form.dataGridViewTracker.Columns["Name"].DisplayIndex = 0;
            _form.dataGridViewTracker.Columns["EndDate"].DisplayIndex = 1;
           
        }


        public void Delete()
        {
            if (_form.dataGridViewTracker.SelectedRows.Count == 0)
                return;

            _habits.Delete(((HabitTracker)_form.dataGridViewTracker.SelectedRows[0].DataBoundItem).ID);
        }
        public void Saves()
        {
            _habits.Saves();

        }
       


    }
}
