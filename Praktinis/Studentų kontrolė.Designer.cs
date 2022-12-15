
namespace Praktinis2
{
    partial class Studentų_kontrolė
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Itraukti_nauja = new System.Windows.Forms.Button();
            this.Studentu_sarasas = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.TextBox();
            this.Ieškoti = new System.Windows.Forms.Button();
            this.Atšaukti = new System.Windows.Forms.Button();
            this.stud_class = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.OldLace;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column2});
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.Location = new System.Drawing.Point(85, 120);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.Size = new System.Drawing.Size(780, 230);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // Itraukti_nauja
            // 
            this.Itraukti_nauja.BackColor = System.Drawing.Color.Goldenrod;
            this.Itraukti_nauja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Itraukti_nauja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Itraukti_nauja.Font = new System.Drawing.Font("Marcellus SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Itraukti_nauja.Location = new System.Drawing.Point(711, 389);
            this.Itraukti_nauja.Name = "Itraukti_nauja";
            this.Itraukti_nauja.Size = new System.Drawing.Size(154, 63);
            this.Itraukti_nauja.TabIndex = 1;
            this.Itraukti_nauja.Text = "Įtraukti naują";
            this.Itraukti_nauja.UseVisualStyleBackColor = false;
            this.Itraukti_nauja.Click += new System.EventHandler(this.Itraukti_nauja_Click);
            // 
            // Studentu_sarasas
            // 
            this.Studentu_sarasas.AutoSize = true;
            this.Studentu_sarasas.Font = new System.Drawing.Font("Marcellus SC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Studentu_sarasas.Location = new System.Drawing.Point(80, 72);
            this.Studentu_sarasas.Name = "Studentu_sarasas";
            this.Studentu_sarasas.Size = new System.Drawing.Size(216, 30);
            this.Studentu_sarasas.TabIndex = 2;
            this.Studentu_sarasas.Text = "Studentų sąrašas";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(599, 78);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(194, 22);
            this.Search.TabIndex = 3;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // Ieškoti
            // 
            this.Ieškoti.Location = new System.Drawing.Point(790, 78);
            this.Ieškoti.Name = "Ieškoti";
            this.Ieškoti.Size = new System.Drawing.Size(75, 23);
            this.Ieškoti.TabIndex = 4;
            this.Ieškoti.Text = "Ieškoti";
            this.Ieškoti.UseVisualStyleBackColor = true;
            // 
            // Atšaukti
            // 
            this.Atšaukti.BackColor = System.Drawing.Color.Tomato;
            this.Atšaukti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Atšaukti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Atšaukti.Font = new System.Drawing.Font("Marcellus SC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atšaukti.Location = new System.Drawing.Point(428, 390);
            this.Atšaukti.Name = "Atšaukti";
            this.Atšaukti.Size = new System.Drawing.Size(163, 62);
            this.Atšaukti.TabIndex = 5;
            this.Atšaukti.Text = "Atšaukti";
            this.Atšaukti.UseVisualStyleBackColor = false;
            this.Atšaukti.Click += new System.EventHandler(this.Atšaukti_Click);
            // 
            // stud_class
            // 
            this.stud_class.BackColor = System.Drawing.Color.Sienna;
            this.stud_class.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stud_class.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stud_class.Font = new System.Drawing.Font("Marcellus SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stud_class.Location = new System.Drawing.Point(907, 120);
            this.stud_class.Name = "stud_class";
            this.stud_class.Size = new System.Drawing.Size(201, 124);
            this.stud_class.TabIndex = 6;
            this.stud_class.Text = "Priskirti studentus prie dalykų";
            this.stud_class.UseVisualStyleBackColor = false;
            this.stud_class.Click += new System.EventHandler(this.stud_class_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.FillWeight = 85.96974F;
            this.Column1.HeaderText = "#";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Vardas";
            this.Column3.FillWeight = 94.29795F;
            this.Column3.HeaderText = "Vardas";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Pavarde";
            this.Column4.FillWeight = 101.1942F;
            this.Column4.HeaderText = "Pavarde";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column5.FillWeight = 106.9047F;
            this.Column5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Column5.HeaderText = "";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Text = "Redaguoti";
            this.Column5.UseColumnTextForButtonValue = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.FillWeight = 111.6334F;
            this.Column2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Column2.HeaderText = "";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Text = "Ištrinti";
            this.Column2.UseColumnTextForButtonValue = true;
            // 
            // Studentų_kontrolė
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1153, 488);
            this.Controls.Add(this.stud_class);
            this.Controls.Add(this.Atšaukti);
            this.Controls.Add(this.Ieškoti);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Studentu_sarasas);
            this.Controls.Add(this.Itraukti_nauja);
            this.Controls.Add(this.dataGridView);
            this.Name = "Studentų_kontrolė";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studentų_kontrolė";
            this.Load += new System.EventHandler(this.Studentų_kontrolė_Load);
            this.Shown += new System.EventHandler(this.Studentų_kontrolė_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Itraukti_nauja;
        private System.Windows.Forms.Label Studentu_sarasas;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Button Ieškoti;
        private System.Windows.Forms.Button Atšaukti;
        private System.Windows.Forms.Button stud_class;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
    }
}