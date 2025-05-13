using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Guelzim_Mohamed_Yassine
{
    internal class ExamDao
    {
        string FileExam = "C:\\Users\\yassg\\OneDrive\\Documents\\cSharp\\Exam_Guelzim_Mohamed_Yassine\\CSV\\Exam.csv";
        public void AddExam(int Examid, string Session, string Matiere, DateTime Date)
        {
            StreamWriter sw = new StreamWriter(FileExam, true);
            sw.WriteLine(Examid + "," + Session + "," + Matiere + "," + Date);
            sw.Close();
        }
        public class EtudiantAffichages
        {
            public string Nom { get; set; }
            public string Prenom { get; set; }
            public string NomExam { get; set; }
            public DateTime DateExam { get; set; }
            public string Session { get; set; }

        }
        public List<EtudiantAffichages> findEtudiantsByExam(string nomExam)
        {
            List<EtudiantAffichages> listeAffichage = new List<EtudiantAffichages>();

            StreamReader sr = new StreamReader(FileExam);
            string line = sr.ReadLine();

            while (line != null)
            {

                string[] dd = line.Split(",");

                string Session = dd.Length > 1 ? dd[1] : "";
                string Matiere = dd.Length > 2 ? dd[2] : "";
                DateTime dateExam = DateTime.MinValue;
                int etudiantId = 0;

                if (dd.Length > 3)
                {
                    DateTime.TryParse(dd[3], out dateExam);
                }
                if (dd.Length > 4)
                {
                    int.TryParse(dd[4], out etudiantId);
                }

                if (Session == nomExam)
                {
                    EtudientDao eDao = new EtudientDao();
                    Etudiants e = eDao.findEtudiantById(etudiantId);

                    if (e != null)
                    {
                        listeAffichage.Add(new EtudiantAffichages
                        {
                            Nom = e.Nom,
                            Prenom = e.Prenom,
                            NomExam = Matiere,
                            DateExam = dateExam,
                            Session = Session
                        });
                    }
                }

                line = sr.ReadLine();
            }

            sr.Close();
            return listeAffichage;
        }

        public class ExamAffichage
        {
            public string Session { get; set; }
            public string Matiere { get; set; }
            public DateTime Date { get; set; }
        }
        public List<ExamAffichage> AllExam()
        {
            List<ExamAffichage> listeExam = new List<ExamAffichage>();
            StreamReader sr = new StreamReader(FileExam);
            string line = sr.ReadLine();
            DateTime dateMaitenant = DateTime.Now;



            while (line != null)
            {    
                string[] dd = line.Split(",");
                if (DateTime.Parse(dd[3]) > dateMaitenant)
                {
                    ExamAffichage e = new ExamAffichage();

                    e.Session = dd[1];
                    e.Matiere = dd[2];
                    e.Date = DateTime.Parse(dd[3]);

                    listeExam.Add(e);  
                }

                line = sr.ReadLine();
            }
            sr.Close();
            return listeExam;
        }
    }
}
