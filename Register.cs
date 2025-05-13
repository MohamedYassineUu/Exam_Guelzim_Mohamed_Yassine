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
    public partial class Register : Form
    {

        private string userRole;

        public string UserRole { get { return userRole; } set { userRole = value; } }
        public Register(string userRole)
        {
            InitializeComponent();

            this.UserRole = userRole;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            switch (UserRole)
            {
                case "Administrateur":
                    AdministrateurDao administrateurDao = new AdministrateurDao();
                    
                    int idAdmin = Int32.Parse(textBox1.Text);
                    string nomAdmin = textBox2.Text;
                    string prenomAdmin = textBox3.Text;
                    string passwordAdmin = textBox4.Text;
                    
                    administrateurDao.AddAdministrateur(idAdmin, nomAdmin, prenomAdmin, passwordAdmin);
                    
                    MessageBox.Show("Inscription Réussi ");

                    goto case "Login";

                case "Etudiant":
                    EtudientDao etudientDao = new EtudientDao();

                    int id = Int32.Parse(textBox1.Text);
                    string nom = textBox2.Text;
                    string prenom = textBox3.Text;
                    string password = textBox4.Text;
                    etudientDao.AddEtudiant(id, nom, prenom, password);

                    MessageBox.Show("Inscription Réussi ");
                    goto case "Login";


                case "Enseignant":
                    EnseignantsDao enseignantDao = new EnseignantsDao();

                    int idEnseignant = Int32.Parse(textBox1.Text);
                    string nomEnseignant = textBox2.Text;
                    string prenomEnseignant = textBox3.Text;
                    string passwordEnseignant = textBox4.Text;

                    enseignantDao.AddEnseignant(idEnseignant, nomEnseignant, prenomEnseignant, passwordEnseignant);
                    MessageBox.Show("Inscription Réussi ");
                    goto case "Login";

                case "Login":

                    login.Show();
                    this.Hide();
                    break;
                default:
                    MessageBox.Show("Veuillez choisir un rôle.");
                    break;
            }
        }
    }
}
