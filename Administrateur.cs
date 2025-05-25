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
    public partial class Administrateur : Form
    {
        EtudientDao Ed = new EtudientDao();
        EnseignantsDao End = new EnseignantsDao();
        ModuleDao MD = new ModuleDao();
        string nomUser;
        string prenomUser;
        public string NomUser { get => nomUser; set => nomUser = value; }
        public string PrenomUser { get => prenomUser; set => prenomUser = value; }
        public Administrateur(string NomUser, string PrenomUser)
        {
            InitializeComponent();
            this.NomUser = NomUser;
            this.PrenomUser = PrenomUser;
        }
        private void Administrateur_Load(object sender, EventArgs e)
        {

            label1.Text = "Bienvenue " + NomUser + " " + PrenomUser;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Etudiants":
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Ed.ALLEtudiants();
                    break;
                case "Enseignants":
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = End.AllEnseignants();
                    break;
                default:
                    MessageBox.Show("Veuillez choisir un rôle.");
                    break;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Etudiants":
                    Ed.SupprimerEtudiantParId(Int32.Parse(textBox2.Text));
                    break;
                case "Enseignants":
                    End.SupprimerEnseignantParId(Int32.Parse(textBox2.Text));
                    break;
                default:
                    MessageBox.Show("Veuillez choisir un rôle.");
                    break;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Etudiants":
                    Ed.AddEtudiant(Int32.Parse(textBox3.Text), textBox4.Text, textBox5.Text, textBox6.Text);
                    break;
                case "Enseignants":
                    End.AddEnseignant(Int32.Parse(textBox3.Text), textBox4.Text, textBox5.Text, textBox6.Text);
                    break;
                default:
                    MessageBox.Show("Veuillez choisir un rôle.");
                    break;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MD.SupprimerMatiereParId(Int32.Parse(textBox10.Text));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = MD.AllModule();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MD.AffecterEnseignantAModule(textBox1.Text, Int32.Parse(textBox9.Text));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Administrateur_Load(sender, e);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            MD.AddModule(Int32.Parse(textBox7.Text),textBox8.Text, Int32.Parse(textBox11.Text), 0);
        }
    }
}
