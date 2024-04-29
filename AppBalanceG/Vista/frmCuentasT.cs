using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppBalanceG.Controlador;

namespace AppBalanceG.Vista
{
    public partial class frmCuentasT : Form
    {
        public frmCuentasT()
        {
            InitializeComponent();
        }

        private void cmbTipoCuenta_TextChanged(object sender, EventArgs e)
        {
            if (this.cmbTipoCuenta.Text != "")
            {
                var ConsultaActivos = from Activo in CuentasCmb.ListasCuentasCmb1
                                      where Activo.TipoCuenta.Equals(this.cmbTipoCuenta.Text)
                                      select Activo;

                this.cmbNombreCuenta.Text = null;

                this.cmbNombreCuenta.Items.Clear();

                foreach (var CC in ConsultaActivos)
                {
                    this.cmbNombreCuenta.Items.Add(CC.NombreCuenta);
                }
            }
        }

        public void CuentasCmbF()
        {
            if (CuentasCmb.condi == false)
            {
                CuentasCmb CCA1 = new CuentasCmb("Activo", "Banco");
                CuentasCmb CCA2 = new CuentasCmb("Activo", "Cliente");
                CuentasCmb CCA3 = new CuentasCmb("Activo", "Fondo fijo de caja chica");

                CuentasCmb CCP1 = new CuentasCmb("Pasivo", "Cuentas por pagar");
                CuentasCmb CCP2 = new CuentasCmb("Pasivo", "Impuestos por pagar");
                CuentasCmb CCP3 = new CuentasCmb("Pasivo", "Acreedores");

                CuentasCmb CCC1 = new CuentasCmb("Capital", "Capital Contribuido");
                CuentasCmb CCC2 = new CuentasCmb("Capital", "Capital Social");

                CuentasCmb.GuardarCmb(CCA1);
                CuentasCmb.GuardarCmb(CCA2);
                CuentasCmb.GuardarCmb(CCA3);
                CuentasCmb.GuardarCmb(CCP1);
                CuentasCmb.GuardarCmb(CCP2);
                CuentasCmb.GuardarCmb(CCP3);
                CuentasCmb.GuardarCmb(CCC1);
                CuentasCmb.GuardarCmb(CCC2);

                CuentasCmb.condi = true;

            }

        }

        //Nuevo metodo :D
        public decimal TotalEntrada()
        {
            decimal totalEntradas = 0; decimal valorinicial = 0;
            var consulta = from Entradas in EntradasClase.ListEntradas1
                           where Entradas.NombreCuenta.Equals(this.cmbNombreCuenta.Text)
                           && Entradas.TipoCuenta.Equals(this.cmbTipoCuenta.Text)
                           select Entradas;

            foreach (var Consulta in consulta)
            {
                totalEntradas += Consulta.Entrada;
                valorinicial = Consulta.ValorCuenta;
            }
            if (this.cmbTipoCuenta.Text == "Activo")
            {
                totalEntradas += valorinicial;
            }
            //else
            //{
            //    totalEntradas -= valorinicial;
            //}

            return totalEntradas;

        }

        public decimal TotalSalida()
        {
            decimal totalSalidas = 0, valorinicial = 0;
            var consulta1 = from Salidas in SalidasClase.ListSalidas1
                            where Salidas.NombreCuenta.Equals(this.cmbNombreCuenta.Text)
                            && Salidas.TipoCuenta.Equals(this.cmbTipoCuenta.Text)
                            select Salidas;

            foreach (var Consulta1 in consulta1)
            {
                totalSalidas += Consulta1.Salida;
                valorinicial = Consulta1.ValorCuenta;
            }
            //if (this.cmbTipoCuenta.Text == "Activo")
            //{
            //    totalSalidas += valorinicial;
            //}
            if (this.cmbTipoCuenta.Text  == "Pasivo" || this.cmbTipoCuenta.Text == "Capital")
            {
                totalSalidas += valorinicial;
            }

            return totalSalidas;

        }

        private void frmCuentasT_Load(object sender, EventArgs e)
        {
            CuentasCmbF();
        }

        public void MostrarEntradas() 
        {
            int cont = 0;
            var ConsultaEntradas = from Entradas in EntradasClase.ListEntradas1 
                                   where Entradas.NombreCuenta.Equals(this.cmbNombreCuenta.Text) && Entradas.TipoCuenta.Equals(this.cmbTipoCuenta.Text)
                                   select Entradas;

            foreach(var Consulta in ConsultaEntradas)
            {
                this.DataEntradas.Rows.Insert(cont, Consulta.IdTransaccion, Consulta.Entrada, Consulta.IdCuenta);
                cont++;
            }
        }

        public void MostrarSalidas()
        {
            int cont = 0;
            var ConsultaSalidas = from Salidas in SalidasClase.ListSalidas1
                                  where Salidas.NombreCuenta.Equals(this.cmbNombreCuenta.Text) && Salidas.TipoCuenta.Equals(this.cmbTipoCuenta.Text)
                                  select Salidas;

            foreach(var Consulta in ConsultaSalidas)
            {
                this.DataSalidas.Rows.Insert(cont, Consulta.IdCuenta, Consulta.Salida, Consulta.IdTransaccion);
                cont++;
            }
        }

        private void btnMostar_Click(object sender, EventArgs e)
        {
            decimal tot;
            if (EntradasClase.ListEntradas1.Count != 0)
            {
                LimpiarDataE();
                MostrarEntradas();
                this.txtTotEntradas.Text = Convert.ToString(TotalEntrada());
                
            }
            
            if (SalidasClase.ListSalidas1.Count != 0)
            {
                LimpiarDataS();
                MostrarSalidas();
                this.txtTotSalidas.Text = Convert.ToString(TotalSalida());
            }

            tot = TotalEntrada() - TotalSalida();
            
            if(tot < 0) {
                tot = tot * -1;
                this.txtEstadoFinal.Text = Convert.ToString(tot);
            }
            else
            {
                this.txtEstadoFinal.Text = Convert.ToString(tot);
            }

            


            if (Convert.ToDecimal(this.txtEstadoFinal.Text) < 0)
            {
                this.txtEstadoFinal.ForeColor = Color.Red;
            }
            else
            {
                this.txtEstadoFinal.ForeColor = Color.Blue;
            }

        }

        public void LimpiarDataE()
        {
            this.DataEntradas.Rows.Clear();
        }

        public void LimpiarDataS()
        {
            this.DataSalidas.Rows.Clear();
        }

    }
}
