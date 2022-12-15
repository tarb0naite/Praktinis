using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Praktinis2
{
    class DbProfSub
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

        public static void AddProfToSub(ProfSub pts)
        {
            string sql = "INSERT INTO prof_sub VALUES (NULL, @ProfSubVardas, @ProfSubDalykas,  @ProfSubPavarde)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
           // cmd.Parameters.Add("@StudentID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@ProfSubVardas", MySqlDbType.VarChar).Value = pts.Vardas;
            cmd.Parameters.Add("@ProfSubDalykas", MySqlDbType.VarChar).Value = pts.Dalykas;
            cmd.Parameters.Add("@ProfSubPavarde", MySqlDbType.VarChar).Value = pts.Pavarde;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Destytojas priskirtas", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Destytojas priskirtas \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void UpdateProfToSub(ProfSub pts, string id)
        {
            string sql = "UPDATE prof_sub SET Vardas = @ProfSubVardas, Dalykas = @ProfSubDalykas, Pavarde =@ProfSubPavarde WHERE ID = @ProfSubID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ProfSubVardas", MySqlDbType.VarChar).Value = pts.Vardas;
            cmd.Parameters.Add("@ProfSubDalykas", MySqlDbType.VarChar).Value = pts.Dalykas;
            cmd.Parameters.Add("@ProfSubPavarde", MySqlDbType.VarChar).Value = pts.Pavarde;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Destytojas atnaujintas", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Destytojas neatnaujintas\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void DeleteProfToSub(string id)
        {
            string sql = "DELETE FROM prof_sub WHERE ID = @ProfSubID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ProfSubID", MySqlDbType.Int32).Value = id;

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
