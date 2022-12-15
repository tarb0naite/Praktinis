
namespace Praktinis2
{
    partial class Nauja_grupe
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
            this.Pavadinimas = new System.Windows.Forms.TextBox();
            this.Itraukti = new System.Windows.Forms.Button();
            this.Atšaukti = new System.Windows.Forms.Button();
            this.pav = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Pavadinimas
            // 
            this.Pavadinimas.Location = new System.Drawing.Point(248, 129);
            this.Pavadinimas.Name = "Pavadinimas";
            this.Pavadinimas.Size = new System.Drawing.Size(230, 22);
            this.Pavadinimas.TabIndex = 0;
            // 
            // Itraukti
            // 
            this.Itraukti.BackColor = System.Drawing.Color.DarkKhaki;
            this.Itraukti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Itraukti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Itraukti.Font = new System.Drawing.Font("Marcellus SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Itraukti.Location = new System.Drawing.Point(321, 260);
            this.Itraukti.Name = "Itraukti";
            this.Itraukti.Size = new System.Drawing.Size(194, 57);
            this.Itraukti.TabIndex = 0;
            this.Itraukti.Text = "Įtraukti";
            this.Itraukti.UseVisualStyleBackColor = false;
            this.Itraukti.Click += new System.EventHandler(this.Itraukti_Click);
            // 
            // Atšaukti
            // 
            this.Atšaukti.BackColor = System.Drawing.Color.Tomato;
            this.Atšaukti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Atšaukti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Atšaukti.Font = new System.Drawing.Font("Marcellus SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atšaukti.Location = new System.Drawing.Point(63, 260);
            this.Atšaukti.Name = "Atšaukti";
            this.Atšaukti.Size = new System.Drawing.Size(194, 57);
            this.Atšaukti.TabIndex = 1;
            this.Atšaukti.Text = "Atšaukti";
            this.Atšaukti.UseVisualStyleBackColor = false;
            this.Atšaukti.Click += new System.EventHandler(this.Atšaukti_Click);
            // 
            // pav
            // 
            this.pav.AutoSize = true;
            this.pav.Font = new System.Drawing.Font("Marcellus SC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pav.Location = new System.Drawing.Point(49, 73);
            this.pav.Name = "pav";
            this.pav.Size = new System.Drawing.Size(336, 30);
            this.pav.TabIndex = 2;
            this.pav.Text = "Naujos grupės pavadinimas:";
            // 
            // Nauja_grupe
            // 
            this.AcceptButton = this.Itraukti;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(623, 415);
            this.Controls.Add(this.pav);
            this.Controls.Add(this.Atšaukti);
            this.Controls.Add(this.Itraukti);
            this.Controls.Add(this.Pavadinimas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Nauja_grupe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nauja_grupe";
            this.Load += new System.EventHandler(this.Nauja_grupe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Pavadinimas;
        private System.Windows.Forms.Button Itraukti;
        private System.Windows.Forms.Button Atšaukti;
        private System.Windows.Forms.Label pav;
    }
}