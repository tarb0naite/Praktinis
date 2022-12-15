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

namespace Praktinis2
{
    public partial class Nauja_grupe : Form

    {
        MySqlConnection con = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=root");
        private readonly Grupiu_kontrole _parent;
        public string id, pavadinimas;

        public Nauja_grupe(Grupiu_kontrole parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateInfo()
        {
            Itraukti.Text = "Atnaujinti";
            Pavadinimas.Text = pavadinimas;
          
        }

        public void Clear()
        {
            Pavadinimas.Text = string.Empty;
        }

        private void Itraukti_Click(object sender, EventArgs e)
        {
            if (Pavadinimas.Text.Trim().Length < 3)
            {
                MessageBox.Show("Pavadinimas netinkamas");
                return;
            }

            if (Itraukti.Text == "Įtraukti")
            {
                Class cls = new Class(Pavadinimas.Text.Trim());
                DbGrupe.AddClass(cls);
                Clear();
            }

            if (Itraukti.Text == "Atnaujinti")
            {
                Class cls = new Class(Pavadinimas.Text.Trim());
                DbGrupe.UpdateClass(cls, id);
            }
            _parent.Display();

        }
       



        private void Nauja_grupe_Load(object sender, EventArgs e)
        {
            
        }

        private void Atšaukti_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        
    }
}

