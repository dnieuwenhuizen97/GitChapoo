using ChapooModel;
using ChapooDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooLogic
{
    public class Gebruiker_Service
    {
        Gebruiker_DAO gebruiker_db = new Gebruiker_DAO();

        public List<Gebruiker> GetUsers()
        {
            List<Gebruiker> gebruikers = gebruiker_db.Db_Get_All_Users();
            return gebruikers;
        }
    }
}
