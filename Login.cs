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
    public partial class Login : Form
    {
        EtudientDao etDao = new EtudientDao();
        AdministrateurDao adDao = new AdministrateurDao();
        EnseignantsDao enDao = new EnseignantsDao();

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem)
            {
                case "Etudiant":
                    String[] etudiantSave = etDao.FindEtudiant(textBox1.Text, textBox2.Text);
                    if (etudiantSave != null)
                    {
                        this.Hide();
                        Etudiant etudiant = new Etudiant(etudiantSave[1], etudiantSave[2]);
                        etudiant.Show();
                    }
                    else
                    {
                        MessageBox.Show("Identifiant ou mot de passe incorrect");
                    }
                    break;
                case "Enseignant":
                    String[] EnseignantSave = enDao.FindEnseignant(textBox1.Text, textBox2.Text);
                    if (EnseignantSave != null)
                    {
                        this.Hide();
                        Enseignant enseignant = new Enseignant(EnseignantSave[1], EnseignantSave[2]);
                        enseignant.Show();

                    }
                    else
                    {
                        MessageBox.Show("Identifiant ou mot de passe incorrect");
                    }
                    break;
                case "Administrateur":
                    //String[] adminSave = adDao.FindAdministrateur(textBox1.Text, textBox2.Text);
                    //if (adminSave != null)
                    //{
                    //    this.Hide();
                    //    Administrateur admin = new Administrateur();
                    //    admin.Show();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Identifiant ou mot de passe incorrect");
                    //}
                    break;
                default:
                    MessageBox.Show("Veuillez choisir un rôle.");
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir un rôle.");
            }else
            {
                Register register = new Register(comboBox1.SelectedItem.ToString());
                register.Show();
                this.Hide();
            }


        }
    }
}
