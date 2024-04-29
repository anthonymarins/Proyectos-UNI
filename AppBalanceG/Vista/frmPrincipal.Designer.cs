namespace AppBalanceG.Vista
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnStatistics = new FontAwesome.Sharp.IconButton();
            this.btnTaccount = new FontAwesome.Sharp.IconButton();
            this.btnBalanceSheet = new FontAwesome.Sharp.IconButton();
            this.btnTransaction = new FontAwesome.Sharp.IconButton();
            this.btnAccountRegister = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.Mini = new System.Windows.Forms.PictureBox();
            this.Max = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.FechaHora = new System.Windows.Forms.Timer(this.components);
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnStatistics);
            this.panelMenu.Controls.Add(this.btnTaccount);
            this.panelMenu.Controls.Add(this.btnBalanceSheet);
            this.panelMenu.Controls.Add(this.btnTransaction);
            this.panelMenu.Controls.Add(this.btnAccountRegister);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 554);
            this.panelMenu.TabIndex = 0;
            // 
            // btnStatistics
            // 
            this.btnStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStatistics.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.btnStatistics.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnStatistics.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStatistics.IconSize = 30;
            this.btnStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistics.Location = new System.Drawing.Point(0, 380);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnStatistics.Size = new System.Drawing.Size(220, 60);
            this.btnStatistics.TabIndex = 5;
            this.btnStatistics.Text = "Estadisticas";
            this.btnStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnTaccount
            // 
            this.btnTaccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaccount.FlatAppearance.BorderSize = 0;
            this.btnTaccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaccount.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTaccount.IconChar = FontAwesome.Sharp.IconChar.Tenge;
            this.btnTaccount.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnTaccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTaccount.IconSize = 30;
            this.btnTaccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaccount.Location = new System.Drawing.Point(0, 320);
            this.btnTaccount.Name = "btnTaccount";
            this.btnTaccount.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTaccount.Size = new System.Drawing.Size(220, 60);
            this.btnTaccount.TabIndex = 4;
            this.btnTaccount.Text = "Cuentas T";
            this.btnTaccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaccount.UseVisualStyleBackColor = true;
            this.btnTaccount.Click += new System.EventHandler(this.btnTaccount_Click);
            // 
            // btnBalanceSheet
            // 
            this.btnBalanceSheet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBalanceSheet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBalanceSheet.FlatAppearance.BorderSize = 0;
            this.btnBalanceSheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBalanceSheet.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBalanceSheet.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.btnBalanceSheet.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnBalanceSheet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBalanceSheet.IconSize = 30;
            this.btnBalanceSheet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBalanceSheet.Location = new System.Drawing.Point(0, 260);
            this.btnBalanceSheet.Name = "btnBalanceSheet";
            this.btnBalanceSheet.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnBalanceSheet.Size = new System.Drawing.Size(220, 60);
            this.btnBalanceSheet.TabIndex = 3;
            this.btnBalanceSheet.Text = "Balance General";
            this.btnBalanceSheet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBalanceSheet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBalanceSheet.UseVisualStyleBackColor = true;
            this.btnBalanceSheet.Click += new System.EventHandler(this.btnBalanceSheet_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransaction.FlatAppearance.BorderSize = 0;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTransaction.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
            this.btnTransaction.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnTransaction.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTransaction.IconSize = 30;
            this.btnTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaction.Location = new System.Drawing.Point(0, 200);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTransaction.Size = new System.Drawing.Size(220, 60);
            this.btnTransaction.TabIndex = 2;
            this.btnTransaction.Text = "Transacciones";
            this.btnTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnAccountRegister
            // 
            this.btnAccountRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccountRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccountRegister.FlatAppearance.BorderSize = 0;
            this.btnAccountRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountRegister.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAccountRegister.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.btnAccountRegister.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnAccountRegister.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccountRegister.IconSize = 30;
            this.btnAccountRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountRegister.Location = new System.Drawing.Point(0, 140);
            this.btnAccountRegister.Name = "btnAccountRegister";
            this.btnAccountRegister.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAccountRegister.Size = new System.Drawing.Size(220, 60);
            this.btnAccountRegister.TabIndex = 1;
            this.btnAccountRegister.Text = "Registro de Cuentas";
            this.btnAccountRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccountRegister.UseVisualStyleBackColor = true;
            this.btnAccountRegister.Click += new System.EventHandler(this.btnAccountRegister_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(213, 135);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.btnMinimizar);
            this.panelTitleBar.Controls.Add(this.Mini);
            this.panelTitleBar.Controls.Add(this.Max);
            this.panelTitleBar.Controls.Add(this.pictureBox1);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(771, 60);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(683, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(36, 35);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 6;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // Mini
            // 
            this.Mini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Mini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mini.Image = ((System.Drawing.Image)(resources.GetObject("Mini.Image")));
            this.Mini.Location = new System.Drawing.Point(641, 13);
            this.Mini.Name = "Mini";
            this.Mini.Size = new System.Drawing.Size(36, 35);
            this.Mini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Mini.TabIndex = 5;
            this.Mini.TabStop = false;
            this.Mini.Click += new System.EventHandler(this.Mini_Click);
            // 
            // Max
            // 
            this.Max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Max.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Max.Image = ((System.Drawing.Image)(resources.GetObject("Max.Image")));
            this.Max.Location = new System.Drawing.Point(683, 13);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(36, 35);
            this.Max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Max.TabIndex = 4;
            this.Max.TabStop = false;
            this.Max.Click += new System.EventHandler(this.Max_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(725, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(50, 20);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(40, 15);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(16, 12);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 60);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(771, 12);
            this.panelShadow.TabIndex = 2;
            // 
            // FechaHora
            // 
            this.FechaHora.Enabled = true;
            this.FechaHora.Interval = 1000;
            this.FechaHora.Tick += new System.EventHandler(this.FechaHora_Tick_1);
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoSize = true;
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.lblFecha);
            this.panelDesktop.Controls.Add(this.lblHora);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 72);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(771, 482);
            this.panelDesktop.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Ravie", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.lblFecha.Location = new System.Drawing.Point(122, 256);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(136, 27);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "00/00/00";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Ravie", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.lblHora.Location = new System.Drawing.Point(201, 167);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(366, 71);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "00; 00; 00";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 554);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnTaccount;
        private FontAwesome.Sharp.IconButton btnBalanceSheet;
        private FontAwesome.Sharp.IconButton btnTransaction;
        private FontAwesome.Sharp.IconButton btnAccountRegister;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnStatistics;
        private PictureBox btnHome;
        private Panel panelTitleBar;
        private Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Panel panelShadow;
        private System.Windows.Forms.Timer FechaHora;
        private Panel panelDesktop;
        private Label lblHora;
        private Label lblFecha;
        private PictureBox Max;
        private PictureBox pictureBox1;
        private PictureBox Mini;
        private PictureBox btnMinimizar;
    }
}