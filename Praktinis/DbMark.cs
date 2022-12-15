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
    class DbMark
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

        public static void AddMark(Mark mrk)
        {
            string sql = "INSERT INTO mark VALUES (NULL, @MarkVardas, @MarkDalykas, @MarkGrupe, @MarkPažymis)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
           // cmd.Parameters.Add("@MarktID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@MarkVardas", MySqlDbType.VarChar).Value = mrk.Vardas;
            cmd.Parameters.Add("@MarkDalykas", MySqlDbType.VarChar).Value = mrk.Dalykas;
            cmd.Parameters.Add("@MarkGrupe", MySqlDbType.VarChar).Value = mrk.Grupe;
            cmd.Parameters.Add("@MarkPažymis", MySqlDbType.VarChar).Value = mrk.Pažymis;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pažymis įrašytas", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Pažymis neirašytas \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void UpdateMark(Mark mrk, string id)
        {
            string sql = "UPDATE mark SET Vardas = @MarkVardas, Dalykas = @MarkDalykas, Grupe = @MarkGrupe, Pažymis = @MarkPažymis WHERE ID = @MarktID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@MarkVardas", MySqlDbType.VarChar).Value = mrk.Vardas;
            
            cmd.Parameters.Add("@MarkDalykas", MySqlDbType.VarChar).Value = mrk.Dalykas;
            cmd.Parameters.Add("@MarkGrupe", MySqlDbType.VarChar).Value = mrk.Grupe;
            cmd.Parameters.Add("@MarkPažymis", MySqlDbType.VarChar).Value = mrk.Pažymis;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pažymis atnaujintas", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Pažymis neatnaujintas \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void DeleteMark(string id)
        {
            string sql = "DELETE FROM mark WHERE ID = @MarkID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@MarkID", MySqlDbType.Int32).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pažymis pašalintas", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Pažymis nepašalinta \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
