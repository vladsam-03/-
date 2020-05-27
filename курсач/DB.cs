using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace курсач
{
    public class DB
    {
        public List<Type> types = new List<Type>();
        public List<Towar> towars = new List<Towar>();
        public List<Postavshik> postavshiks = new List<Postavshik>();//поставшик и заказчик
        public List<Zakashik> zakashiks = new List<Zakashik>();
        public List<History> historys = new List<History>();
        static BinaryFormatter BF = new BinaryFormatter();
        public DB()
        {
            if (!File.Exists("db.db"))
                return;
            using (FileStream fs = new FileStream("db.db", FileMode.Open, FileAccess.Read))
            {
                types = ((List<Type>)BF.Deserialize(fs));
                towars = ((List<Towar>)BF.Deserialize(fs));
                postavshiks = ((List<Postavshik>)BF.Deserialize(fs));
                zakashiks = ((List<Zakashik>)BF.Deserialize(fs));
                historys = ((List<History>)BF.Deserialize(fs));
            }
        }
        public void Save()
        {
            using (FileStream fs = new FileStream("db.db", FileMode.Create, FileAccess.Write))
            {
                BF.Serialize(fs, types);
                BF.Serialize(fs, towars);
                BF.Serialize(fs, postavshiks);
                BF.Serialize(fs, zakashiks);
                BF.Serialize(fs, historys);
            }
        }
        public void a(Postavshik postavshik,Towar towar, int kolishestvo)
        {
            History history = new History();
            history.kto = postavshik.Name;
            history.skoka = kolishestvo.ToString();
            string s = $"Завезён {towar.Name}";
            history.chto = s;
            historys.Add(history);
            Save();

        }
        public void b(Zakashik postavshik, Towar towar, int kolishestvo)
        {
            History history = new History();
            history.kto = postavshik.Name;
            history.skoka = kolishestvo.ToString();
            string s = $"Вывезен {towar.Name}";
            history.chto = s;
            historys.Add(history);
            Save();

        }
    }
}