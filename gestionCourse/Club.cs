using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionCourse
{
    class Club
    {
        int idClub;
        string nomClub;
        string addrClub;
        string codePosition;
        string villeClub;

        public Club(int id, string nom, string addr, string CP, string ville)
        {
            idClub = id;
            nomClub = nom;
            addrClub = addr;
            codePosition = CP;
            villeClub = ville;
        }


    }
}
