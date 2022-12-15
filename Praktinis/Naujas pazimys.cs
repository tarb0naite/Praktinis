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
    public partial class Naujas_pazimys : Form
    {
        

        MySqlConnection con = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=root");
        private readonly Destytojas _parent;
        public string id, vardas, dalykas, grupe, pažymis;
        public Naujas_pazimys(Destytojas parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void UpdateInfo()
        {
            Pateikti.Text = "Atnaujinti";
            textVardas.Text = vardas;
            pazymis.Text = pažymis;
            textDalykas.Text = dalykas;
            textGrupe.Text = grupe;
        }

        private void comboVardas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string con = "datasource=localhost;port=3306;username=root;password=root";
            string query = "SELECT * FROM praktinis.all_together WHERE Vardas = '" + comboVardas.Text + "'";
            MySqlConnection sql = new MySqlConnection(con);
            MySqlCommand cmd = new MySqlCommand(query, sql);
            MySqlDataReader dr;
            try
            {
                sql.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string Vardas = dr.GetString("Vardas").ToString();
                    string Dalykas = dr.GetString("Dalykas").ToString();
                    string Grupe = dr.GetString("Grupe").ToString();

                    textVardas.Text = Vardas;
                    textDalykas.Text = Dalykas;
                    textGrupe.Text = Grupe;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Naujas_pazimys_Load(object sender, EventArgs e)
        {
            StudName();
        }

        public void Clear()
        {
            textVardas.Text =  textDalykas.Text = textGrupe.Text = pazymis.Text = string.Empty;
        }


        void StudName()
        {
            string command_query = "SELECT Vardas FROM praktinis.all_together";
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Pateikti_Click(object sender, EventArgs e)
        {
            if (Pateikti.Text == "Pateikti")
            {
                Mark mrk = new Mark(textVardas.Text.Trim(), textDalykas.Text.Trim(), textGrupe.Text.Trim(), pazymis.Text.Trim());
                DbMark.AddMark(mrk);
                Clear();
            }

            if (Pateikti.Text == "Atnaujinti")
            {
                Mark mrk = new Mark(textVardas.Text.Trim(), textDalykas.Text.Trim(), textGrupe.Text.Trim(), pazymis.Text.Trim());
                DbMark.UpdateMark(mrk, id);
            }
            _parent.Display();
            Visible = false;

        }

       


       

        private void Atšaukti_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
