using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktinis2
{
    public partial class Studentas : Form
    {
        Studento_prisijungimas login;
      
        public Studentas()
        {
            InitializeComponent();
            login = new Studento_prisijungimas();
        }
       

        public void Display()
        {
            DbPazimys.DisplayAndSearch("SELECT ID,  Dalykas ,Pažymis FROM mark", dataGridView);
        }

        private void Atsijungti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Studentas_Load(object sender, EventArgs e)
        {
            
        }

        private void Studentas_Shown(object sender, EventArgs e)
        {
            Display();
        }
    }
}
