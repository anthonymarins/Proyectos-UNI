namespace AppBalanceG.Vista
{
    partial class frmTransacciones
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataEntradas = new DataGridView();
            txtSalidas = new TextBox();
            label2 = new Label();
            rbEntradas = new RadioButton();
            rbSalidas = new RadioButton();
            btnNuevo = new Button();
            btnCancelar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            label1 = new Label();
            DataCuentas = new DataGridView();
            panel1 = new Panel();
            DataSalidas = new DataGridView();
            txtEntradas = new TextBox();
            label3 = new Label();
            txtIDCuenta = new TextBox();
            txtIDTransaccion = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataEntradas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataCuentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataSalidas).BeginInit();
            SuspendLayout();
            // 
            // DataEntradas
            // 
            DataEntradas.AllowUserToOrderColumns = true;
            DataEntradas.AllowUserToResizeRows = false;
            DataEntradas.Anchor = AnchorStyles.None;
            DataEntradas.BackgroundColor = Color.FromArgb(34, 33, 74);
            DataEntradas.BorderStyle = BorderStyle.None;
            DataEntradas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataEntradas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Navy;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataEntradas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataEntradas.ColumnHeadersHeight = 25;
            DataEntradas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DataEntradas.DefaultCellStyle = dataGridViewCellStyle2;
            DataEntradas.EnableHeadersVisualStyles = false;
            DataEntradas.GridColor = Color.SteelBlue;
            DataEntradas.Location = new Point(311, 146);
            DataEntradas.Name = "DataEntradas";
            DataEntradas.ReadOnly = true;
            DataEntradas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(34, 33, 74);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DataEntradas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DataEntradas.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(34, 33, 74);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            DataEntradas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            DataEntradas.RowTemplate.Height = 25;
            DataEntradas.Size = new Size(213, 187);
            DataEntradas.TabIndex = 11;
            DataEntradas.CellClick += DataEntradas_CellClick;
            // 
            // txtSalidas
            // 
            txtSalidas.Anchor = AnchorStyles.None;
            txtSalidas.BackColor = Color.FromArgb(95, 77, 221);
            txtSalidas.BorderStyle = BorderStyle.FixedSingle;
            txtSalidas.ForeColor = Color.White;
            txtSalidas.Location = new Point(589, 106);
            txtSalidas.Name = "txtSalidas";
            txtSalidas.Size = new Size(100, 23);
            txtSalidas.TabIndex = 13;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(95, 77, 221);
            label2.Location = new Point(488, 50);
            label2.Name = "label2";
            label2.Size = new Size(80, 16);
            label2.TabIndex = 14;
            label2.Text = "Seleccione:";
            // 
            // rbEntradas
            // 
            rbEntradas.Anchor = AnchorStyles.None;
            rbEntradas.AutoSize = true;
            rbEntradas.Cursor = Cursors.Hand;
            rbEntradas.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbEntradas.ForeColor = Color.FromArgb(95, 77, 221);
            rbEntradas.Location = new Point(381, 81);
            rbEntradas.Name = "rbEntradas";
            rbEntradas.Size = new Size(82, 20);
            rbEntradas.TabIndex = 15;
            rbEntradas.TabStop = true;
            rbEntradas.Text = "Entradas";
            rbEntradas.UseVisualStyleBackColor = true;
            rbEntradas.CheckedChanged += rbEntradas_CheckedChanged;
            // 
            // rbSalidas
            // 
            rbSalidas.Anchor = AnchorStyles.None;
            rbSalidas.AutoSize = true;
            rbSalidas.Cursor = Cursors.Hand;
            rbSalidas.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbSalidas.ForeColor = Color.FromArgb(95, 77, 221);
            rbSalidas.Location = new Point(603, 81);
            rbSalidas.Name = "rbSalidas";
            rbSalidas.Size = new Size(71, 20);
            rbSalidas.TabIndex = 16;
            rbSalidas.TabStop = true;
            rbSalidas.Text = "Salidas";
            rbSalidas.UseVisualStyleBackColor = true;
            rbSalidas.CheckedChanged += rbSalidas_CheckedChanged;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.None;
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevo.ForeColor = Color.FromArgb(95, 77, 221);
            btnNuevo.Location = new Point(335, 349);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 32);
            btnNuevo.TabIndex = 20;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.FromArgb(95, 77, 221);
            btnCancelar.Location = new Point(649, 349);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 32);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.None;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.ForeColor = Color.FromArgb(95, 77, 221);
            btnEditar.Location = new Point(543, 349);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 32);
            btnEditar.TabIndex = 18;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.FromArgb(95, 77, 221);
            btnGuardar.Location = new Point(439, 349);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 32);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(95, 77, 221);
            label1.Location = new Point(87, 50);
            label1.Name = "label1";
            label1.Size = new Size(136, 16);
            label1.TabIndex = 23;
            label1.Text = "Cuentas Disponibles";
            // 
            // DataCuentas
            // 
            DataCuentas.AllowUserToOrderColumns = true;
            DataCuentas.AllowUserToResizeRows = false;
            DataCuentas.Anchor = AnchorStyles.None;
            DataCuentas.BackgroundColor = Color.FromArgb(34, 33, 74);
            DataCuentas.BorderStyle = BorderStyle.None;
            DataCuentas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataCuentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.Navy;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DataCuentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DataCuentas.ColumnHeadersHeight = 25;
            DataCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DataCuentas.DefaultCellStyle = dataGridViewCellStyle6;
            DataCuentas.EnableHeadersVisualStyles = false;
            DataCuentas.GridColor = Color.SteelBlue;
            DataCuentas.Location = new Point(18, 106);
            DataCuentas.Name = "DataCuentas";
            DataCuentas.ReadOnly = true;
            DataCuentas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(34, 33, 74);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            DataCuentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(34, 33, 74);
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            DataCuentas.RowsDefaultCellStyle = dataGridViewCellStyle8;
            DataCuentas.RowTemplate.Height = 25;
            DataCuentas.SelectionMode = DataGridViewSelectionMode.CellSelect;
            DataCuentas.Size = new Size(282, 279);
            DataCuentas.TabIndex = 22;
            DataCuentas.CellClick += DataCuentas_CellClick;
            DataCuentas.CellContentClick += DataCuentas_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(95, 77, 221);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(12, 443);
            panel1.TabIndex = 24;
            // 
            // DataSalidas
            // 
            DataSalidas.AllowUserToOrderColumns = true;
            DataSalidas.AllowUserToResizeRows = false;
            DataSalidas.Anchor = AnchorStyles.None;
            DataSalidas.BackgroundColor = Color.FromArgb(34, 33, 74);
            DataSalidas.BorderStyle = BorderStyle.None;
            DataSalidas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataSalidas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.Navy;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            DataSalidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            DataSalidas.ColumnHeadersHeight = 25;
            DataSalidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            DataSalidas.DefaultCellStyle = dataGridViewCellStyle10;
            DataSalidas.EnableHeadersVisualStyles = false;
            DataSalidas.GridColor = Color.SteelBlue;
            DataSalidas.Location = new Point(530, 146);
            DataSalidas.Name = "DataSalidas";
            DataSalidas.ReadOnly = true;
            DataSalidas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(34, 33, 74);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            DataSalidas.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            DataSalidas.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(34, 33, 74);
            dataGridViewCellStyle12.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.White;
            dataGridViewCellStyle12.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle12.SelectionForeColor = Color.White;
            DataSalidas.RowsDefaultCellStyle = dataGridViewCellStyle12;
            DataSalidas.RowTemplate.Height = 25;
            DataSalidas.Size = new Size(213, 187);
            DataSalidas.TabIndex = 25;
            DataSalidas.CellClick += DataSalidas_CellClick;
            // 
            // txtEntradas
            // 
            txtEntradas.Anchor = AnchorStyles.None;
            txtEntradas.BackColor = Color.FromArgb(95, 77, 221);
            txtEntradas.BorderStyle = BorderStyle.FixedSingle;
            txtEntradas.ForeColor = Color.White;
            txtEntradas.Location = new Point(372, 106);
            txtEntradas.Name = "txtEntradas";
            txtEntradas.Size = new Size(100, 23);
            txtEntradas.TabIndex = 12;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(95, 77, 221);
            label3.Location = new Point(29, 81);
            label3.Name = "label3";
            label3.Size = new Size(167, 16);
            label3.TabIndex = 26;
            label3.Text = "ID Cuenta Seleccionada:";
            // 
            // txtIDCuenta
            // 
            txtIDCuenta.Anchor = AnchorStyles.None;
            txtIDCuenta.BackColor = Color.FromArgb(95, 77, 221);
            txtIDCuenta.BorderStyle = BorderStyle.FixedSingle;
            txtIDCuenta.ForeColor = Color.White;
            txtIDCuenta.Location = new Point(202, 77);
            txtIDCuenta.Name = "txtIDCuenta";
            txtIDCuenta.Size = new Size(98, 23);
            txtIDCuenta.TabIndex = 27;
            // 
            // txtIDTransaccion
            // 
            txtIDTransaccion.Anchor = AnchorStyles.None;
            txtIDTransaccion.BackColor = Color.FromArgb(95, 77, 221);
            txtIDTransaccion.BorderStyle = BorderStyle.FixedSingle;
            txtIDTransaccion.Enabled = false;
            txtIDTransaccion.ForeColor = Color.White;
            txtIDTransaccion.HideSelection = false;
            txtIDTransaccion.Location = new Point(519, 106);
            txtIDTransaccion.Name = "txtIDTransaccion";
            txtIDTransaccion.Size = new Size(20, 23);
            txtIDTransaccion.TabIndex = 28;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(95, 77, 221);
            label4.Location = new Point(519, 81);
            label4.Name = "label4";
            label4.Size = new Size(20, 16);
            label4.TabIndex = 29;
            label4.Text = "ID";
            // 
            // frmTransacciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(755, 443);
            Controls.Add(label4);
            Controls.Add(txtIDTransaccion);
            Controls.Add(txtIDCuenta);
            Controls.Add(label3);
            Controls.Add(DataSalidas);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(DataCuentas);
            Controls.Add(btnNuevo);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(rbSalidas);
            Controls.Add(rbEntradas);
            Controls.Add(label2);
            Controls.Add(txtSalidas);
            Controls.Add(txtEntradas);
            Controls.Add(DataEntradas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTransacciones";
            Text = "Transacciones";
            Load += frmTransacciones_Load;
            ((System.ComponentModel.ISupportInitialize)DataEntradas).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataCuentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataSalidas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView DataEntradas;
        private TextBox txtSalidas;
        private Label label2;
        private RadioButton rbEntradas;
        private RadioButton rbSalidas;
        private Button btnNuevo;
        private Button btnCancelar;
        private Button btnEditar;
        private Button btnGuardar;
        private Label label1;
        private DataGridView DataCuentas;
        private DataGridViewTextBoxColumn IDCuenta;
        private DataGridViewTextBoxColumn TipoCuenta;
        private DataGridViewTextBoxColumn NombreCuenta;
        private Panel panel1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Entradas;
        private DataGridView DataSalidas;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private TextBox txtEntradas;
        private Label label3;
        private TextBox txtIDCuenta;
        private TextBox txtIDTransaccion;
        private Label label4;
    }
}