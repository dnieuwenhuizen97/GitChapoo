using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooLogic;
using ChapooModel;

namespace ChapooUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ChapooLogic.Gebruiker_Service gebruiker_Service = new Gebruiker_Service();
            List<Gebruiker> gebruikers = gebruiker_Service.GetUsers();

            listViewGebruiker.Items.Clear();

            foreach (Gebruiker g in gebruikers)
            {
                ListViewItem li = new ListViewItem(g.naam);
                li.SubItems.Add(g.id.ToString());
                li.SubItems.Add(g.functieId.ToString());
                listViewGebruiker.Items.Add(li);
            }

        }
            
    }
}
