using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Guelzim_Mohamed_Yassine
{
    internal class Notes
    {
        private int etudiantId;
        private string matiere;
        private double note;
        private string session;

        public string Session { get => session; set => session = value; }
        public int EtudiantId { get => etudiantId; set => etudiantId = value; }
        public string Matiere { get => matiere; set => matiere = value; }
        public double Note { get => note; set => note = value; }

    }
}
