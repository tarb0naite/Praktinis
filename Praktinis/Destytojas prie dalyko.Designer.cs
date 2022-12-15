
namespace Praktinis2
{
    partial class Destytojas_prie_dalyko
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
            this.Vardas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVardas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPavarde = new System.Windows.Forms.TextBox();
            this.mokomas_dalykas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Atšaukti = new System.Windows.Forms.Button();
            this.Patvirtinti = new System.Windows.Forms.Button();
            this.comboDalykas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Vardas
            // 
            this.Vardas.FormattingEnabled = true;
            this.Vardas.Location = new System.Drawing.Point(64, 75);
            this.Vardas.Name = "Vardas";
            this.Vardas.Size = new System.Drawing.Size(192, 24);
            this.Vardas.TabIndex = 0;
            this.Vardas.SelectedIndexChanged += new System.EventHandler(this.Vardas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Marcellus SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pasirinkite destytoja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Marcellus SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mokomas dalykas:";
            // 
            // txtVardas
            // 
            this.txtVardas.Location = new System.Drawing.Point(218, 122);
            this.txtVardas.Name = "txtVardas";
            this.txtVardas.Size = new System.Drawing.Size(158, 22);
            this.txtVardas.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Marcellus SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Destytojo vardas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Marcellus SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(468, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Destytojo pavarde:";
            // 
            // txtPavarde
            // 
            this.txtPavarde.Location = new System.Drawing.Point(676, 122);
            this.txtPavarde.Name = "txtPavarde";
            this.txtPavarde.Size = new System.Drawing.Size(158, 22);
            this.txtPavarde.TabIndex = 2;
            // 
            // mokomas_dalykas
            // 
            this.mokomas_dalykas.Location = new System.Drawing.Point(218, 323);
            this.mokomas_dalykas.Name = "mokomas_dalykas";
            this.mokomas_dalykas.Size = new System.Drawing.Size(187, 22);
            this.mokomas_dalykas.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Marcellus SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Destytojas mokis:";
            // 
            // Atšaukti
            // 
            this.Atšaukti.BackColor = System.Drawing.Color.Tomato;
            this.Atšaukti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Atšaukti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Atšaukti.Font = new System.Drawing.Font("Marcellus SC", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atšaukti.Location = new System.Drawing.Point(344, 366);
            this.Atšaukti.Name = "Atšaukti";
            this.Atšaukti.Size = new System.Drawing.Size(151, 45);
            this.Atšaukti.TabIndex = 4;
            this.Atšaukti.Text = "Atšaukti";
            this.Atšaukti.UseVisualStyleBackColor = false;
            this.Atšaukti.Click += new System.EventHandler(this.Atšaukti_Click);
            // 
            // Patvirtinti
            // 
            this.Patvirtinti.BackColor = System.Drawing.Color.DarkKhaki;
            this.Patvirtinti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Patvirtinti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Patvirtinti.Font = new System.Drawing.Font("Marcellus SC", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patvirtinti.Location = new System.Drawing.Point(546, 366);
            this.Patvirtinti.Name = "Patvirtinti";
            this.Patvirtinti.Size = new System.Drawing.Size(151, 45);
            this.Patvirtinti.TabIndex = 4;
            this.Patvirtinti.Text = "Patvirtinti";
            this.Patvirtinti.UseVisualStyleBackColor = false;
            this.Patvirtinti.Click += new System.EventHandler(this.Patvirtinti_Click);
            // 
            // comboDalykas
            // 
            this.comboDalykas.FormattingEnabled = true;
            this.comboDalykas.Location = new System.Drawing.Point(45, 264);
            this.comboDalykas.Name = "comboDalykas";
            this.comboDalykas.Size = new System.Drawing.Size(211, 24);
            this.comboDalykas.TabIndex = 5;
            this.comboDalykas.SelectedIndexChanged += new System.EventHandler(this.comboDalykas_SelectedIndexChanged);
            // 
            // Destytojas_prie_dalyko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(880, 450);
            this.Controls.Add(this.comboDalykas);
            this.Controls.Add(this.Patvirtinti);
            this.Controls.Add(this.Atšaukti);
            this.Controls.Add(this.mokomas_dalykas);
            this.Controls.Add(this.txtPavarde);
            this.Controls.Add(this.txtVardas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Vardas);
            this.Name = "Destytojas_prie_dalyko";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Destytojas_prie_dalyko";
            this.Load += new System.EventHandler(this.Destytojas_prie_dalyko_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Vardas;
       // private System.Windows.Forms.ComboBox dalykas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVardas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPavarde;
        private System.Windows.Forms.TextBox mokomas_dalykas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Atšaukti;
        private System.Windows.Forms.Button Patvirtinti;
        private System.Windows.Forms.ComboBox comboDalykas;
    }
}