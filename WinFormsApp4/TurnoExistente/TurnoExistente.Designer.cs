namespace WinFormsApp4.TurnoExistente
{
    partial class TurnoExistente
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
            dataGridView1 = new DataGridView();
            Hora = new DataGridViewTextBoxColumn();
            Paciente = new DataGridViewTextBoxColumn();
            Profesional = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewCheckBoxColumn();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            checkedListBox1 = new CheckedListBox();
            listBox1 = new ListBox();
            Cobertura = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            checkedListBox2 = new CheckedListBox();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Hora, Paciente, Profesional, Column2 });
            dataGridView1.Location = new Point(12, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(563, 89);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Hora
            // 
            Hora.HeaderText = "Hora";
            Hora.MinimumWidth = 6;
            Hora.Name = "Hora";
            Hora.Width = 125;
            // 
            // Paciente
            // 
            Paciente.HeaderText = "Paciente";
            Paciente.MinimumWidth = 6;
            Paciente.Name = "Paciente";
            Paciente.Width = 125;
            // 
            // Profesional
            // 
            Profesional.HeaderText = "Profesional";
            Profesional.MinimumWidth = 6;
            Profesional.Name = "Profesional";
            Profesional.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Anunciar";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(63, 24);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(310, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 27);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 2;
            label1.Text = "Día:";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(checkedListBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Cobertura);
            panel1.Controls.Add(listBox1);
            panel1.Location = new Point(12, 163);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 240);
            panel1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(585, 409);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 9;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(694, 409);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.White;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Cobrar ahora", "Cobrar al finalizar" });
            checkedListBox1.Location = new Point(600, 68);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(159, 48);
            checkedListBox1.TabIndex = 11;
            // 
            // listBox1
            // 
            listBox1.AllowDrop = true;
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Particular", "Swiss medical", "OSDE" });
            listBox1.Location = new Point(95, 6);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 24);
            listBox1.TabIndex = 0;
            // 
            // Cobertura
            // 
            Cobertura.AutoSize = true;
            Cobertura.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cobertura.Location = new Point(4, 7);
            Cobertura.Name = "Cobertura";
            Cobertura.Size = new Size(83, 20);
            Cobertura.TabIndex = 12;
            Cobertura.Text = "Cobertura:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(4, 48);
            label2.Name = "label2";
            label2.Size = new Size(173, 20);
            label2.TabIndex = 13;
            label2.Text = "Descripción del servicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 77);
            label3.Name = "label3";
            label3.Size = new Size(759, 40);
            label3.TabIndex = 14;
            label3.Text = "Eliminación del tejido dental afectado por caries y posterior restauración de la pieza mediante resina compuesta,\r\nbuscando recuperar su forma, función y estética original.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(4, 130);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 15;
            label4.Text = "Medio de pago";
            // 
            // checkedListBox2
            // 
            checkedListBox2.BackColor = Color.White;
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "Tarjeta", "Efectivo", "Transferencia" });
            checkedListBox2.Location = new Point(4, 163);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(159, 70);
            checkedListBox2.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(553, 202);
            label5.Name = "label5";
            label5.Size = new Size(93, 31);
            label5.TabIndex = 12;
            label5.Text = "Monto:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(652, 202);
            label6.Name = "label6";
            label6.Size = new Size(111, 31);
            label6.TabIndex = 16;
            label6.Text = "$160.000";
            // 
            // TurnoExistente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkedListBox1);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Name = "TurnoExistente";
            Text = "TurnoExistente";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewTextBoxColumn Paciente;
        private DataGridViewTextBoxColumn Profesional;
        private DataGridViewCheckBoxColumn Column2;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private CheckedListBox checkedListBox1;
        private Label label2;
        private Label Cobertura;
        private ListBox listBox1;
        private Label label3;
        private Label label6;
        private Label label5;
        private CheckedListBox checkedListBox2;
        private Label label4;
    }
}