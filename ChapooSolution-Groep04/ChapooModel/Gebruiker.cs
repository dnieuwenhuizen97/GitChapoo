using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Gebruiker
    {
        public int id { get; set; }
        public string naam { get; set; }
        public string wachtWoord { get; set; }
        public int functieId { get; set; }
    }
}
