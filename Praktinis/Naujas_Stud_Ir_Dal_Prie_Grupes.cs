using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Praktinis2
{
    public partial class Naujas_Stud_Ir_Dal_Prie_Grupes : Form
    {
        private readonly Stud_Ir_Dal_Prie_Grupes_Kontrole _parent;
        public string id, vardas, dalykas, grupe;
        MySqlConnection con = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=root");

        public Naujas_Stud_Ir_Dal_Prie_Grupes(Stud_Ir_Dal_Prie_Grupes_Kontrole parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void UpdateInfo()
        {
            Itraukti.Text = "Atnaujint";
            txtVardas.Text = vardas;
            txtDalykas.Text = dalykas;
            txtGrupe.Text = grupe;
        }
       

        private void Atšaukti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Naujas_Stud_Ir_Dal_Prie_Grupes_Load(object sender, EventArgs e)
        {
            Stud();
           
            Class();
            
        }

        private void Itraukti_Click(object sender, EventArgs e)
        {
            if (Itraukti.Text == "Itraukti")
            {
                Bendra pts = new Bendra(txtVardas.Text.Trim(), txtDalykas.Text.Trim(),  txtGrupe.Text.Trim()); ;
                DbBendra.AddBendra(pts);
                Clear();
            }

            
            if (Itraukti.Text == "Atnaujinti") 
            {
                Bendra pts = new Bendra(txtVardas.Text.Trim(), txtDalykas.Text.Trim(), txtGrupe.Text.Trim());
                DbBendra.UpdateBendra(pts, id);
            }
           
            _parent.Display();
        }

        private void comboVardas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string con = "datasource=localhost;port=3306;username=root;password=root";
            string query = "SELECT * FROM praktinis.student_sub WHERE Vardas = '" + comboVardas.Text + "'";
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
                    string dDalykas= dr.GetString("Dalykas").ToString();

                    txtVardas.Text = dVardas;
                    txtDalykas.Text = dDalykas;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


      

        private void comboGrupe_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Pavadinimas FROM praktinis.class WHERE Pavadinimas ='" + comboGrupe.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtGrupe.Text = dr["Pavadinimas"].ToString();
            }
            con.Close();
        }

       
        
        

        void Class()
        {
            string command_query = "SELECT Pavadinimas FROM praktinis.class";
            MySqlCommand cmd = new MySqlCommand(command_query, con);
            MySqlDataReader mydr;
            try
            {
                con.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string name = mydr.GetString("Pavadinimas");
                    comboGrupe.Items.Add(name);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Stud()
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

      
        
        public void Clear()
        {
            txtVardas.Text = txtDalykas.Text = txtGrupe.Text = string.Empty;
        }


    }
}
