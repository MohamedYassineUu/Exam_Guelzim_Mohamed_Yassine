using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Guelzim_Mohamed_Yassine
{
    internal class EnseignantsDao
    {
        string fileEnseignant = "C:\\Users\\yassg\\OneDrive\\Documents\\cSharp\\Exam_Guelzim_Mohamed_Yassine\\CSV\\Enseignants.csv";

        public void AddEnseignant(int Enseignantid, string Enom, string Eprenom, string Epassword)
        {
            StreamWriter sw = new StreamWriter(fileEnseignant, true);
            sw.WriteLine(Enseignantid + "," + Enom + "," + Eprenom + "," + Epassword);
            sw.Close();
        }
        public string[] FindEnseignant(string nom, string password)
        {
            StreamReader sd = new StreamReader(fileEnseignant);
            string line = sd.ReadLine();
            while (line != null)
            {
                string[] dd = line.Split(",");
                if (dd[1] == nom && dd[3] == password)
                {
                    sd.Close();
                    return dd;

                }
                line = sd.ReadLine();
            }
            sd.Close();
            return null;
        }
        public List<Enseignants> AllEnseignants()
        {
            List<Enseignants> es = new List<Enseignants>();
            StreamReader sd = new StreamReader(fileEnseignant);
            string line = sd.ReadLine();
            while (line != null)
            {
                string[] dd = line.Split(",");

                Enseignants e = new Enseignants();
                e.Enseignantid1 = Int32.Parse(dd[0]);
                e.Enom1 = dd[1];
                e.Eprenom1 = dd[2];
                e.Epassword1 = dd[3];
                es.Add(e);
                line = sd.ReadLine();
            }
            sd.Close();
            return es;
        }
        public void SupprimerEnseignantParId(int id)
        {
            List<string> lignes = new List<string>();


            StreamReader sr = new StreamReader(fileEnseignant);
            string line = sr.ReadLine();

            while (line != null)
            {
                string[] dd = line.Split(",");

                if (Int32.Parse(dd[0]) != id)
                {

                    lignes.Add(line);

                }

                line = sr.ReadLine();
            }
            sr.Close();

            StreamWriter sw = new StreamWriter(fileEnseignant, false);
            foreach (string l in lignes)
            {
                sw.WriteLine(l);
            }
            sw.Close();
        }
        public Enseignants findEnseignanttById(int id)
        {
            Enseignants e = null;

            StreamReader sd = new StreamReader(fileEnseignant);
            string line = sd.ReadLine();
            while (line != null)
            {
                string[] dd = line.Split(",");
                if (Int32.Parse(dd[0]) == id)
                {
                    e = new Enseignants();
                    e.Enseignantid1 = id;
                    e.Enom1 = dd[1];
                    e.Eprenom1 = dd[2];
                    e.Epassword1 = dd[3];
                    break;
                }
                line = sd.ReadLine();
            }
            sd.Close();
            return e;
        }

    }
}
