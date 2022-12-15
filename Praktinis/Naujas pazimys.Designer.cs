
namespace Praktinis2
{
    partial class Naujas_pazimys
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
            this.Pateikti = new System.Windows.Forms.Button();
            this.Atšaukti = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pazymis = new System.Windows.Forms.TextBox();
            this.textVardas = new System.Windows.Forms.TextBox();
            this.textDalykas = new System.Windows.Forms.TextBox();
            this.textGrupe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboVardas
            // 
            this.comboVardas.FormattingEnabled = true;
            this.comboVardas.Location = new System.Drawing.Point(364, 44);
            this.comboVardas.Name = "comboVardas";
            this.comboVardas.Size = new System.Drawing.Size(149, 24);
            this.comboVardas.TabIndex = 0;
            this.comboVardas.SelectedIndexChanged += new System.EventHandler(this.comboVardas_SelectedIndexChanged);
            // 
            // Pateikti
            // 
            this.Pateikti.BackColor = System.Drawing.Color.DarkKhaki;
            this.Pateikti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pateikti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Pateikti.Font = new System.Drawing.Font("Marcellus SC", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pateikti.Location = new System.Drawing.Point(197, 333);
            this.Pateikti.Name = "Pateikti";
            this.Pateikti.Size = new System.Drawing.Size(125, 46);
            this.Pateikti.TabIndex = 2;
            this.Pateikti.Text = "Pateikti";
            this.Pateikti.UseVisualStyleBackColor = false;
            this.Pateikti.Click += new System.EventHandler(this.Pateikti_Click);
            // 
            // Atšaukti
            // 
            this.Atšaukti.BackColor = System.Drawing.Color.Tomato;
            this.Atšaukti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Atšaukti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Atšaukti.Font = new System.Drawing.Font("Marcellus SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atšaukti.Location = new System.Drawing.Point(25, 333);
            this.Atšaukti.Name = "Atšaukti";
            this.Atšaukti.Size = new System.Drawing.Size(128, 46);
            this.Atšaukti.TabIndex = 2;
            this.Atšaukti.Text = "Atšaukti";
            this.Atšaukti.UseVisualStyleBackColor = false;
            this.Atšaukti.Click += new System.EventHandler(this.Atšaukti_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Marcellus SC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pasirinkite studento vardą:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Marcellus SC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parinkite pažymį:";
            // 
            // pazymis
            // 
            this.pazymis.Location = new System.Drawing.Point(250, 245);
            this.pazymis.Name = "pazymis";
            this.pazymis.Size = new System.Drawing.Size(127, 22);
            this.pazymis.TabIndex = 4;
            // 
            // textVardas
            // 
            this.textVardas.Location = new System.Drawing.Point(25, 166);
            this.textVardas.Name = "textVardas";
            this.textVardas.Size = new System.Drawing.Size(147, 22);
            this.textVardas.TabIndex = 5;
            // 
            // textDalykas
            // 
            this.textDalykas.Location = new System.Drawing.Point(273, 166);
            this.textDalykas.Name = "textDalykas";
            this.textDalykas.Size = new System.Drawing.Size(142, 22);
            this.textDalykas.TabIndex = 6;
            // 
            // textGrupe
            // 
            this.textGrupe.Location = new System.Drawing.Point(525, 166);
            this.textGrupe.Name = "textGrupe";
            this.textGrupe.Size = new System.Drawing.Size(148, 22);
            this.textGrupe.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Marcellus SC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Studento vardas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Marcellus SC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(269, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Studento dalykas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Marcellus SC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(530, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Studento grupė";
            // 
            // Naujas_pazimys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(771, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textGrupe);
            this.Controls.Add(this.textDalykas);
            this.Controls.Add(this.textVardas);
            this.Controls.Add(this.pazymis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Atšaukti);
            this.Controls.Add(this.Pateikti);
            this.Controls.Add(this.comboVardas);
            this.Name = "Naujas_pazimys";
            this.Text = "Naujas_pazimys";
            this.Load += new System.EventHandler(this.Naujas_pazimys_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboVardas;
        private System.Windows.Forms.Button Pateikti;
        private System.Windows.Forms.Button Atšaukti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pazymis;
        private System.Windows.Forms.TextBox textVardas;
        private System.Windows.Forms.TextBox textDalykas;
        private System.Windows.Forms.TextBox textGrupe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}