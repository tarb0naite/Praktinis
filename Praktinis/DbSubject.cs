using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace Praktinis2
{
    class DbSubject
    {
        public static MySqlConnection GetConnection()
        {
            string cls = "datasource=localhost;port=3306;username=root;password=root;database=praktinis";
            MySqlConnection con = new MySqlConnection(cls);
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

        public static void AddSub(Subject sbj)
        {
            string sql = "INSERT INTO subject VALUES (NULL, @SubjectPavadinimas)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@SubjectPavadinimas", MySqlDbType.VarChar).Value = sbj.Pavadinimas;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dalykas sukurtas", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Dalykas sukurtas \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void UpdateSub(Subject sbj, string id)
        {
            string sql = "UPDATE subject SET Pavadinimas = @SubjectPavadinimas WHERE ID = @SubjectID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@SubjectID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@SubjectPavadinimas", MySqlDbType.VarChar).Value = sbj.Pavadinimas;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dalykas atnaujintas", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Dalyks neatnaujintas \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void DeleteSub(string id)
        {
            string sql = "DELETE FROM subject WHERE ID = @SubjectID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@SubjectID", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dalikas pasalintas", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Dalikas nepasalintas\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string cls = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(cls, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }


    }
}
