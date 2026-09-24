namespace WinFormsApp4
{
    partial class NuevoTurnoForm
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            label10 = new Label();
            richTextBox1 = new RichTextBox();
            label9 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            dateTimePicker2 = new DateTimePicker();
            label11 = new Label();
            listBox1 = new ListBox();
            checkBox1 = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(44, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(197, 20);
            label1.TabIndex = 1;
            label1.Text = "Ingrese el DNI del paciente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(361, 47);
            label2.Name = "label2";
            label2.Size = new Size(315, 20);
            label2.TabIndex = 2;
            label2.Text = "No se encontró paciente con el DNI ingresado";
            // 
            // button1
            // 
            button1.Location = new Point(251, 43);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(42, 163);
            panel1.Name = "panel1";
            panel1.Size = new Size(717, 245);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(15, 8);
            label10.Name = "label10";
            label10.Size = new Size(101, 20);
            label10.TabIndex = 4;
            label10.Text = "Fecha y hora:";
            label10.Click += label10_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(15, 115);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(684, 120);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(15, 86);
            label9.Name = "label9";
            label9.Size = new Size(203, 20);
            label9.TabIndex = 1;
            label9.Text = "Descripción del tratamiento";
            // 
            // panel2
            // 
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(42, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(717, 79);
            panel2.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(577, 11);
            label8.Name = "label8";
            label8.Size = new Size(85, 20);
            label8.TabIndex = 11;
            label8.Text = "01/07/1980";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(138, 46);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 10;
            label7.Text = "10/06/2026";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(92, 11);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 9;
            label6.Text = "Jorge X";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 46);
            label5.Name = "label5";
            label5.Size = new Size(124, 20);
            label5.TabIndex = 8;
            label5.Text = "Ultima atención:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(418, 11);
            label4.Name = "label4";
            label4.Size = new Size(156, 20);
            label4.TabIndex = 7;
            label4.Text = "Fecha de nacimiento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 11);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 6;
            label3.Text = "Paciente: ";
            // 
            // button2
            // 
            button2.Location = new Point(682, 414);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(573, 414);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 7;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(118, 7);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(301, 27);
            dateTimePicker2.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(15, 44);
            label11.Name = "label11";
            label11.Size = new Size(92, 20);
            label11.TabIndex = 6;
            label11.Text = "Profesional:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Avila", "Arias" });
            listBox1.Location = new Point(118, 44);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(301, 24);
            listBox1.TabIndex = 7;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(589, 11);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(110, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Sobreturno";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // NuevoTurno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(panel2);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "NuevoTurno";
            Text = "NuevoTurno";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label10;
        private RichTextBox richTextBox1;
        private Label label9;
        private Button button3;
        private Button button2;
        private DateTimePicker dateTimePicker2;
        private ListBox listBox1;
        private Label label11;
        private CheckBox checkBox1;
    }
}