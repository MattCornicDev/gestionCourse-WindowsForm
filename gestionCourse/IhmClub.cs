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
            if()
        }
    }
}
