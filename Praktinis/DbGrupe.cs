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
    class DbGrupe
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

            public static void AddClass(Class cls)
            {
                string sql = "INSERT INTO class VALUES (NULL, @ClassPavadinimas)";
                MySqlConnection con = GetConnection();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
               
                cmd.Parameters.Add("@ClassPavadinimas", MySqlDbType.VarChar).Value = cls.Pavadinimas;
               

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Grupe sukurta", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Grupe nesukurta \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }

            public static void UpdateClass(Class cls, string id)
            {
                string sql = "UPDATE class SET Pavadinimas = @ClassPavadinimas WHERE ID = @ClassID";
                MySqlConnection con = GetConnection();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ClassID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@ClassPavadinimas", MySqlDbType.VarChar).Value = cls.Pavadinimas;
               

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Grupe atnaujinta", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Grupe neatnaujinta \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            public static void DeleteClass(string id)
            {
                string sql = "DELETE FROM class WHERE ID = @ClassID";
                MySqlConnection con = GetConnection();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@ClassID", MySqlDbType.VarChar).Value = id;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Grupe pasalinta", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Grupe nepasalinta \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
