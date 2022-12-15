
namespace Praktinis2
{
    partial class Naujas_studentas
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
            this.Itraukti = new System.Windows.Forms.Button();
            this.Atšaukti = new System.Windows.Forms.Button();
            this.txtPavarde = new System.Windows.Forms.TextBox();
            this.txtVardas = new System.Windows.Forms.TextBox();
            this.Vardas = new System.Windows.Forms.Label();
            this.Pavarde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Itraukti
            // 
            this.Itraukti.BackColor = System.Drawing.Color.Goldenrod;
            this.Itraukti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Itraukti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Itraukti.Font = new System.Drawing.Font("Marcellus SC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Itraukti.Location = new System.Drawing.Point(300, 360);
            this.Itraukti.Name = "Itraukti";
            this.Itraukti.Size = new System.Drawing.Size(165, 43);
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
            this.Atšaukti.Font = new System.Drawing.Font("Marcellus SC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atšaukti.Location = new System.Drawing.Point(80, 360);
            this.Atšaukti.Name = "Atšaukti";
            this.Atšaukti.Size = new System.Drawing.Size(165, 43);
            this.Atšaukti.TabIndex = 0;
            this.Atšaukti.Text = "Atšaukti";
            this.Atšaukti.UseVisualStyleBackColor = false;
            this.Atšaukti.Click += new System.EventHandler(this.Atšaukti_Click);
            // 
            // txtPavarde
            // 
            this.txtPavarde.Location = new System.Drawing.Point(106, 226);
            this.txtPavarde.Name = "txtPavarde";
            this.txtPavarde.Size = new System.Drawing.Size(306, 22);
            this.txtPavarde.TabIndex = 1;
            // 
            // txtVardas
            // 
            this.txtVardas.Location = new System.Drawing.Point(96, 105);
            this.txtVardas.Name = "txtVardas";
            this.txtVardas.Size = new System.Drawing.Size(306, 22);
            this.txtVardas.TabIndex = 1;
            // 
            // Vardas
            // 
            this.Vardas.AutoSize = true;
            this.Vardas.Font = new System.Drawing.Font("Marcellus SC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vardas.Location = new System.Drawing.Point(27, 59);
            this.Vardas.Name = "Vardas";
            this.Vardas.Size = new System.Drawing.Size(218, 30);
            this.Vardas.TabIndex = 2;
            this.Vardas.Text = "Studento vardas:";
            // 
            // Pavarde
            // 
            this.Pavarde.AutoSize = true;
            this.Pavarde.Font = new System.Drawing.Font("Marcellus SC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pavarde.Location = new System.Drawing.Point(30, 178);
            this.Pavarde.Name = "Pavarde";
            this.Pavarde.Size = new System.Drawing.Size(231, 30);
            this.Pavarde.TabIndex = 2;
            this.Pavarde.Text = "Studento pavarde:";
            // 
            // Naujas_studentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(563, 450);
            this.Controls.Add(this.Pavarde);
            this.Controls.Add(this.Vardas);
            this.Controls.Add(this.txtVardas);
            this.Controls.Add(this.txtPavarde);
            this.Controls.Add(this.Atšaukti);
            this.Controls.Add(this.Itraukti);
            this.Name = "Naujas_studentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Naujas_studentas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Itraukti;
        private System.Windows.Forms.Button Atšaukti;
        private System.Windows.Forms.TextBox txtPavarde;
        private System.Windows.Forms.TextBox txtVardas;
        private System.Windows.Forms.Label Vardas;
        private System.Windows.Forms.Label Pavarde;
    }
}