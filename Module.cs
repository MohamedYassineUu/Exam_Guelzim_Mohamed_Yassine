using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Guelzim_Mohamed_Yassine
{
    internal class Module
    {
        private int moduleid;
        private string nomModule;
        private int etudiantid;
        private int eseignantid;
        public int Moduleid { get => moduleid; set => moduleid = value; }
        public string NomModule { get => nomModule; set => nomModule = value; }
        public int Etudiantid { get => etudiantid; set => etudiantid = value; }
        public int Eseignantid { get => eseignantid; set => eseignantid = value; }
    }
}
