using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApiBalance.Modelo.Dto;
using AppBalanceG.Controlador;
using AppBalanceG.Modelo;
using Newtonsoft.Json;

namespace AppBalanceG.Vista
{
    public partial class frmRegistroCuenta : Form
    {
        int cont;
        int c;
        public frmRegistroCuenta()
        {
            InitializeComponent();
        }

        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //if (ComprobarCampos() == false && ComprobarDatos() == true)
            //{
            //    //if (OpCuentas.ListaCuentas1.Count > 0)
            //    //{
            //    //    MessageBox.Show("Duplicación de Datos no permitida ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    //    ControlBtn("Cancelar");             
            //    //}
                
            //}
            if (ComprobarCampos() == false && ComprobarDatos() == false)
            {
                if (0 > Convert.ToInt32(this.txtValorCuenta.Text))
                {
                    MessageBox.Show("No estan permitidos valores negativos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    AgragarCuentas();
                    MostrarTabla();
                    
                }
            }
            ControlBtn("Cancelar");
            Limpiar();
            MostrarTabla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            if (ComprobarCampos() == false && ComprobarDatos() == false)
            {
                EditarCuenta();
            }

            ControlBtn("Editar");
            Limpiar();
            MostrarTabla();
        }

        public async void EditarCuenta()
        {
            //DataGridViewRow data = this.DataCuentas.Rows[e.RowIndex];
            CuentasDtoUpdate update = new CuentasDtoUpdate();
            update.IdCuenta = c;
            update.tipoCuenta = this.cmbTipoCuenta.Text;
            update.NombreCuenta = this.cmbNombreCuenta.Text;
            update.SaldoCuentas = Convert.ToDecimal(this.txtValorCuenta.Text);
            using (var client = new HttpClient())
            {
                var Cuenta = JsonConvert.SerializeObject(update);
                var content = new StringContent(Cuenta, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(String.Format("{0}/{1}",
                    "https://localhost:7245/api/CuentasIControlador", update.IdCuenta), content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("cuenta actualizado");
                else
                    MessageBox.Show($"Error al actualizar la cuenta: {response.StatusCode}");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (this.cmbTipoCuenta.Text == null && this.cmbNombreCuenta.Text == null && this.txtValorCuenta.Text == null)
            {
                MessageBox.Show("Completar los campos vacios", "", MessageBoxButtons.OK);
            }
            ControlBtn("Nuevo");
            Limpiar();
            MostrarTabla();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ControlBtn("Cancelar");
            Limpiar();
            MostrarTabla();
        }

        private void DataCuentas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.cmbNombreCuenta.Enabled = true;
            //this.cmbTipoCuenta.Enabled = true;
            //this.txtValorCuenta.Enabled = true;

            //this.btnCancelar.Enabled = true;
            //this.btnNuevo.Enabled = false;
            //this.btnEditar.Enabled = true;
            //this.btnGuardar.Enabled = false;

            //this.cmbTipoCuenta.Text = this.DataCuentas.CurrentRow.Cells[1].Value.ToString();
            //this.cmbNombreCuenta.Text = this.DataCuentas.CurrentRow.Cells[2].Value.ToString();
            //this.txtValorCuenta.Text = this.DataCuentas.CurrentRow.Cells[3].Value.ToString();
        }

        public async void MostrarTabla()
        {
            //foreach (OpCuentas OpC in OpCuentas.ListaCuentas1)
            //{
            //    int cont = 0;
            //    this.DataCuentas.Rows.Insert(cont, OpC.IdCuenta, OpC.TipoCuenta, OpC.NombreCuenta, OpC.ValorCuenta);
            //    cont++;
            //}

            Thread.Sleep(500);

               using (var client = new HttpClient())
                {
                    using (var response = await client.GetAsync("https://localhost:7245/api/CuentasIControlador"))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var cuentas = await response.Content.ReadAsStringAsync();
                            var result = JsonConvert.DeserializeObject<List<CuentasDto>>(cuentas);
                            DataCuentas.DataSource = result.ToList();
                        }
                        else
                        {
                            MessageBox.Show($"No se puede obtener la lista de cuenta: {response.StatusCode}");
                        }
                    }
                }
            

        }

        public void ControlBtn(string Dato) {

            if (Dato == "Cancelar")
            {
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
                this.btnEditar.Enabled = false;

                this.cmbNombreCuenta.Enabled = false;
                this.cmbTipoCuenta.Enabled = false;
                this.txtValorCuenta.Enabled = false;
            }

            if (Dato == "Nuevo") {
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;

                this.cmbNombreCuenta.Enabled = true;
                this.cmbTipoCuenta.Enabled = true;
                this.txtValorCuenta.Enabled = true;
            }

            if (Dato == "Guardar") {
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = false;
                this.btnNuevo.Enabled = true;

                this.cmbNombreCuenta.Enabled = false;
                this.cmbTipoCuenta.Enabled = false;
                this.txtValorCuenta.Enabled = false;
            }

            if (Dato == "Editar") {
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
                this.btnEditar.Enabled = false;

                this.cmbNombreCuenta.Enabled = false;
                this.cmbTipoCuenta.Enabled = false;
                this.txtValorCuenta.Enabled = false;
            }
        }

