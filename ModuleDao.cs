using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Guelzim_Mohamed_Yassine
{
    internal class ModuleDao
    {
        string FileModule = "C:\\Users\\yassg\\OneDrive\\Documents\\cSharp\\Exam_Guelzim_Mohamed_Yassine\\CSV\\Module.csv";

        public void AddModule(int Moduleid, string NomModule, int Etudiantid)
        {
            StreamWriter sw = new StreamWriter(FileModule, true);
            sw.WriteLine(Moduleid + "," + NomModule + "," + Etudiantid);
            sw.Close();
        }
        public class EtudiantAffichage
        {
            public string Nom { get; set; }
            public string Prenom { get; set; }
            public string NomModule { get; set; }
        }
        public List<EtudiantAffichage> findEtudiantsByModule(string nomModule)
        {
            List<EtudiantAffichage> listeAffichage = new List<EtudiantAffichage>();

            StreamReader sr = new StreamReader(FileModule);
            string line = sr.ReadLine();

            while (line != null)
            {
                string[] dd = line.Split(",");
                string moduleName = dd[1];
                int etudiantId = Int32.Parse(dd[2]);

                if (moduleName == nomModule)
                {
                    EtudientDao eDao = new EtudientDao();
                    Etudiants e = eDao.findEtudiantById(etudiantId);
                    if (e != null)
                    {
                        listeAffichage.Add(new EtudiantAffichage
                        {
                            Nom = e.Nom,
                            Prenom = e.Prenom,
                            NomModule = moduleName
                        });
                    }
                }
                line = sr.ReadLine(); 
            }
            return listeAffichage;
            sr.Close();
        }


    }
}
