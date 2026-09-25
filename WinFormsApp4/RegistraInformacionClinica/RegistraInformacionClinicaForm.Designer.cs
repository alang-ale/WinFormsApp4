namespace WinFormsApp4
{
    partial class RegistraInformacionClinicaForm
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
            tabControl1 = new TabControl();
            tabPage4 = new TabPage();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(24, 80);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(661, 169);
            tabControl1.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Margin = new Padding(3, 2, 3, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(653, 141);
            tabPage4.TabIndex = 6;
            tabPage4.Text = "Información clinica";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 13);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 6;
            label3.Text = "En consultorio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 33);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 7;
            label4.Text = "DNI: 17649173";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(154, 33);
            label5.Name = "label5";
            label5.Size = new Size(168, 15);
            label5.TabIndex = 8;
            label5.Text = "Nombre y apellido: Jorge Avila";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(394, 33);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 9;
            label6.Text = "Tipo: Particular";
            // 
            // panel1
            // 
            panel1.Location = new Point(24, 11);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(626, 46);
            panel1.TabIndex = 10;
            // 
            // RegistraInformacionClinicaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 317);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegistraInformacionClinicaForm";
            Text = "ConsultaOdontologo";
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage4;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel1;
    }
}