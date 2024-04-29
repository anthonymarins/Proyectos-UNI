namespace AppBalanceG.Vista
{
    partial class frmCuentasT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnMostar = new System.Windows.Forms.Button();
            this.cmbNombreCuenta = new System.Windows.Forms.ComboBox();
            this.DataEntradas = new System.Windows.Forms.DataGridView();
            this.IDEntradas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entradas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataSalidas = new System.Windows.Forms.DataGridView();
            this.IDCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbTipoCuenta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotEntradas = new System.Windows.Forms.TextBox();
            this.txtTotSalidas = new System.Windows.Forms.TextBox();
            this.txtEstadoFinal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSalidas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostar
            // 
            this.btnMostar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMostar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMostar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.btnMostar.Location = new System.Drawing.Point(603, 50);
            this.btnMostar.Name = "btnMostar";
            this.btnMostar.Size = new System.Drawing.Size(80, 32);
            this.btnMostar.TabIndex = 0;
            this.btnMostar.Text = "Mostrar";
            this.btnMostar.UseVisualStyleBackColor = true;
            this.btnMostar.Click += new System.EventHandler(this.btnMostar_Click);
            // 
            // cmbNombreCuenta
            // 
            this.cmbNombreCuenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbNombreCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.cmbNombreCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNombreCuenta.ForeColor = System.Drawing.Color.White;
            this.cmbNombreCuenta.FormattingEnabled = true;
            this.cmbNombreCuenta.Location = new System.Drawing.Point(410, 50);
            this.cmbNombreCuenta.Name = "cmbNombreCuenta";
            this.cmbNombreCuenta.Size = new System.Drawing.Size(168, 23);
            this.cmbNombreCuenta.TabIndex = 1;
            // 
            // DataEntradas
            // 
            this.DataEntradas.AllowUserToOrderColumns = true;
            this.DataEntradas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataEntradas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.DataEntradas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataEntradas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataEntradas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataEntradas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataEntradas.ColumnHeadersHeight = 25;
            this.DataEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataEntradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDEntradas,
            this.Entradas,
            this.dataGridViewTextBoxColumn1});
            this.DataEntradas.EnableHeadersVisualStyles = false;
            this.DataEntradas.GridColor = System.Drawing.Color.SteelBlue;
            this.DataEntradas.Location = new System.Drawing.Point(86, 92);
            this.DataEntradas.Name = "DataEntradas";
            this.DataEntradas.ReadOnly = true;
            this.DataEntradas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataEntradas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataEntradas.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DataEntradas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataEntradas.RowTemplate.Height = 25;
            this.DataEntradas.Size = new System.Drawing.Size(301, 200);
            this.DataEntradas.TabIndex = 12;
            // 
            // IDEntradas
            // 
            this.IDEntradas.HeaderText = "ID Entradas";
            this.IDEntradas.Name = "IDEntradas";
            this.IDEntradas.ReadOnly = true;
            // 
            // Entradas
            // 
            this.Entradas.HeaderText = "Entradas";
            this.Entradas.Name = "Entradas";
            this.Entradas.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Cuenta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(234, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tipo de Cuenta";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(12, 443);
            this.panel1.TabIndex = 14;
            // 
            // DataSalidas
            // 
            this.DataSalidas.AllowUserToOrderColumns = true;
            this.DataSalidas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataSalidas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.DataSalidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataSalidas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataSalidas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataSalidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataSalidas.ColumnHeadersHeight = 25;
            this.DataSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataSalidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCuenta,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.DataSalidas.EnableHeadersVisualStyles = false;
            this.DataSalidas.GridColor = System.Drawing.Color.SteelBlue;
            this.DataSalidas.Location = new System.Drawing.Point(393, 92);
            this.DataSalidas.Name = "DataSalidas";
            this.DataSalidas.ReadOnly = true;
            this.DataSalidas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataSalidas.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataSalidas.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.DataSalidas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DataSalidas.RowTemplate.Height = 25;
            this.DataSalidas.Size = new System.Drawing.Size(303, 200);
            this.DataSalidas.TabIndex = 15;
            // 
            // IDCuenta
            // 
            this.IDCuenta.HeaderText = "ID Cuenta";
            this.IDCuenta.Name = "IDCuenta";
            this.IDCuenta.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Salidas";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "ID Salidas";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // cmbTipoCuenta
            // 
            this.cmbTipoCuenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTipoCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.cmbTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoCuenta.ForeColor = System.Drawing.Color.White;
            this.cmbTipoCuenta.FormattingEnabled = true;
            this.cmbTipoCuenta.Items.AddRange(new object[] {
            "Activo",
            "Pasivo",
            "Capital"});
            this.cmbTipoCuenta.Location = new System.Drawing.Point(203, 50);
            this.cmbTipoCuenta.Name = "cmbTipoCuenta";
            this.cmbTipoCuenta.Size = new System.Drawing.Size(168, 23);
            this.cmbTipoCuenta.TabIndex = 16;
            this.cmbTipoCuenta.TextChanged += new System.EventHandler(this.cmbTipoCuenta_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(419, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre de la Cuenta";
            // 
            // txtTotEntradas
            // 
            this.txtTotEntradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.txtTotEntradas.Enabled = false;
            this.txtTotEntradas.ForeColor = System.Drawing.Color.White;
            this.txtTotEntradas.Location = new System.Drawing.Point(186, 298);
            this.txtTotEntradas.Name = "txtTotEntradas";
            this.txtTotEntradas.Size = new System.Drawing.Size(100, 23);
            this.txtTotEntradas.TabIndex = 18;
            // 
            // txtTotSalidas
            // 
            this.txtTotSalidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.txtTotSalidas.Enabled = false;
            this.txtTotSalidas.ForeColor = System.Drawing.Color.White;
            this.txtTotSalidas.Location = new System.Drawing.Point(478, 298);
            this.txtTotSalidas.Name = "txtTotSalidas";
            this.txtTotSalidas.Size = new System.Drawing.Size(100, 23);
            this.txtTotSalidas.TabIndex = 19;
            // 
            // txtEstadoFinal
            // 
            this.txtEstadoFinal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtEstadoFinal.Enabled = false;
            this.txtEstadoFinal.ForeColor = System.Drawing.Color.White;
            this.txtEstadoFinal.Location = new System.Drawing.Point(332, 341);
            this.txtEstadoFinal.Name = "txtEstadoFinal";
            this.txtEstadoFinal.Size = new System.Drawing.Size(100, 23);
            this.txtEstadoFinal.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(304, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Estado Final de Cuenta";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.label4.Location = new System.Drawing.Point(182, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Total de Entradas";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.label5.Location = new System.Drawing.Point(478, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Total de Salidas";
            // 
            // frmCuentasT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(755, 443);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEstadoFinal);
            this.Controls.Add(this.txtTotSalidas);
            this.Controls.Add(this.txtTotEntradas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTipoCuenta);
            this.Controls.Add(this.DataSalidas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataEntradas);
            this.Controls.Add(this.cmbNombreCuenta);
            this.Controls.Add(this.btnMostar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCuentasT";
            this.Text = "Cuentas T";
            this.Load += new System.EventHandler(this.frmCuentasT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSalidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnMostar;
        private ComboBox cmbNombreCuenta;
        private DataGridView DataEntradas;
        private Label label1;
        private Panel panel1;
        private DataGridView DataSalidas;
        private ComboBox cmbTipoCuenta;
        private Label label2;
        private DataGridViewTextBoxColumn IDEntradas;
        private DataGridViewTextBoxColumn Entradas;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn IDCuenta;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private TextBox txtTotEntradas;
        private TextBox txtTotSalidas;
        private TextBox txtEstadoFinal;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}