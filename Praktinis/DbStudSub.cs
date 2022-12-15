using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktinis2
{
    class DbStudSub
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

        public static void AddStudToSub(StudSub pts)
        {
            string sql = "INSERT INTO student_sub VALUES (NULL, @StudSubVardas, @StudSubDalykas)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            // cmd.Parameters.Add("@StudentID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@StudSubVardas", MySqlDbType.VarChar).Value = pts.Vardas;
            cmd.Parameters.Add("@StudSubDalykas", MySqlDbType.VarChar).Value = pts.Dalykas;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Studentas priskirtas dalykui", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Studentas nepriskirtas dalykui\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void UpdateStudToSub(StudSub pts, string id)
        {
            string sql = "UPDATE student_sub SET Vardas = @StudSubVardas, Dalykas = @StudSubDalykas WHERE ID = @StudSubID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@StudSubVardas", MySqlDbType.VarChar).Value = pts.Vardas;
            cmd.Parameters.Add("@StudSubDalykas", MySqlDbType.VarChar).Value = pts.Dalykas;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Studentas priskirtas dalykui", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Studentas priskirtas dalykui\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void DeleteStudToSub(string id)
        {
            string sql = "DELETE FROM student_sub WHERE ID = @StudSubID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@StudSubID", MySqlDbType.Int32).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Studentas priskirtas dalykui pasalintas", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Studentas priskirtas dalykui nepasalintas \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
