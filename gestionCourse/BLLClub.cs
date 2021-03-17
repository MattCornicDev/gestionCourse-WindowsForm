using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionCourse
{
    class BLLClub
    {
        private MySqlConnection Connexion;
        private String AdrServeur, NomBdd, Utilisateur, MotPasse;
        private int NumPort;
        private string ChaineConnexion;
        private String _Erreur;
        private bool EstConnecte;
        public BLLClub(string Serv, int Port, string Bdd, string User, string Pass)
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
    }
}
