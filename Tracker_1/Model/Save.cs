using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Tracker_1.Model
{
    class Save
    {
        public static void SaveLoad(HabitList fData, string path)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, fData);
                }
            }
            catch { }
        }

        public static void Load(ref HabitList fData, string path)
        {
            if (!File.Exists(path))
                return;

            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    fData = (HabitList)bf.Deserialize(fs);
                }
            }
            catch { }
        }
    }
}
