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
    class DbBendra
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

        public static void AddBendra(Bendra pts)
        {
            string sql = "INSERT INTO all_together VALUES (NULL, @BendraVardas, @BendraDalykas, @BendraGrupe)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            // cmd.Parameters.Add("@StudentID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@BendraVardas", MySqlDbType.VarChar).Value = pts.Vardas;
            cmd.Parameters.Add("@BendraDalykas", MySqlDbType.VarChar).Value = pts.Dalykas;
           cmd.Parameters.Add("@BendraGrupe", MySqlDbType.VarChar).Value = pts.Grupe;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Priskirta", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Nepriskirta \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void UpdateBendra(Bendra pts, string id)
        {
            string sql = "UPDATE all_together SET Vardas = @BendraVardas, Dalykas = @BendraDalykas, Grupe = @BendrasGrupe WHERE ID = @BendraID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@BendraVardas", MySqlDbType.VarChar).Value = pts.Vardas;
           cmd.Parameters.Add("@BendraDalykas", MySqlDbType.VarChar).Value = pts.Dalykas;
            cmd.Parameters.Add("@BendraGrupe", MySqlDbType.VarChar).Value = pts.Grupe;

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
       
        public static void DeleteBendra(string id)
        {
            string sql = "DELETE FROM all_together WHERE ID = @BendraID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@BendraID", MySqlDbType.Int32).Value = id;

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
