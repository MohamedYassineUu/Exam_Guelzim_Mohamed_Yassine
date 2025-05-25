using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exam_Guelzim_Mohamed_Yassine.ExamDao;

namespace Exam_Guelzim_Mohamed_Yassine
{
    internal class ModuleDao
    {
        string FileModule = "C:\\Users\\yassg\\OneDrive\\Documents\\cSharp\\Exam_Guelzim_Mohamed_Yassine\\CSV\\Module.csv";

        public void AddModule(int Moduleid, string NomModule, int Etudiantid, int Eseignantid)
        {
            StreamWriter sw = new StreamWriter(FileModule, true);
            sw.WriteLine(Moduleid + "," + NomModule + "," + Etudiantid + "," + Eseignantid);
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

        public void SupprimerMatiereParId(int id)
        {
            List<string> lignes = new List<string>();


            StreamReader sr = new StreamReader(FileModule);
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

            StreamWriter sw = new StreamWriter(FileModule, false);
            foreach (string l in lignes)
            {
                sw.WriteLine(l);
            }
            sw.Close();
        }

        public List<Module> AllModule()
        {
            List<Module> es = new List<Module>();
            StreamReader sd = new StreamReader(FileModule);
            string line = sd.ReadLine();
            while (line != null)
            {
                string[] dd = line.Split(",");

                Module e = new Module();
                e.Moduleid = Int32.Parse(dd[0]);
                e.NomModule = dd[1];
                e.Etudiantid = Int32.Parse(dd[2]);
                e.Eseignantid = Int32.Parse(dd[3]);
                es.Add(e);
                line = sd.ReadLine();
            }
            sd.Close();
            return es;
        }

        public void AffecterEnseignantAModule(string nomModule, int enseignantId)
        {
            List<string> nouvellesLignes = new List<string>();

            StreamReader sr = new StreamReader(FileModule);
            string line = sr.ReadLine();

            while (line != null)
            {
                string[] dd = line.Split(",");

                if (dd[1] == nomModule)
                {
                    dd[3] = enseignantId.ToString();
                }

                string nouvelleLigne = string.Join(",", dd);
                nouvellesLignes.Add(nouvelleLigne); 

                line = sr.ReadLine();
            }

            sr.Close();

            StreamWriter sw = new StreamWriter(FileModule, false);
            foreach (string l in nouvellesLignes)
            {
                sw.WriteLine(l);
            }
            sw.Close();
        }

    }
}