        public void Limpiar()
        {
            //this.DataCuentas.Rows.Clear();
            MostrarTabla();

            this.cmbTipoCuenta.Text = null;
            this.cmbNombreCuenta.Text = null;
            this.txtValorCuenta.Text = null;
        }

        public bool ComprobarCampos()
        {
            bool Condi = false;
            if (this.cmbTipoCuenta.SelectedIndex.Equals(-1) || this.cmbNombreCuenta.SelectedIndex.Equals(-1) || this.txtValorCuenta.Text.Equals(""))
            {
                MessageBox.Show("Completar los campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Condi = true;
            }
            return Condi;
        }

        //Este metodo es para evitar que el usuario inicialice la misma cuenta que ya inicio

        public bool ComprobarDatos()
        {
            bool Condi = false;
            if (OpCuentas.ListaCuentas1.Count != 0)
            {
                //Codigo = Convert.ToInt32(this.DataCuentas.CurrentRow.Cells[0].Value);

                foreach (OpCuentas OpC in OpCuentas.ListaCuentas1)
                {
                    if (this.cmbNombreCuenta.Text == OpC.NombreCuenta)
                    {
                        Condi = true;
                    }
                }
            }
            return Condi;
        }
        //Este metodo es para comprobar si hay cambio en el monto de una cuenta ya iniciada.
        public bool ComprobarCM()
        {
            //int Codigo;
            bool Condi = false;
            if (OpCuentas.ListaCuentas1.Count != 0)
            {
                //Codigo = Convert.ToInt32(this.DataCuentas.CurrentRow.Cells[0].Value);

                foreach (OpCuentas OpC in OpCuentas.ListaCuentas1)
                {
                    if (Convert.ToDecimal(this.txtValorCuenta.Text) == OpC.ValorCuenta)
                    {
                        Condi = true;
                    }
                }
            }
            return Condi;
        }

        public async void AgragarCuentas()
        {

            //OpCuentas OpC = new OpCuentas(OpCuentas.ListaCuentas1.Count, this.cmbTipoCuenta.Text, this.cmbNombreCuenta.Text, Convert.ToDecimal(this.txtValorCuenta.Text));
            //OpCuentas.ListaCuentas1.Add(OpC);

            CuentasDtoCreate cuentas = new CuentasDtoCreate();
            cuentas.NombreCuenta = this.cmbNombreCuenta.Text;
            cuentas.tipoCuenta = this.cmbTipoCuenta.Text;
            cuentas.SaldoCuentas = Convert.ToDecimal(this.txtValorCuenta.Text);
            
            using (var client = new HttpClient())
            {
                var Cuenta = JsonConvert.SerializeObject(cuentas);
                var content = new StringContent(Cuenta, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7245/api/CuentasIControlador", content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Cuenta agregado");
                else
                    MessageBox.Show($"Error al guardar la cuenta {response.Content.ReadAsStringAsync().Result}");
            }

            ControlBtn("Guardar");
            
        }

        private void frmRegistroCuenta_Load(object sender, EventArgs e)
        {
            ControlBtn("Cancelar");
            MostrarTabla();
            CuentasCmbF();
        }

        public async void CuentasCmbF()
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

        private void cmbTipoCuenta_TextChanged(object sender, EventArgs e)
        {
            if (this.cmbTipoCuenta.Text != "")
            {
                var ConsultaActivos = from Activo in CuentasCmb.ListasCuentasCmb1
                                      where Activo.TipoCuenta.Equals(this.cmbTipoCuenta.Text)
                                      select Activo;

                this.cmbNombreCuenta.Text = null;
                this.txtValorCuenta.Text = null;

                this.cmbNombreCuenta.Items.Clear();

                foreach (var CC in ConsultaActivos)
                {
                    this.cmbNombreCuenta.Items.Add(CC.NombreCuenta);
                }
            }
        }

        private void DataCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.cmbNombreCuenta.Enabled = true;
            this.cmbTipoCuenta.Enabled = true;
            this.txtValorCuenta.Enabled = true;

            this.btnCancelar.Enabled = true;
            this.btnNuevo.Enabled = false;
            this.btnEditar.Enabled = true;
            this.btnGuardar.Enabled = false;
            //---------------------------------------------------------------
            c = Convert.ToInt32(this.DataCuentas.CurrentRow.Cells[0].Value);
            //---------------------------------------------------------------
            this.cmbTipoCuenta.Text = this.DataCuentas.CurrentRow.Cells[1].Value.ToString();
            this.cmbNombreCuenta.Text = this.DataCuentas.CurrentRow.Cells[2].Value.ToString();
            this.txtValorCuenta.Text = this.DataCuentas.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
