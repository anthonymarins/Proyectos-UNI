using AppBalanceG.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBalanceG.Vista
{
    public partial class frmBalanceG : Form
    {
        decimal totalActivo = 0; decimal totalPasivo = 0; decimal totalCapital = 0;
        public frmBalanceG()
        {
            InitializeComponent();
        }

        private void frmBalanceG_Load(object sender, EventArgs e)
        {   
        }

        public decimal TotalCuenta(string nombreCuenta, string tipo)
        {
            decimal total = TotalEntrada(nombreCuenta, tipo) - TotalSalida(nombreCuenta, tipo);

            if (total > 0)
            { 
                return total;
            } 
            else 
            {
                total = total * -1;
                return total;
            }
        }

        public decimal TotalEntrada(string nombreCuenta, string tipo)
        {
            decimal totalEntradas = 0; decimal valorinicial = 0;
            if (EntradasClase.ListEntradas1.Count != 0) 
            {
                var consulta = from Entradas in EntradasClase.ListEntradas1
                               where Entradas.NombreCuenta.Equals(nombreCuenta)
                               && Entradas.TipoCuenta.Equals(tipo)
                               select Entradas;

                foreach (var Consulta in consulta)
                {
                    valorinicial = Consulta.ValorCuenta;
                    totalEntradas += Consulta.Entrada;
                }
            }
            else
            {
                var consulta = from Cuenta in OpCuentas.ListaCuentas1
                               where Cuenta.NombreCuenta.Equals(nombreCuenta)
                               && Cuenta.TipoCuenta.Equals(tipo)
                               select Cuenta;

                foreach (var Consulta in consulta)
                {
                    valorinicial = Consulta.ValorCuenta;
                }
            }

            totalEntradas += valorinicial;

            return totalEntradas;
        }

        public decimal TotalSalida(string nombreCuenta, string tipo)
        {
            decimal totalSalidas = 0;  decimal valorinicial = 0;
            if (SalidasClase.ListSalidas1.Count != 0)
            {
                var consulta1 = from Salidas in SalidasClase.ListSalidas1
                                where Salidas.NombreCuenta.Equals(nombreCuenta)
                                && Salidas.TipoCuenta.Equals(tipo)
                                select Salidas;

                foreach (var Consulta1 in consulta1)
                {
                    totalSalidas += Consulta1.Salida;
                    valorinicial = Consulta1.ValorCuenta;
                }
            }

            totalSalidas += valorinicial;

            return totalSalidas;

        }

        public void MostrarPasivos()
        {
            int cont = 0;

            foreach (OpCuentas EC in OpCuentas.ListaCuentas1)
            {
                if(EC.TipoCuenta == "Pasivo")
                {
                    this.dataBalancePasiC.Rows.Add(EC.IdCuenta, EC.NombreCuenta, TotalCuenta(EC.NombreCuenta, EC.TipoCuenta));
                    totalPasivo += TotalCuenta(EC.NombreCuenta, EC.TipoCuenta);
                }
                if(EC.TipoCuenta == "Capital") 
                {
                    this.dataBalancePasiC.Rows.Add(EC.IdCuenta, EC.NombreCuenta, TotalCuenta(EC.NombreCuenta, EC.TipoCuenta));
                    totalCapital += TotalCuenta(EC.NombreCuenta, EC.TipoCuenta);
                }
                cont++;
            }
        }
        //-------------------------------------------------------------------------------
        public void MostrarActivos()
        {
            int cont = 0;

            foreach (OpCuentas EC in OpCuentas.ListaCuentas1)
            {
                if (EC.TipoCuenta == "Activo")
                {
                    this.dataBalanceActivos.Rows.Add( EC.IdCuenta, EC.NombreCuenta, TotalCuenta(EC.NombreCuenta, EC.TipoCuenta));
                    totalActivo += TotalCuenta(EC.NombreCuenta, EC.TipoCuenta);
                }
                cont++;
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (OpCuentas.ListaCuentas1.Count != 0)
            {
                Limpiar();
                MostrarActivos();
                MostrarPasivos();
                this.txtActivo.Text = Convert.ToString(totalActivo);
                this.txtPasivo.Text = Convert.ToString(totalPasivo);
                this.txtCapital.Text = Convert.ToString(totalCapital);
            }
            else
            {
                MessageBox.Show(" No hay datos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void Limpiar()
        {
            this.dataBalanceActivos.Rows.Clear();
            this.dataBalancePasiC.Rows.Clear();
        }
    }
}
