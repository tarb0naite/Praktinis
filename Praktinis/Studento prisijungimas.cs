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
    public partial class Studento_prisijungimas : Form
    {
        public Studento_prisijungimas()
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
                

            string query = "SELECT * FROM student WHERE Vardas= '" + txtVardas.Text + "' AND Pavarde = '" + txtPavarde.Text + "'";
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
                        Studentas student = new Studentas();
                        student.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Prisijungti nepavyko");
                }
                db.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void trying()
        {

            string vardas = txtVardas.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            log();

        }

      
    }
}
