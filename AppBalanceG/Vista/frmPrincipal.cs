using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace AppBalanceG.Vista
{
    public partial class frmPrincipal : Form
    {
        //Campos
        private IconButton currentButton;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        int cont = 0;
        //--------------------------------

        //Inicio del Formulario Principal (Proyecto)
        public frmPrincipal()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Buffers
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //-------------------------------------------------------------------------------------------------------

        //Colores RGB usados en los botones
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(24, 161, 251);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
        }
        //-------------------------------------------------------------------------------------------------------

        //Metodo entrelazado y utilizado con los metodos de los 'Botones'. 
        //Mas informacion de las instrucciones usadas dentro del mismo. 
        private void ActiveButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();
                //Boton: Cambios de Colores y Posiciones de las fuentes
                currentButton = (IconButton)senderBtn;
                currentButton.BackColor = Color.FromArgb(37, 36, 81);
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;
                //Cambio de iconos a la izquierda del boton y su color
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentButton.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icono de la interfaz hija correspondiente y su color
                iconCurrentChildForm.IconChar = currentButton.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        //--------------------------------------------------------------------------------------------------------

        //Desactiva cualquier boton seleccionado, color de la fuente y del icono; asi tambien como la restauracion
        //a su posicion original.
        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(31, 30, 68);
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.Gainsboro;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        //--------------------------------------------------------------------------------------------------------

        //Metodo para abrir cualquier interfaz hija dentro de la interfaz padre
        private void OpenChildForm(Form childForm)
        {
            //Validacion para abrir solo una interfaz
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }
        //------------------------------------------------------------------------------------------------------

        //Todos los botones con sus configuraciones (colores, etc) e interfaces propias (hijas). Validaciones
        //para los cambios del tamaño de interfaces dentro de la interfaz padre.
        //********************************************************************************************************
        private void btnAccountRegister_Click(object sender, EventArgs e)
        {
            cont = 1;
            ActiveButton(sender, RGBColors.color5);
            OpenChildForm(new frmRegistroCuenta());
            if (WindowState == FormWindowState.Normal)
            {
                currentChildForm.WindowState = FormWindowState.Normal;
                currentChildForm.Anchor = AnchorStyles.Left;
                currentChildForm.Anchor = AnchorStyles.Top;
            }
        }

        //********************************************************************************************************

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            cont = 1;
            ActiveButton(sender, RGBColors.color4);
            OpenChildForm(new frmTransacciones());
            if (WindowState == FormWindowState.Normal)
            {
                currentChildForm.WindowState = FormWindowState.Normal;
                currentChildForm.Anchor = AnchorStyles.Left;
                currentChildForm.Anchor = AnchorStyles.Top;
            }
        }

        //********************************************************************************************************

        private void btnBalanceSheet_Click(object sender, EventArgs e)
        {
            cont = 1;
            ActiveButton(sender, RGBColors.color3);
            OpenChildForm(new frmBalanceG());
            if (WindowState == FormWindowState.Normal)
            {
                currentChildForm.WindowState = FormWindowState.Normal;
                currentChildForm.Anchor = AnchorStyles.Left;
                currentChildForm.Anchor = AnchorStyles.Top;
            }
        }

        //********************************************************************************************************

        private void btnTaccount_Click(object sender, EventArgs e)
        {
            cont = 1;
            ActiveButton(sender, RGBColors.color2);
            OpenChildForm(new frmCuentasT());
            if (WindowState == FormWindowState.Normal)
            {
                currentChildForm.WindowState = FormWindowState.Normal;
                currentChildForm.Anchor = AnchorStyles.Left;
                currentChildForm.Anchor = AnchorStyles.Top;
            }
        }

        //********************************************************************************************************

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            cont = 1;
            ActiveButton(sender, RGBColors.color1);
            if (WindowState == FormWindowState.Normal)
            {
                currentChildForm.WindowState = FormWindowState.Normal;
                currentChildForm.Anchor = AnchorStyles.Left;
                currentChildForm.Anchor = AnchorStyles.Top;
            }
        }
        //********************************************************************************************************
        //--------------------------------------------------------------------------------------------------------

        //Al presionar el boton home (El Logo al lado izquierdo arriba de la interfaz), desactiva cualquier boton
        //presionado y cierra cualquier interfaz hija, asi tambien coloca los label de hora y fecha en su nuevo
        //lugar dependiendo situaciones...  
        private void btnHome_Click(object sender, EventArgs e)
        {
            cont = 2;
            if (WindowState == FormWindowState.Normal)
            {
                this.lblFecha.Location = new Point(122, 256);
                this.lblHora.Location = new Point(201, 167);
            }
            else if(WindowState == FormWindowState.Maximized)
            {
                this.lblFecha.Location = new Point(225, 306);
                this.lblHora.Location = new Point(304, 215);
            }
            Reset();
            currentChildForm.Close();

        }
        //---------------------------------------------------------------------------------------------------------

        //Metodo para desactivar botones. Cambios en sus colores generales y de sus iconos,
        //asi tambien como el reestablecimiento al icono "Home" arriba. 
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }
        //----------------------------------------------------------------------------------------------

        //Drag Form :)
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //----------------------------------------------------------------------------------------------
        
        //Brinda la Hora actual
        private void FechaHora_Tick_1(object sender, EventArgs e)
        {
            this.lblHora.Text = DateTime.Now.ToLongTimeString();
        }
        //----------------------------------------------------------------------------------------------

        //Metodo de Inicio de Proyecto
        private void Form1_Load(object sender, EventArgs e)
        {
            this.lblFecha.Text = DateTime.Now.Date.ToString("dddd " + "d " + (char)68 + 
                                                            "e " + "MMMM " + (char)68 + "el " + "yyyy");
            this.btnMinimizar.Visible = false;
        }
        //----------------------------------------------------------------------------------------------

        //Metodo para salirse del proyecto.
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Seguro quiere salir del programa?", "Atencion", 
                                              MessageBoxButtons.YesNo);
            if(r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //----------------------------------------------------------------------------------------------

        //Metodos de Cambio de Tamaño y Ocultacion de Interfaz:

        //Maximizar el proyecto
        //**************************************************************************
        private void Max_Click(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                WindowState = FormWindowState.Maximized;
            }
            else 
            {
                if (WindowState == FormWindowState.Normal)
                {
                    WindowState = FormWindowState.Maximized;
                    currentChildForm.WindowState = FormWindowState.Maximized;
                }  
            }
            if(cont == 2)
            {
                this.lblFecha.Location = new Point(225, 306);
                this.lblHora.Location = new Point(304, 215);
            }
            this.Max.Visible = false;
            this.btnMinimizar.Visible = true;
            
                
        }
        //**************************************************************************
        
        //Minimizar en la barra de tareas el proyecto
        private void Mini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //**************************************************************************

        //Minimizar a Tamaño Normal el Proyecto 
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                WindowState = FormWindowState.Normal;
            }
            else 
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    currentChildForm.WindowState = FormWindowState.Normal;
                    currentChildForm.Anchor = AnchorStyles.Left;
                    currentChildForm.Anchor = AnchorStyles.Top;
                    WindowState = FormWindowState.Normal;
                }
                    
            }
            if(cont == 2)
            {
                this.lblFecha.Location = new Point(122, 256);
                this.lblHora.Location = new Point(201, 167);
            }
            this.Max.Visible = true;
            this.btnMinimizar.Visible = false;
        }
        //**************************************************************************
        //-------------------------------------------------------------------------------------------
    }
}