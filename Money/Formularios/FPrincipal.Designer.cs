namespace Money.Formularios
{
    partial class FPrincipal
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dgvIngreso = new System.Windows.Forms.DataGridView();
            this.dgvRIngresos = new System.Windows.Forms.DataGridView();
            this.dgvRGastos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.txtGasto = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRIngresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRGastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ENERO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JUNIO",
            "JULIO",
            "AGOSTO",
            "SEPTIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE"});
            this.comboBox1.Location = new System.Drawing.Point(6, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(16, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 61);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvRGastos);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(466, 174);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Gastos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtSaldo);
            this.tabPage2.Controls.Add(this.txtGasto);
            this.tabPage2.Controls.Add(this.txtIngreso);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(466, 174);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Saldo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvRIngresos);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(466, 174);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingresos";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(474, 203);
            this.tabControl1.TabIndex = 2;
            // 
            // dgvIngreso
            // 
            this.dgvIngreso.AllowUserToAddRows = false;
            this.dgvIngreso.AllowUserToDeleteRows = false;
            this.dgvIngreso.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngreso.Location = new System.Drawing.Point(12, 334);
            this.dgvIngreso.Name = "dgvIngreso";
            this.dgvIngreso.ReadOnly = true;
            this.dgvIngreso.RowHeadersWidth = 51;
            this.dgvIngreso.RowTemplate.Height = 24;
            this.dgvIngreso.Size = new System.Drawing.Size(466, 334);
            this.dgvIngreso.TabIndex = 7;
            // 
            // dgvRIngresos
            // 
            this.dgvRIngresos.AllowUserToAddRows = false;
            this.dgvRIngresos.AllowUserToDeleteRows = false;
            this.dgvRIngresos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRIngresos.Location = new System.Drawing.Point(6, 6);
            this.dgvRIngresos.Name = "dgvRIngresos";
            this.dgvRIngresos.ReadOnly = true;
            this.dgvRIngresos.RowHeadersWidth = 51;
            this.dgvRIngresos.RowTemplate.Height = 24;
            this.dgvRIngresos.Size = new System.Drawing.Size(454, 162);
            this.dgvRIngresos.TabIndex = 9;
            // 
            // dgvRGastos
            // 
            this.dgvRGastos.AllowUserToAddRows = false;
            this.dgvRGastos.AllowUserToDeleteRows = false;
            this.dgvRGastos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRGastos.Location = new System.Drawing.Point(6, 6);
            this.dgvRGastos.Name = "dgvRGastos";
            this.dgvRGastos.ReadOnly = true;
            this.dgvRGastos.RowHeadersWidth = 51;
            this.dgvRGastos.RowTemplate.Height = 24;
            this.dgvRGastos.Size = new System.Drawing.Size(454, 162);
            this.dgvRGastos.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresos:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 73);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gastos:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 115);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo:";
            // 
            // txtIngreso
            // 
            this.txtIngreso.BackColor = System.Drawing.Color.White;
            this.txtIngreso.Location = new System.Drawing.Point(173, 31);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.ReadOnly = true;
            this.txtIngreso.Size = new System.Drawing.Size(183, 22);
            this.txtIngreso.TabIndex = 3;
            this.txtIngreso.Text = "0";
            this.txtIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIngreso.TextChanged += new System.EventHandler(this.txtIngreso_TextChanged);
            // 
            // txtGasto
            // 
            this.txtGasto.BackColor = System.Drawing.Color.White;
            this.txtGasto.Location = new System.Drawing.Point(172, 66);
            this.txtGasto.Name = "txtGasto";
            this.txtGasto.ReadOnly = true;
            this.txtGasto.Size = new System.Drawing.Size(183, 22);
            this.txtGasto.TabIndex = 4;
            this.txtGasto.Text = "0";
            this.txtGasto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSaldo
            // 
            this.txtSaldo.BackColor = System.Drawing.Color.White;
            this.txtSaldo.Location = new System.Drawing.Point(171, 109);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(183, 22);
            this.txtSaldo.TabIndex = 5;
            this.txtSaldo.Text = "0";
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 22);
            this.textBox1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Money.Properties.Resources.lupa;
            this.pictureBox3.Location = new System.Drawing.Point(226, 243);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 61);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Money.Properties.Resources.senal_de_stop;
            this.pictureBox2.Location = new System.Drawing.Point(403, 234);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Money.Properties.Resources.signo_de_mas;
            this.pictureBox1.Location = new System.Drawing.Point(326, 243);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(492, 680);
            this.Controls.Add(this.dgvIngreso);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Gastos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRIngresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRGastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView dgvIngreso;
        private System.Windows.Forms.DataGridView dgvRIngresos;
        private System.Windows.Forms.DataGridView dgvRGastos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtGasto;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}