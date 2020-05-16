using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker_1.Model
{
    [Serializable]
    class HabitTracker
    {        
        public bool IsChecked { get; set; }
        public DateTime EndDate { get; set; }
        public string Name { get; set; }
        public int ID { get; set;}

    }

    
}
