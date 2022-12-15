
namespace Praktinis2
{
    partial class Studentas_prie_dalyko
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
            this.comboVardas = new System.Windows.Forms.ComboBox();
            this.comboGrupe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Atšaukti = new System.Windows.Forms.Button();
            this.Išsaugoti = new System.Windows.Forms.Button();
            this.txtVardas = new System.Windows.Forms.TextBox();
            this.txtGrupe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboVardas
            // 
            this.comboVardas.FormattingEnabled = true;
            this.comboVardas.Location = new System.Drawing.Point(124, 115);
            this.comboVardas.Name = "comboVardas";
            this.comboVardas.Size = new System.Drawing.Size(196, 24);
            this.comboVardas.TabIndex = 0;
            this.comboVardas.SelectedIndexChanged += new System.EventHandler(this.comboVardas_SelectedIndexChanged);
            // 
            // comboGrupe
            // 
            this.comboGrupe.FormattingEnabled = true;
            this.comboGrupe.Location = new System.Drawing.Point(170, 222);
            this.comboGrupe.Name = "comboGrupe";
            this.comboGrupe.Size = new System.Drawing.Size(150, 24);
            this.comboGrupe.TabIndex = 0;
            this.comboGrupe.SelectedIndexChanged += new System.EventHandler(this.Grupe_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Marcellus SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pasirinkite studento vardą:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Marcellus SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Priskirkite mokamą dalyką:";
            // 
            // Atšaukti
            // 
            this.Atšaukti.BackColor = System.Drawing.Color.Tomato;
            this.Atšaukti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Atšaukti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Atšaukti.Font = new System.Drawing.Font("Marcellus SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atšaukti.Location = new System.Drawing.Point(250, 333);
            this.Atšaukti.Name = "Atšaukti";
            this.Atšaukti.Size = new System.Drawing.Size(127, 41);
            this.Atšaukti.TabIndex = 2;
            this.Atšaukti.Text = "Atšaukti";
            this.Atšaukti.UseVisualStyleBackColor = false;
            this.Atšaukti.Click += new System.EventHandler(this.Atšaukti_Click);
            // 
            // Išsaugoti
            // 
            this.Išsaugoti.BackColor = System.Drawing.Color.DarkKhaki;
            this.Išsaugoti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Išsaugoti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Išsaugoti.Font = new System.Drawing.Font("Marcellus SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Išsaugoti.Location = new System.Drawing.Point(442, 333);
            this.Išsaugoti.Name = "Išsaugoti";
            this.Išsaugoti.Size = new System.Drawing.Size(117, 41);
            this.Išsaugoti.TabIndex = 2;
            this.Išsaugoti.Text = "Išsaugoti";
            this.Išsaugoti.UseVisualStyleBackColor = false;
            this.Išsaugoti.Click += new System.EventHandler(this.Išsaugoti_Click);
            // 
            // txtVardas
            // 
            this.txtVardas.Location = new System.Drawing.Point(402, 117);
            this.txtVardas.Name = "txtVardas";
            this.txtVardas.Size = new System.Drawing.Size(144, 22);
            this.txtVardas.TabIndex = 3;
            // 
            // txtGrupe
            // 
            this.txtGrupe.Location = new System.Drawing.Point(402, 224);
            this.txtGrupe.Name = "txtGrupe";
            this.txtGrupe.Size = new System.Drawing.Size(144, 22);
            this.txtGrupe.TabIndex = 3;
            // 
            // Studentas_prie_dalyko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.txtGrupe);
            this.Controls.Add(this.txtVardas);
            this.Controls.Add(this.Išsaugoti);
            this.Controls.Add(this.Atšaukti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboGrupe);
            this.Controls.Add(this.comboVardas);
            this.Name = "Studentas_prie_dalyko";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studentas_prie_dalyko";
            this.Load += new System.EventHandler(this.Studentas_prie_grupes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboVardas;
        private System.Windows.Forms.ComboBox comboGrupe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Atšaukti;
        private System.Windows.Forms.Button Išsaugoti;
        private System.Windows.Forms.TextBox txtVardas;
        private System.Windows.Forms.TextBox txtGrupe;
    }
}