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
    public partial class Stud_Ir_Dal_Prie_Grupes_Kontrole : Form
    {
        Naujas_Stud_Ir_Dal_Prie_Grupes all;
        public Stud_Ir_Dal_Prie_Grupes_Kontrole()
        {
            InitializeComponent();
            all = new Naujas_Stud_Ir_Dal_Prie_Grupes(this);
        }

        public void Display()
        {
            DbBendra.DisplayAndSearch("SELECT ID, Vardas, Dalykas, Grupe FROM all_together", dataGridView);
        }

        private void Prideti_Click(object sender, EventArgs e)
        {
            all.Clear();
            all.ShowDialog();
        }

        private void Atšaukti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Stud_Ir_Dal_Prie_Grupes_Kontrole_Load(object sender, EventArgs e)
        {

        }

        private void Stud_Ir_Dal_Prie_Grupes_Kontrole_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) //editinimas
            {
                all.Clear();
                all.id = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                all.vardas = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                all.dalykas = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                all.grupe = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
               
                all.UpdateInfo();
                all.ShowDialog();
                return;

            }
          


            if (e.ColumnIndex == 1) //trinimas
            {
                if (MessageBox.Show("Ar tikrai norite pašalinti?", "Informacija", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbBendra.DeleteBendra(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;

            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
