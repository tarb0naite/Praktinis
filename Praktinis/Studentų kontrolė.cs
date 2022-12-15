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
    public partial class Studentų_kontrolė : Form
    {
        Naujas_studentas new_stud;

        public Studentų_kontrolė()
        {
            InitializeComponent();
            new_stud = new Naujas_studentas(this);
        }

        public void Display()
        {
            DbStudent.DisplayAndSearch("SELECT ID, Vardas, Pavarde FROM student", dataGridView); 
        }

        private void Itraukti_nauja_Click(object sender, EventArgs e)
        {
            //Naujas_studentas new_stud = new Naujas_studentas(this);
            new_stud.Clear();
            new_stud.ShowDialog();
        }

        private void Studentų_kontrolė_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void Atšaukti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Studentų_kontrolė_Load(object sender, EventArgs e)
        {

        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            DbStudent.DisplayAndSearch("SELECT ID, Vardas, Pavarde FROM student WHERE Vardas LIKE '%" + Search.Text + "%'", dataGridView);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void stud_class_Click(object sender, EventArgs e)
        {
            Studentu_dalykų stud_clas = new Studentu_dalykų();
            stud_clas.ShowDialog();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0) //editinimas
            {
                new_stud.Clear();
                new_stud.id = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                new_stud.vardas = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                new_stud.pavarde = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                new_stud.UpdateInfo();
                new_stud.ShowDialog();
                return;

            }


            if (e.ColumnIndex == 1) //trinimas
            {
                if (MessageBox.Show("Ar tikrai norite pašalinti studentą?", "Informacija", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbStudent.DeleteStudent(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;

            }
        }
    }
}
