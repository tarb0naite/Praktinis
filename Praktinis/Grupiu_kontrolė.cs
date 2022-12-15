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
    public partial class Grupiu_kontrole : Form
    {
        Nauja_grupe new_class;
        public Grupiu_kontrole()
        {
            InitializeComponent();
            new_class = new Nauja_grupe(this);
        }

        

        public void Display()
        {
            DbGrupe.DisplayAndSearch("SELECT ID, Pavadinimas FROM class", dataGridView);
        }

        private void Atšaukti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void Search_TextChanged(object sender, EventArgs e)
        {
            DbStudent.DisplayAndSearch("SELECT ID, Pavadinimas FROM class WHERE Pavadinimas LIKE '%" + Search.Text + "%'", dataGridView);
        }

      

       

        private void nauja_grupe_Click(object sender, EventArgs e)
        {
           new_class.Clear();
            new_class.ShowDialog();

        }

        private void Grupiu_kontrolė_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void Grupiu_kontrolė_Load(object sender, EventArgs e)
        {

        }

        private void Atšaukti_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) //editinimas
            {
                new_class.Clear();
                new_class.id = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                new_class.pavadinimas = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                //new_stud.pavarde = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                new_class.UpdateInfo();
                new_class.ShowDialog();
                return;

            }


            if (e.ColumnIndex == 1) //trinimas
            {
                if (MessageBox.Show("Ar tikrai norite pašalinti grupe?", "Informacija", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbGrupe.DeleteClass(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;

            }
        }
    }
}
