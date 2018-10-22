namespace SegundoParcial2.UI.Registros
{
    partial class ExamenRegistro
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label rotacionLabel1;
            System.Windows.Forms.Label retencionLabel;
            System.Windows.Forms.Label sueldoLabel;
            System.Windows.Forms.Label vendedorIdLabel;
            System.Windows.Forms.Label nombreLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.Fecha_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rotacionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.retencionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sueldoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.vendedorIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.Buscar_button = new System.Windows.Forms.Button();
            this.Elimiinar_button = new System.Windows.Forms.Button();
            this.Gualdar_button = new System.Windows.Forms.Button();
            this.Nuevo_button = new System.Windows.Forms.Button();
            this.SuperErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            rotacionLabel1 = new System.Windows.Forms.Label();
            retencionLabel = new System.Windows.Forms.Label();
            sueldoLabel = new System.Windows.Forms.Label();
            vendedorIdLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rotacionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retencionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sueldoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Fecha";
            // 
            // Fecha_dateTimePicker
            // 
            this.Fecha_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Fecha_dateTimePicker.Location = new System.Drawing.Point(257, 161);
            this.Fecha_dateTimePicker.Name = "Fecha_dateTimePicker";
            this.Fecha_dateTimePicker.Size = new System.Drawing.Size(95, 20);
            this.Fecha_dateTimePicker.TabIndex = 32;
            // 
            // rotacionLabel1
            // 
            rotacionLabel1.AutoSize = true;
            rotacionLabel1.Location = new System.Drawing.Point(6, 191);
            rotacionLabel1.Name = "rotacionLabel1";
            rotacionLabel1.Size = new System.Drawing.Size(48, 13);
            rotacionLabel1.TabIndex = 29;
            rotacionLabel1.Text = "rotacion:";
            // 
            // rotacionNumericUpDown
            // 
            this.rotacionNumericUpDown.DecimalPlaces = 2;
            this.rotacionNumericUpDown.Enabled = false;
            this.rotacionNumericUpDown.Location = new System.Drawing.Point(76, 191);
            this.rotacionNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.rotacionNumericUpDown.Name = "rotacionNumericUpDown";
            this.rotacionNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.rotacionNumericUpDown.TabIndex = 31;
            // 
            // retencionLabel
            // 
            retencionLabel.AutoSize = true;
            retencionLabel.Location = new System.Drawing.Point(7, 157);
            retencionLabel.Name = "retencionLabel";
            retencionLabel.Size = new System.Drawing.Size(54, 13);
            retencionLabel.TabIndex = 28;
            retencionLabel.Text = "retencion:";
            // 
            // retencionNumericUpDown
            // 
            this.retencionNumericUpDown.DecimalPlaces = 2;
            this.retencionNumericUpDown.Location = new System.Drawing.Point(76, 157);
            this.retencionNumericUpDown.Name = "retencionNumericUpDown";
            this.retencionNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.retencionNumericUpDown.TabIndex = 30;
            // 
            // sueldoLabel
            // 
            sueldoLabel.AutoSize = true;
            sueldoLabel.Location = new System.Drawing.Point(7, 125);
            sueldoLabel.Name = "sueldoLabel";
            sueldoLabel.Size = new System.Drawing.Size(41, 13);
            sueldoLabel.TabIndex = 26;
            sueldoLabel.Text = "sueldo:";
            // 
            // sueldoNumericUpDown
            // 
            this.sueldoNumericUpDown.DecimalPlaces = 2;
            this.sueldoNumericUpDown.Location = new System.Drawing.Point(76, 118);
            this.sueldoNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.sueldoNumericUpDown.Name = "sueldoNumericUpDown";
            this.sueldoNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.sueldoNumericUpDown.TabIndex = 27;
            // 
            // vendedorIdLabel
            // 
            vendedorIdLabel.AutoSize = true;
            vendedorIdLabel.Location = new System.Drawing.Point(7, 65);
            vendedorIdLabel.Name = "vendedorIdLabel";
            vendedorIdLabel.Size = new System.Drawing.Size(68, 13);
            vendedorIdLabel.TabIndex = 24;
            vendedorIdLabel.Text = "Vendedor Id:";
            // 
            // vendedorIdNumericUpDown
            // 
            this.vendedorIdNumericUpDown.Location = new System.Drawing.Point(76, 63);
            this.vendedorIdNumericUpDown.Name = "vendedorIdNumericUpDown";
            this.vendedorIdNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.vendedorIdNumericUpDown.TabIndex = 25;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(7, 95);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 22;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(76, 92);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 23;
            // 
            // Buscar_button
            // 
            this.Buscar_button.Location = new System.Drawing.Point(292, 46);
            this.Buscar_button.Name = "Buscar_button";
            this.Buscar_button.Size = new System.Drawing.Size(75, 62);
            this.Buscar_button.TabIndex = 21;
            this.Buscar_button.Text = "Buscar";
            this.Buscar_button.UseVisualStyleBackColor = true;
            this.Buscar_button.Click += new System.EventHandler(this.Buscar_button_Click_1);
            // 
            // Elimiinar_button
            // 
            this.Elimiinar_button.BackColor = System.Drawing.Color.White;
            this.Elimiinar_button.Location = new System.Drawing.Point(292, 254);
            this.Elimiinar_button.Name = "Elimiinar_button";
            this.Elimiinar_button.Size = new System.Drawing.Size(75, 59);
            this.Elimiinar_button.TabIndex = 20;
            this.Elimiinar_button.Text = "Eliminar";
            this.Elimiinar_button.UseVisualStyleBackColor = false;
            this.Elimiinar_button.Click += new System.EventHandler(this.Elimiinar_button_Click_1);
            // 
            // Gualdar_button
            // 
            this.Gualdar_button.BackColor = System.Drawing.Color.White;
            this.Gualdar_button.Location = new System.Drawing.Point(176, 254);
            this.Gualdar_button.Name = "Gualdar_button";
            this.Gualdar_button.Size = new System.Drawing.Size(75, 59);
            this.Gualdar_button.TabIndex = 19;
            this.Gualdar_button.Text = "Guardar";
            this.Gualdar_button.UseVisualStyleBackColor = false;
            this.Gualdar_button.Click += new System.EventHandler(this.Gualdar_button_Click_1);
            // 
            // Nuevo_button
            // 
            this.Nuevo_button.BackColor = System.Drawing.Color.White;
            this.Nuevo_button.Location = new System.Drawing.Point(48, 254);
            this.Nuevo_button.Name = "Nuevo_button";
            this.Nuevo_button.Size = new System.Drawing.Size(75, 59);
            this.Nuevo_button.TabIndex = 18;
            this.Nuevo_button.Text = "nuevo";
            this.Nuevo_button.UseVisualStyleBackColor = false;
            this.Nuevo_button.Click += new System.EventHandler(this.Nuevo_button_Click_1);
            // 
            // SuperErrorProvider
            // 
            this.SuperErrorProvider.ContainerControl = this;
            // 
            // ExamenRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(382, 355);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fecha_dateTimePicker);
            this.Controls.Add(rotacionLabel1);
            this.Controls.Add(this.rotacionNumericUpDown);
            this.Controls.Add(retencionLabel);
            this.Controls.Add(this.retencionNumericUpDown);
            this.Controls.Add(sueldoLabel);
            this.Controls.Add(this.sueldoNumericUpDown);
            this.Controls.Add(vendedorIdLabel);
            this.Controls.Add(this.vendedorIdNumericUpDown);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.Buscar_button);
            this.Controls.Add(this.Elimiinar_button);
            this.Controls.Add(this.Gualdar_button);
            this.Controls.Add(this.Nuevo_button);
            this.Name = "ExamenRegistro";
            this.Text = "ExamenRegistro";
            ((System.ComponentModel.ISupportInitialize)(this.rotacionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retencionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sueldoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Fecha_dateTimePicker;
        private System.Windows.Forms.NumericUpDown rotacionNumericUpDown;
        private System.Windows.Forms.NumericUpDown retencionNumericUpDown;
        private System.Windows.Forms.NumericUpDown sueldoNumericUpDown;
        private System.Windows.Forms.NumericUpDown vendedorIdNumericUpDown;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Button Buscar_button;
        private System.Windows.Forms.Button Elimiinar_button;
        private System.Windows.Forms.Button Gualdar_button;
        private System.Windows.Forms.Button Nuevo_button;
        private System.Windows.Forms.ErrorProvider SuperErrorProvider;
    }
}