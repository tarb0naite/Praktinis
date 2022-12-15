using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Praktinis2
{
    class DbProf
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=root;database=praktinis";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return con;
        }

        public static void AddProf(Prof prf)
        {
            string sql = "INSERT INTO prof VALUES (NULL, @ProfVardas, @ProfPavarde)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            
            cmd.Parameters.Add("@ProfVardas", MySqlDbType.VarChar).Value = prf.Vardas;
            cmd.Parameters.Add("@ProfPavarde", MySqlDbType.VarChar).Value = prf.Pavarde;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Destitojas pridetas", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Destytojas nepridetas \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void UpdateProf(Prof prf, string id)
        {
            string sql = "UPDATE prof SET Vardas = @ProfName, Pavarde = @ProfPavarde WHERE ID = @ProfID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ProfVardas", MySqlDbType.VarChar).Value = prf.Vardas;
            cmd.Parameters.Add("@ProfPavarde", MySqlDbType.VarChar).Value = prf.Pavarde;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Destytojas atnaujintas", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Destytojas neatnaujintas \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void DeleteProf(string id)
        {
            string sql = "DELETE FROM prof WHERE ID = @ProfID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ProfID", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Destytojas pasalintas", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Destytojas nepasalintas \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }

    }
}

