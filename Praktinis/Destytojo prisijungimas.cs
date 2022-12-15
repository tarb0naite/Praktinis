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
    public partial class Destytojo_prisijungimas : Form
    {
        public Destytojo_prisijungimas()
        {
            InitializeComponent();
        }

        private void Atšaukti_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string con = "datasource=localhost;port=3306;username=root;password=root;database=praktinis";

        public void log()
        {
            string query = "SELECT * FROM prof WHERE Vardas= '" + Prisijungimo_var.Text + "' AND Pavarde = '" + Prisijungio_slap.Text + "'";
            MySqlConnection db = new MySqlConnection(con);
            MySqlCommand cm = new MySqlCommand(query, db);
            cm.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                db.Open();
                reader = cm.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MessageBox.Show("Pavyko prisijungti");
                        Destytojas prof = new Destytojas();
                        prof.Show();
                    }
                }
                else
                {
                    MessageBox.Show("failed my bro");
                }
                db.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Prisijungti_Click(object sender, EventArgs e)
        {
            log();
        }
    }
}
