using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Guelzim_Mohamed_Yassine
{
    internal class NotesDao
    {
        string FileNotes = "C:\\Users\\yassg\\OneDrive\\Documents\\cSharp\\Exam_Guelzim_Mohamed_Yassine\\CSV\\Notes.csv";

        public void AddNote(int EtudiantId, string Matiere,string Session, double Note)
        {
            StreamWriter sw = new StreamWriter(FileNotes, true);
            sw.WriteLine(EtudiantId + "," + Matiere +"," + Session + "," + Note.ToString(System.Globalization.CultureInfo.InvariantCulture));
            sw.Close();
        }
        public Notes findNotesById(int id)
        {
            Notes e = null;
            StreamReader sd = new StreamReader(FileNotes);
            string line = sd.ReadLine();
            while (line != null)
            {
                string[] dd = line.Split(",");
                if (Int32.Parse(dd[0]) == id)
                {
                    e = new Notes();
                    e.EtudiantId = id;
                    e.Matiere = dd[1];
                    e.Note = Double.Parse(dd[2]);
                    break;
                }
                line = sd.ReadLine();
            }
            sd.Close();
            return e;
        }
        public List<Notes> AllNotes(int id)
        {
            List<Notes> es = new List<Notes>();

            StreamReader sd = new StreamReader(FileNotes);
            string line = sd.ReadLine();
            while (line != null)
            {
                string[] dd = line.Split(",");
                if (Int32.Parse(dd[0]) == id)
                {
                    Notes e = new Notes();
                    e.EtudiantId = id;
                    e.Matiere = dd[1];
                    e.Session = dd[2];
                    e.Note = Double.Parse(dd[3]);
                    es.Add(e);
                    line = sd.ReadLine();
                }
                
            }
            sd.Close();
            return es;
        }

        public double Moyenne(string matiereRecherchee)
        {
            double somme = 0;
            int compteur = 0;

            StreamReader sr = new StreamReader(FileNotes);
            string line = sr.ReadLine();

            while (line != null)
            {
                string[] dd = line.Split(",");

                string matiere = dd[1];
                double note = Double.Parse(dd[3]);

                if (matiere == matiereRecherchee)
                {
                    somme += note;
                    compteur++;
                }

            line = sr.ReadLine();
            }

            sr.Close();

            if (compteur == 0)
                return 0;

            return somme / compteur;
        }

        public double TauxReussite(string matiereRecherchee)
        {
            int total = 0;
            int reussites = 0;

            StreamReader sr = new StreamReader(FileNotes);
            string line = sr.ReadLine();

            while (line != null)
            {
                string[] dd = line.Split(",");

                    string matiere = dd[1];
                    double note = Double.Parse(dd[3]);

                    if (matiere == matiereRecherchee)
                    {
                        total++;
                        if (note >= 10)
                            reussites++;
                    }

                line = sr.ReadLine();
            }

            sr.Close();

            if (total == 0)
                return 0;

            return 100.0 * reussites / total;
        }

        public class NoteAffichage
        {         
            public string nom { get; set; }
            public string prenom { get; set; }
            public string matiere { get; set; }
            public string session { get; set; }
            public double note { get; set; }

            
        }

        public List<NoteAffichage> AllNoteBy(string matiere, string session)
        {
            List<NoteAffichage> n = new List<NoteAffichage>();

            StreamReader sr = new StreamReader(FileNotes);
            string line = sr.ReadLine();

            while (line != null)
            {
                string[] dd = line.Split(",");

                int etudiantId = Int32.Parse(dd[0]);
                string matiereCsv = dd[1];
                string sessionCsv = dd[2];
                double note = Double.Parse(dd[3]);

                    if (matiereCsv == matiere || sessionCsv == session)
                    {
                        EtudientDao eDao = new EtudientDao();
                        Etudiants e = eDao.findEtudiantById(etudiantId);

                        if (e != null)
                        {
                            NoteAffichage noteAffichage = new NoteAffichage();
                            noteAffichage.matiere = matiereCsv;
                            noteAffichage.session = sessionCsv;
                            noteAffichage.note = note;
                            noteAffichage.nom = e.Nom;
                            noteAffichage.prenom = e.Prenom;
                            

                            n.Add(noteAffichage);
                        }
                    }
                

                line = sr.ReadLine();
            }

            sr.Close();
            return n;
        }


    }
}
