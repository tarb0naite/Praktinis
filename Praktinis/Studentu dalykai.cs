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
    public partial class Studentu_dalykų : Form
    {
        Studentas_prie_dalyko new_stud_to_class;
        public Studentu_dalykų()
        {
            InitializeComponent();
            new_stud_to_class = new Studentas_prie_dalyko(this);
        }

        public void Display()
        {
            DbStudSub.DisplayAndSearch("SELECT ID, Vardas, Dalykas FROM student_sub", dataGridView);
        }


        private void stud_class_Click(object sender, EventArgs e)
        {

            new_stud_to_class.ShowDialog();
        }

        private void Atšaukti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Studentu_grupes_Load(object sender, EventArgs e)
        {

        }

        private void Studentu_grupes_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) //editinimas
            {
                new_stud_to_class.Clear();
                new_stud_to_class.id = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                new_stud_to_class.vardas = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                new_stud_to_class.dalykas = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

                new_stud_to_class.UpdateInfo();
                new_stud_to_class.ShowDialog();
                return;

            }


            if (e.ColumnIndex == 1) //trinimas
            {
                if (MessageBox.Show("Ar tikrai norite pašalinti studentą?", "Informacija", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbStudSub.DeleteStudToSub(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
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
