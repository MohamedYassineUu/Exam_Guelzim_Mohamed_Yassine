using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Guelzim_Mohamed_Yassine
{
    internal class AdministrateurDao
    {   
        string FileAdministrateur = "C:\\Users\\yassg\\OneDrive\\Documents\\cSharp\\Exam_Guelzim_Mohamed_Yassine\\CSV\\Administrateurs.csv";
        private string Anom;
        public void AddAdministrateur(int Administrateurid, string Anom, string Aprenom, string Apassword)
        {            
            StreamWriter sw = new StreamWriter(FileAdministrateur, true);
            sw.WriteLine(Administrateurid + "," + Anom + "," + Aprenom + "," + Apassword);
            sw.Close();
        }

        public bool FindAdministrateur(string nom, string password)
        {
            StreamReader sd = new StreamReader(FileAdministrateur);
            string line = sd.ReadLine();
            while (line != null)
            {
                string[] dd = line.Split(",");
                if (dd[1] == nom && dd[3] == password)
                {
                    sd.Close();
                    return true;

                }
                line = sd.ReadLine();
            }
            sd.Close();
            return false;
        }
    }
}
