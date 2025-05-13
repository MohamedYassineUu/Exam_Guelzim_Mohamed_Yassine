using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Guelzim_Mohamed_Yassine
{
    internal class Etudiants
    {
        private int etudiantid;
        private string nom;
        private string prenom;
        private string password;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Password { get => password; set => password = value; }
        public int Etudiantid { get => etudiantid; set => etudiantid = value; }
    }
}
