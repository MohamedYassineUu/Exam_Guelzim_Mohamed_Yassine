using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Guelzim_Mohamed_Yassine
{
    internal class Exam
    {
        private int examid;
        private string session;
        private string matiere;
        private int etudiantid;
        private DateTime date;

        public int Examid { get => examid; set => examid = value; }
        public string Session { get => session; set => session = value; }
        public string Matiere { get => matiere; set => matiere = value; }
        public DateTime Date { get => date; set => date = value; }
        public int Etudiantid { get => etudiantid; set => etudiantid = value; }
    }
}
