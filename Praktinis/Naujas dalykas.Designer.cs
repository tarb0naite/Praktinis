
namespace Praktinis2
{
    partial class Naujas_dalykas
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
            this.label1 = new System.Windows.Forms.Label();
            this.Itraukti = new System.Windows.Forms.Button();
            this.Atšaukti = new System.Windows.Forms.Button();
            this.Pavadinimas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Marcellus SC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pavadinimas:";
            // 
            // Itraukti
            // 
            this.Itraukti.BackColor = System.Drawing.Color.DarkKhaki;
            this.Itraukti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Itraukti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Itraukti.Font = new System.Drawing.Font("Marcellus SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Itraukti.Location = new System.Drawing.Point(295, 280);
            this.Itraukti.Name = "Itraukti";
            this.Itraukti.Size = new System.Drawing.Size(131, 39);
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
            this.Atšaukti.Location = new System.Drawing.Point(76, 280);
            this.Atšaukti.Name = "Atšaukti";
            this.Atšaukti.Size = new System.Drawing.Size(131, 39);
            this.Atšaukti.TabIndex = 1;
            this.Atšaukti.Text = "Atšaukti";
            this.Atšaukti.UseVisualStyleBackColor = false;
            this.Atšaukti.Click += new System.EventHandler(this.Atšaukti_Click);
            // 
            // Pavadinimas
            // 
            this.Pavadinimas.Location = new System.Drawing.Point(76, 146);
            this.Pavadinimas.Name = "Pavadinimas";
            this.Pavadinimas.Size = new System.Drawing.Size(339, 22);
            this.Pavadinimas.TabIndex = 2;
            // 
            // Naujas_dalykas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(509, 372);
            this.Controls.Add(this.Pavadinimas);
            this.Controls.Add(this.Atšaukti);
            this.Controls.Add(this.Itraukti);
            this.Controls.Add(this.label1);
            this.Name = "Naujas_dalykas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Naujas_dalykas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Itraukti;
        private System.Windows.Forms.Button Atšaukti;
        private System.Windows.Forms.TextBox Pavadinimas;
    }
}