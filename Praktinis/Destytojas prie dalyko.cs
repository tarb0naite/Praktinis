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
    public partial class Destytojas_prie_dalyko : Form
    {
        private readonly Destytojo_mokomas_dalykas _parent;
        public string id, vardas, pavarde, dalykas;
        MySqlConnection con = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=root");
        public Destytojas_prie_dalyko(Destytojo_mokomas_dalykas parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void UpdateInfo()
        {
            Patvirtinti.Text = "Atnaujint";
            txtVardas.Text = vardas;
            mokomas_dalykas.Text = dalykas;
            txtPavarde.Text = pavarde;

        }

        void ProfName()
        {
            string command_query = "SELECT Vardas FROM praktinis.prof";
            MySqlCommand cmd = new MySqlCommand(command_query, con);
            MySqlDataReader mydr;
            try
            {
                con.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string name = mydr.GetString("Vardas");
                    Vardas.Items.Add(name);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Sub()
        {
            string command_query = "SELECT Pavadinimas FROM praktinis.subject";
            MySqlCommand cmd = new MySqlCommand(command_query, con);
            MySqlDataReader mydr;
            try
            {
                con.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string sub = mydr.GetString("Pavadinimas");
                    comboDalykas.Items.Add(sub);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
       

        public void Clear()
        {
            txtVardas.Text = mokomas_dalykas.Text = txtPavarde.Text = string.Empty;
        }

        private void Atšaukti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Destytojas_prie_dalyko_Load(object sender, EventArgs e)
        {
            ProfName();
            Sub();
        }

        private void Patvirtinti_Click(object sender, EventArgs e)
        {

            if (Patvirtinti.Text == "Patvirtinti")
            {
                ProfSub pts = new ProfSub(txtVardas.Text.Trim(), txtPavarde.Text.Trim(), mokomas_dalykas.Text.Trim()); ;
                DbProfSub.AddProfToSub(pts);
                Clear();
            }

            if (Patvirtinti.Text == "Atnaujinti")
            {
                ProfSub pts = new ProfSub(txtVardas.Text.Trim(), txtPavarde.Text.Trim(), mokomas_dalykas.Text.Trim());
                DbProfSub.UpdateProfToSub(pts, id);
            }
            _parent.Display();
        }

       
        private void comboDalykas_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Pavadinimas FROM praktinis.subject WHERE Pavadinimas ='" + comboDalykas.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                mokomas_dalykas.Text = dr["Pavadinimas"].ToString();
            }
            con.Close();

        }

        private void Vardas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string con = "datasource=localhost;port=3306;username=root;password=root";
            string query = "SELECT * FROM praktinis.prof WHERE Vardas = '" + Vardas.Text+ "'";
            MySqlConnection sql = new MySqlConnection(con);
            MySqlCommand cmd = new MySqlCommand(query, sql);
            MySqlDataReader dr;

            try
            {
                sql.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string dVardas = dr.GetString("Vardas").ToString();
                    string dPavarde = dr.GetString("Pavarde").ToString();

                    txtVardas.Text = dVardas;
                    txtPavarde.Text = dPavarde;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            /*
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Vardas FROM praktinis.prof WHERE Vardas ='" + Vardas.Text+ "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtVardas.Text = dr["Vardas"].ToString();
            }
            con.Close();
            */
        }

        
    }
}
