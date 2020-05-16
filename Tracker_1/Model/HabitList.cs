using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker_1.Model
{
    [Serializable]
    class HabitList
    {

        //Лист добавления и удаления привычек
        private List<HabitTracker> _habitList;
        private static int _id;

        [NonSerialized]
        private static HabitList _habits;


        [NonSerialized]
        private static string _path;

        public List<HabitTracker> Habit { get { return new List<HabitTracker>(_habitList); } }

        private HabitList()
        {
            _habitList = new List<HabitTracker> () ;
            _id = 0;
            _path = "fin.dat";
        }

        public void AddHabit(HabitTracker habit)
        {
            habit.ID = _id++;           
            _habitList.Add(habit);

        }

        public void Delete(int id)
        {
            _habitList = _habitList.Where(i => i.ID != id).ToList();
        }

        public void AvtoDelete(DateTime EndDate)
        {
            //сегодняшняя дата  сравнить с конечной если схожа удаляем           
            _habitList = _habitList.Where(a => a.EndDate != DateTime.Now).ToList();
        }

        public static HabitList Initialize()
        {
            if (_habits == null)
            {
                _habits = new HabitList();
                Save.Load(ref _habits, _path);
            }

            return _habits;
        }

        public List<HabitTracker> GetActiveTracker()
        {
            return _habitList.Where(a => a.IsChecked == false ).ToList(); 
        }

        public void Saves()
        {
            Save.SaveLoad( _habits , _path );

        }
    }
}
