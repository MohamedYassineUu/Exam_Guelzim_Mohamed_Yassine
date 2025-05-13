using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Guelzim_Mohamed_Yassine
{
    public partial class Etudiant : Form
    {
        string nomUser;
        string prenomUser;
        public string NomUser { get => nomUser; set => nomUser = value; }
        public string PrenomUser { get => prenomUser; set => prenomUser = value; }

        public Etudiant(string NomUser, string PrenomUser)
        {
            InitializeComponent();

            this.NomUser = NomUser;
            this.PrenomUser = PrenomUser;
        }

        private void Etudiant_Load(object sender, EventArgs e)
        {
            label1.Text = "Bienvenue " + NomUser + " " + PrenomUser;
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ExamDao eDao = new ExamDao();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = eDao.AllExam();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Etudiant_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Etudiant_Load(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            NotesDao nDao = new NotesDao();
            dataGridView2.DataSource = nDao.AllNoteBy(null, comboBox1.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            NotesDao nDao = new NotesDao();
            dataGridView2.DataSource = nDao.AllNoteBy(textBox2.Text, null);
        }
    }
}
