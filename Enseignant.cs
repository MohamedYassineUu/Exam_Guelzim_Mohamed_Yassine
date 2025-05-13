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
    public partial class Enseignant : Form
    {
        ExamDao examDao = new ExamDao();
        EtudientDao etudientDao = new EtudientDao();
        NotesDao notesDao = new NotesDao();

        string nomUser;
        string prenomUser;
        public string NomUser { get => nomUser; set => nomUser = value; }
        public string PrenomUser { get => prenomUser; set => prenomUser = value; }
        public Enseignant(string NomUser, string PrenomUser)
        {
            InitializeComponent();
            this.NomUser = NomUser;
            this.PrenomUser = PrenomUser;
        }


        private void Enseignant_Load(object sender, EventArgs e)
        {
            label1.Text = "Bienvenue " + NomUser + " " + PrenomUser;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Section Ajout Examan";
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Faites votre choix";
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Section Recherche Élève";
            panel3.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Section Stats";
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;


        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;

            Enseignant_Load(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {

            examDao.AddExam(Int32.Parse(textBox2.Text), comboBox1.Text, textBox1.Text, dateTimePicker1.Value);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Etudiants et = etudientDao.findEtudiantById(Int32.Parse(textBox3.Text));
            if (et != null)
            {
                notesDao.AddNote(Int32.Parse(textBox3.Text), textBox4.Text, comboBox2.SelectedItem.ToString(), Double.Parse(textBox5.Text));
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = notesDao.AllNotes(Int32.Parse(textBox3.Text));
                MessageBox.Show("Note enregistrée avec succès");
            }
            else
            {
                MessageBox.Show("Etudiant introuvable");

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;

            Enseignant_Load(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ModuleDao moduleDao = new ModuleDao();
            moduleDao.AddModule(1, "Physique", 1);
            dataGridView3.Visible = false;
            dataGridView2.Visible = true;
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = moduleDao.findEtudiantsByModule(textBox6.Text);


        }

        private void button10_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = examDao.findEtudiantsByExam(comboBox3.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label14.Text = "La moyenne pour la matiere " + textBox7.Text + ": ";
            label16.Text = notesDao.Moyenne(textBox7.Text).ToString();

            label15.Visible = false;
            label17.Visible = false;

            label14.Visible = true;
            label16.Visible = true;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            textBox7.Clear();
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;

            Enseignant_Load(sender, e);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label15.Text = "Le taux de réussite pour la matiere " + textBox7.Text + ": ";
            label17.Text = notesDao.TauxReussite(textBox7.Text).ToString() + "%";

            label14.Visible = false;
            label16.Visible = false;

            label15.Visible = true;
            label17.Visible = true;


        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;

            Enseignant_Load(sender, e);

        }
    }
}
