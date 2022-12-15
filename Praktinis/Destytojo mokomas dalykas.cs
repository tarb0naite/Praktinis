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
    public partial class Destytojo_mokomas_dalykas : Form
    {
        Destytojas_prie_dalyko prof;

        public Destytojo_mokomas_dalykas()
        {
            InitializeComponent();
            prof = new Destytojas_prie_dalyko(this);
        }

        public void Display()
        {
            DbProfSub.DisplayAndSearch("SELECT ID, Vardas, Pavarde, Dalykas FROM prof_sub", dataGridView);
        }

        private void Priskirti_Click(object sender, EventArgs e)
        {
            prof.Clear();
            prof.ShowDialog();
        }

        private void Atšaukti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Destytojo_mokomas_dalykas_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) //editinimas
            {
                prof.Clear();
                prof.id = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                prof.vardas = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                prof.pavarde = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                prof.UpdateInfo();
                prof.ShowDialog();
                return;

            }


            if (e.ColumnIndex == 1) //trinimas
            {
                if (MessageBox.Show("Ar tikrai norite pašalinti studentą?", "Informacija", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbProfSub.DeleteProfToSub(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;

            }
        }

        private void Destytojo_mokomas_dalykas_Shown(object sender, EventArgs e)
        {
            Display();
        }
    }
}
