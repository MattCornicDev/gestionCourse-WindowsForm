using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace gestionCourse
{
    public partial class IhmClub : Form
    {
        public IhmClub()
        {
            InitializeComponent();
        }

        private void buttonEnvoyer_Click(object sender, EventArgs e)
        {
            ClubC = new club(1, txtNom.Text, textBoxAdresse.Text, txtCP.Text, txtVille.Text);
            bllClub = new BDD();


        }



        

    }
}


/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionCourses
{
    class BddMySql
    {
        private MySqlConnection Connexion;
        private String AdrServeur, NomBdd, Utilisateur, MotPasse;
        private int NumPort;
        private string ChaineConnexion;
        private String _Erreur;
        private bool EstConnecte;

        public BddMySql(string Serv, int Port, string Bdd, string User, string Pass)
        {
            AdrServeur = Serv;
            NomBdd = Bdd;
            Utilisateur = User;
            MotPasse = Pass;
            NumPort = Port;
            ChaineConnexion = "Server=" + AdrServeur +
                              ";Database=" + NomBdd +
                              ";port=" + NumPort +
                              ";User Id=" + Utilisateur +
                              ";password=" + MotPasse;

            Connexion = new MySqlConnection(ChaineConnexion); // Création de l'object Connexion
            EstConnecte = false; // Connexion fermée par défaut

           
        }

        public bool OuvrirConnexion()
        {
            try
            {
                Connexion.Open();
                EstConnecte = true;
            }
            catch(Exception Er)
            {
                _Erreur = Er.Message;
            }
            return EstConnecte;
        }

        public bool FermerConnexion()
        {
            try
            {
                Connexion.Close();
                EstConnecte = false;
            }
            catch(Exception Er)
            {
                _Erreur = Er.Message;
            }

            return EstConnecte;
        }

        public string Erreur
        {
            get { return _Erreur; }
        }
    }

}

 */