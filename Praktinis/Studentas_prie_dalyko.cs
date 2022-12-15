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

    public partial class Studentas_prie_dalyko : Form
    {
        Studentu_dalykų _parent;
        public string id, vardas, dalykas;
        MySqlConnection con = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=root");
        public Studentas_prie_dalyko(Studentu_dalykų parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateInfo()
        {
            Išsaugoti.Text = "Atnaujinti";
            txtVardas.Text = vardas;
            txtGrupe.Text = dalykas;
        }

        void StudName()
        {
            string command_query = "SELECT Vardas FROM praktinis.student";
            MySqlCommand cmd = new MySqlCommand(command_query, con);
            MySqlDataReader mydr;

            try
            {
                con.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string name = mydr.GetString("Vardas");
                    comboVardas.Items.Add(name);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void StudClass()
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
                    string stud_clas = mydr.GetString("Pavadinimas");
                    comboGrupe.Items.Add(stud_clas);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void Atšaukti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Studentas_prie_grupes_Load(object sender, EventArgs e)
        {
            StudName();
            StudClass();

        }

        

        private void Išsaugoti_Click(object sender, EventArgs e)
        {
            if (Išsaugoti.Text == "Išsaugoti")
            {
                StudSub stc = new StudSub (txtVardas.Text.Trim(), txtGrupe.Text.Trim());
                DbStudSub.AddStudToSub(stc);
                Clear();
            }

            if (Išsaugoti.Text == "Atnaujinti")
            {
                StudSub stc = new StudSub(txtVardas.Text.Trim(), txtGrupe.Text.Trim());
                DbStudSub.UpdateStudToSub(stc, id);
            }
            _parent.Display();

        }
        public void Clear()
        {
            txtVardas.Text = txtGrupe.Text = string.Empty;
        }


        private void comboVardas_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Vardas FROM praktinis.student WHERE Vardas ='" + comboVardas.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtVardas.Text = dr["Vardas"].ToString();//pakeisti i teksto laukus
            }
            con.Close();
        }

        private void Grupe_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Pavadinimas FROM praktinis.subject WHERE Pavadinimas ='" + comboGrupe.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtGrupe.Text = dr["Pavadinimas"].ToString();//pakeisti i teksto laukus
            }
            con.Close();
        }
    }
}
