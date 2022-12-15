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
    public partial class Destytojas : Form
    {
        Naujas_pazimys mark;
        public Destytojas()
        {
            InitializeComponent();
            mark = new Naujas_pazimys(this);
        }

        public void Display()
        {
           DbPazimys.DisplayAndSearch("SELECT ID, Vardas, Dalykas, Grupe, Pažymis FROM mark", dataGridView);
        }

        private void Ivertinti_Click(object sender, EventArgs e)
        {
            mark.Clear();
            mark.ShowDialog();
        }

        private void Atšaukti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Destytojas_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) //editinimas
            {
                mark.Clear();
                mark.id = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                mark.vardas = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                mark.dalykas = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                mark.grupe = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
               mark.pažymis = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();

                mark.UpdateInfo();
                mark.ShowDialog();
                return;

            }


            if (e.ColumnIndex == 1) //trinimas
            {
                if (MessageBox.Show("Ar tikrai norite pašalinti pažymi?", "Informacija", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbMark.DeleteMark(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;

            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Destytojas_Shown(object sender, EventArgs e)
        {
            Display();
        }
    }
}
