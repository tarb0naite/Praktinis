using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktinis2
{
    public partial class Dalyku_kontrole : Form
    {
        Naujas_dalykas new_sub;
        public Dalyku_kontrole()
        {
            InitializeComponent();
            new_sub = new Naujas_dalykas(this);
        }
        public void Display()
        {
            DbSubject.DisplayAndSearch("SELECT ID, Pavadinimas FROM subject", dataGridView);
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            DbSubject.DisplayAndSearch("SELECT ID, Pavadinimas FROM subject WHERE Pavadinimas LIKE '%" + Search.Text + "%'", dataGridView);
        } 



        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) //editinimas
            {
                new_sub.Clear();
                new_sub.id = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                new_sub.pavadinimas = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                
                new_sub.UpdateInfo();
                new_sub.ShowDialog();
                return;

            }


            if (e.ColumnIndex == 1) //trinimas
            {
                if (MessageBox.Show("Ar tikrai norite pašalinti grupe?", "Informacija", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbSubject.DeleteSub(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;

            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dalyku_kontrole_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void Dalyku_kontrole_Load(object sender, EventArgs e)
        {

        }

        private void naujas_dal_Click(object sender, EventArgs e)
        {
            new_sub.Clear();
            new_sub.ShowDialog();
        }

        private void Ašaukti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dalykas_prie_grupe_Click(object sender, EventArgs e)
        {
            
        }
    }
}
