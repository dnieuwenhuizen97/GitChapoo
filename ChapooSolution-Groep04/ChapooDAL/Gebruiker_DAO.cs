using ChapooModel;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ChapooDAL
{
    public class Gebruiker_DAO : Base
    {
        public List<Gebruiker> Db_Get_All_Users()
        {
            string query = "select [gebruikersId], [gebruikersNaam], [wachtwoord], [functieId] from [Gebruiker]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));

        }
        private List<Gebruiker> ReadTables(DataTable dataTable)
        {
            List<Gebruiker> gebruikers = new List<Gebruiker>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Gebruiker gebruiker = new Gebruiker()
                {
                    naam = (string)dr["gebruikersNaam"],
                    id = (int)dr["gebruikersId"],
                    wachtWoord = (string)dr["wachtwoord"],
                    functieId = (int)dr["functieId"]
                };
                gebruikers.Add(gebruiker);
            }
            return gebruikers;
        }
    }
}
