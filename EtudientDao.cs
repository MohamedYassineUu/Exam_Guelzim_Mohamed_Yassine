


namespace Exam_Guelzim_Mohamed_Yassine
{
    internal class EtudientDao
    {
        string FileEtudiant = "C:\\Users\\yassg\\OneDrive\\Documents\\cSharp\\Exam_Guelzim_Mohamed_Yassine\\CSV\\Etudiants.csv";

        public void AddEtudiant(int Etudiantid, string Nom, string Prenom, string Password)
        {
            StreamWriter sw = new StreamWriter(FileEtudiant, true);
            sw.WriteLine(Etudiantid + "," + Nom + "," + Prenom + "," + Password);
            sw.Close();
        }

        public string[] FindEtudiant(string nom, string password)
        {
            StreamReader sd = new StreamReader(FileEtudiant);
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
        public Etudiants findEtudiantById(int id)
        {
            Etudiants e = null;

            StreamReader sd = new StreamReader(FileEtudiant);
            string line = sd.ReadLine();
            while (line != null)
            {
                string[] dd = line.Split(",");
                if (Int32.Parse(dd[0]) == id)
                {
                    e = new Etudiants();
                    e.Etudiantid = id;
                    e.Nom = dd[1];
                    e.Prenom = dd[2];
                    break;
                }
                line = sd.ReadLine();
            }
            sd.Close();
            return e;
        }
        public List<Etudiants> ALLEtudiants()
        {
            List<Etudiants> es = new List<Etudiants>();
            StreamReader sd = new StreamReader(FileEtudiant);
            string line = sd.ReadLine();
            while (line != null)
            {
                string[] dd = line.Split(",");

                Etudiants e = new Etudiants();
                e.Etudiantid = Int32.Parse(dd[0]);
                e.Nom = dd[1];
                e.Prenom = dd[2];
                e.Password = dd[3];
                es.Add(e);
                line = sd.ReadLine();
            }
            sd.Close();
            return es;
        }
        public void SupprimerEtudiantParId(int id)
        {
            List<string> lignes = new List<string>();


            StreamReader sr = new StreamReader(FileEtudiant);
            string line = sr.ReadLine();

            while (line != null)
            {
                string[] dd = line.Split(",");

                if (Int32.Parse(dd[0]) != id) { 

                    lignes.Add(line);

                }

                line = sr.ReadLine();
            }
            sr.Close();

            StreamWriter sw = new StreamWriter(FileEtudiant, false);
            foreach (string l in lignes)
            {
                sw.WriteLine(l);
            }
            sw.Close();
        }

    }
}
