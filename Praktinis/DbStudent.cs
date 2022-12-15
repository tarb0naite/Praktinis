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
    class DbStudent
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

        public static void AddStudent(Student std)
        {
            string sql = "INSERT INTO student VALUES (NULL, @StudentVardas, @StudentPavarde)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
           //cmd.Parameters.Add("@StudentID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@StudentVardas", MySqlDbType.VarChar).Value = std.Vardas;
            cmd.Parameters.Add("@StudentPavarde", MySqlDbType.VarChar).Value = std.Pavarde;
            
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Studentas pridetas", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Studentas neirasytas \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void UpdateStudent(Student std, string id)
        {
            string sql = "UPDATE student SET Vardas = @StudentName, Pavarde = @StudentPavarde WHERE ID = @StudentID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@StudentID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@StudentVardas", MySqlDbType.VarChar).Value = std.Vardas;
            cmd.Parameters.Add("@StudentPavarde", MySqlDbType.VarChar).Value = std.Pavarde;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Studentas atnaujintas", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Studentas neatnaujintas \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void DeleteStudent(string id)
        {
            string sql = "DELETE FROM student WHERE ID = @StudentID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@StudentID", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Studentas pasalintas", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Studentas nepasalintas \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void DisplayAndSearch(string query, DataGridView dgv) //del atidarytmo ko reikia zeti cia
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
