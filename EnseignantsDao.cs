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

    }
}
