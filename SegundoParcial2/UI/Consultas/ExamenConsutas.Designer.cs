namespace SegundoParcial2.UI.Consultas
{
    partial class ExamenConsutas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamenConsutas));
            this.Consultar_button = new System.Windows.Forms.Button();
            this.Consulta_dataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Hasta_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Desde_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Criterio = new System.Windows.Forms.Label();
            this.Fltro = new System.Windows.Forms.Label();
            this.Criterio_textBox = new System.Windows.Forms.TextBox();
            this.Filtro_comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Consulta_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Consultar_button
            // 
            this.Consultar_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Consultar_button.ForeColor = System.Drawing.Color.Black;
            this.Consultar_button.Image = ((System.Drawing.Image)(resources.GetObject("Consultar_button.Image")));
            this.Consultar_button.Location = new System.Drawing.Point(452, 49);
            this.Consultar_button.Name = "Consultar_button";
            this.Consultar_button.Size = new System.Drawing.Size(71, 64);
            this.Consultar_button.TabIndex = 19;
            this.Consultar_button.Text = "Consultar";
            this.Consultar_button.UseVisualStyleBackColor = false;
            this.Consultar_button.Click += new System.EventHandler(this.Consultar_button_Click);
            // 
            // Consulta_dataGridView
            // 
            this.Consulta_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Consulta_dataGridView.Location = new System.Drawing.Point(12, 154);
            this.Consulta_dataGridView.Name = "Consulta_dataGridView";
            this.Consulta_dataGridView.Size = new System.Drawing.Size(560, 284);
            this.Consulta_dataGridView.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Hasta";
            // 
            // Hasta_dateTimePicker
            // 
            this.Hasta_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Hasta_dateTimePicker.Location = new System.Drawing.Point(294, 97);
            this.Hasta_dateTimePicker.Name = "Hasta_dateTimePicker";
            this.Hasta_dateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.Hasta_dateTimePicker.TabIndex = 15;
            // 
            // Desde_dateTimePicker
            // 
            this.Desde_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Desde_dateTimePicker.Location = new System.Drawing.Point(81, 97);
            this.Desde_dateTimePicker.Name = "Desde_dateTimePicker";
            this.Desde_dateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.Desde_dateTimePicker.TabIndex = 14;
            // 
            // Criterio
            // 
            this.Criterio.AutoSize = true;
            this.Criterio.Location = new System.Drawing.Point(219, 53);
            this.Criterio.Name = "Criterio";
            this.Criterio.Size = new System.Drawing.Size(39, 13);
            this.Criterio.TabIndex = 13;
            this.Criterio.Text = "Criterio";
            // 
            // Fltro
            // 
            this.Fltro.AutoSize = true;
            this.Fltro.Location = new System.Drawing.Point(22, 53);
            this.Fltro.Name = "Fltro";
            this.Fltro.Size = new System.Drawing.Size(29, 13);
            this.Fltro.TabIndex = 12;
            this.Fltro.Text = "Filtro";
            // 
            // Criterio_textBox
            // 
            this.Criterio_textBox.Location = new System.Drawing.Point(294, 49);
            this.Criterio_textBox.Name = "Criterio_textBox";
            this.Criterio_textBox.Size = new System.Drawing.Size(100, 20);
            this.Criterio_textBox.TabIndex = 11;
            // 
            // Filtro_comboBox
            // 
            this.Filtro_comboBox.FormattingEnabled = true;
            this.Filtro_comboBox.Items.AddRange(new object[] {
            " todos",
            "   id",
            "Nombre",
            "Fecha"});
            this.Filtro_comboBox.Location = new System.Drawing.Point(79, 49);
            this.Filtro_comboBox.Name = "Filtro_comboBox";
            this.Filtro_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Filtro_comboBox.TabIndex = 10;
            // 
            // ExamenConsutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.Consultar_button);
            this.Controls.Add(this.Consulta_dataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Hasta_dateTimePicker);
            this.Controls.Add(this.Desde_dateTimePicker);
            this.Controls.Add(this.Criterio);
            this.Controls.Add(this.Fltro);
            this.Controls.Add(this.Criterio_textBox);
            this.Controls.Add(this.Filtro_comboBox);
            this.Name = "ExamenConsutas";
            this.Text = "ExamenConsutas";
            ((System.ComponentModel.ISupportInitialize)(this.Consulta_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Consultar_button;
        private System.Windows.Forms.DataGridView Consulta_dataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Hasta_dateTimePicker;
        private System.Windows.Forms.DateTimePicker Desde_dateTimePicker;
        private System.Windows.Forms.Label Criterio;
        private System.Windows.Forms.Label Fltro;
        private System.Windows.Forms.TextBox Criterio_textBox;
        private System.Windows.Forms.ComboBox Filtro_comboBox;
    }
}