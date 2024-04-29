using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApiBalance.Modelo.Dto;
using AppBalanceG.Controlador;
using Newtonsoft.Json;

namespace AppBalanceG.Vista
{
    public partial class frmTransacciones : Form
    {
        int c;
        int S;
        int E;
        public frmTransacciones()
        {
            InitializeComponent();
        }

        //Metodo para editar con un click los datos del datagridview
        private void DataCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            c = Convert.ToInt32(this.DataCuentas.CurrentRow.Cells[0].Value);
            this.txtIDCuenta.Text = Convert.ToString(c);
            MostrarEntradas();
            MostrarSalidas();
        }

        private void DataCuentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnNuevo.Enabled = true;
            c = Convert.ToInt32(this.DataCuentas.CurrentRow.Cells[0].Value);
            this.txtIDCuenta.Text = Convert.ToString(c);
            MostrarEntradas();
            MostrarSalidas();

            var consulta = from Entradas in EntradasClase.ListEntradas1
                           where Entradas.IdCuenta == c
                           select Entradas;
            int cont = 0;
            LimpiarEntradas();
            foreach (var Consulta in consulta)
            {

                this.DataEntradas.Rows.Insert(cont, Consulta.IdTransaccion, Consulta.Entrada);

            }

            var consulta1 = from Salidas in SalidasClase.ListSalidas1
                            where Salidas.IdCuenta == c
                            select Salidas;
            int cont1 = 0;
            LimpiarSalidas();
            foreach (var Consulta1 in consulta1)
            {

                this.DataSalidas.Rows.Insert(cont, Consulta1.Salida, Consulta1.IdTransaccion);

            }

        }

        //Instrucciones al iniciar la interfaz "Transacciones"
        private void frmTransacciones_Load(object sender, EventArgs e)
        {

            ControlBtn("Cancelar");
            this.btnNuevo.Enabled = false;
            TablaCuentas();
            //MostrarEntradas();
            //MostrarSalidas();
        }
        //-------------------------------------------------------------

        //Metodos de los botones de la interfaz "Transacciones"
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarSalidas();
            LimpiarEntradas();
            MostrarEntradas();
            MostrarSalidas();
            ControlBtn("Nuevo");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.rbEntradas.Checked == true && this.rbSalidas.Checked == false && this.txtEntradas.Text != "")
            {
                GuardarEntradas();
                LimpiarEntradas();
                MostrarEntradas();
            }
            else
            {
                if (this.rbEntradas.Checked == true)
                {
                    MessageBox.Show("Campo de Entradas vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (this.rbSalidas.Checked == true && this.rbEntradas.Checked == false && this.txtSalidas.Text != "")
            {
                GuardarSalidas();
                LimpiarEntradas();
                MostrarSalidas();
            }
            else
            {
                if (this.rbSalidas.Checked == true)
                {
                    MessageBox.Show("Campo de Salidas vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            ControlBtn("Guardar");
            MostrarEntradas();
            MostrarSalidas();


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.rbEntradas.Checked == true && this.rbSalidas.Checked == false && this.txtEntradas.Text != "")
            {
                EditarEntradas();
                LimpiarEntradas();
                MostrarEntradas();
                MostrarSalidas();
            }
            else
            {
                if (this.rbEntradas.Checked == true)
                {
                    MessageBox.Show("Campo de Entradas vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (this.rbSalidas.Checked == true && this.rbEntradas.Checked == false && this.txtSalidas.Text != "")
            {
                EditarSalidas();
                MostrarSalidas();
                MostrarEntradas();
            }
            else
            {
                if (this.rbSalidas.Checked == true)
                {
                    MessageBox.Show("Campo de Salidas vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            ControlBtn("Editar");
        }

        private async void EditarSalidas()
        {
            SalidasDtoUpdate update = new SalidasDtoUpdate();
            update.IdCuenta = E;
            update.salidas = Convert.ToDecimal(this.txtSalidas.Text);
            update.IdTransaccion = Convert.ToInt32(this.txtIDTransaccion.Text);
            using (var client = new HttpClient())
            {
                var salidas = JsonConvert.SerializeObject(update);
                var content = new StringContent(salidas, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(String.Format("{0}/{1}",
                    "https://localhost:7245/api/Entradas", update.IdCuenta), content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Salidas actualizada");
                else
                    MessageBox.Show($"Error al actualizar Salidas: {response.StatusCode}");
            }
        }

        private async void EditarEntradas()
        {
            EntradasDtoUpdate update = new EntradasDtoUpdate();
            update.IdCuenta = E;
            update.entradas = Convert.ToDecimal(this.txtEntradas.Text);
            update.IdTransaccion = Convert.ToInt32(this.txtIDTransaccion.Text);
            using (var client = new HttpClient())
            {
                var entradas = JsonConvert.SerializeObject(update);
                var content = new StringContent(entradas, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(String.Format("{0}/{1}",
                    "https://localhost:7245/api/Entradas", update.IdCuenta), content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Entradas actualizada");
                else
                    MessageBox.Show($"Error al actualizar la entrada: {response.StatusCode}");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarEntradas();
            MostrarSalidas();
            MostrarEntradas();
            ControlBtn("Cancelar");
        }
        //--------------------------------------------------------------

        //Metodos para controlar los botones
        public void ControlBtn(string Dato)
        {

            if (Dato == "Cancelar")
            {
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
                this.btnEditar.Enabled = false;

                this.txtEntradas.Enabled = false;
                this.txtSalidas.Enabled = false;

                this.txtIDCuenta.Enabled = false;
                this.rbEntradas.Enabled = false;
                this.rbSalidas.Enabled = false;
            }

            if (Dato == "Nuevo")
            {
                this.rbEntradas.Checked = true;
                this.rbSalidas.Checked = false;

                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;

                this.rbEntradas.Enabled = true;
                this.rbSalidas.Enabled = true;

                if (this.rbEntradas.Checked == true && this.rbSalidas.Checked == false)
                {
                    this.txtEntradas.Enabled = true;
                    this.txtSalidas.Enabled = false;
                }
                else
                {
                    this.txtEntradas.Enabled = false;
                    this.txtSalidas.Enabled = true;
                }
            }

            if (Dato == "Guardar")
            {
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = false;
                this.btnNuevo.Enabled = true;

                this.txtEntradas.Enabled = false;
                this.txtSalidas.Enabled = false;

                this.rbEntradas.Enabled = false;
                this.rbSalidas.Enabled = false;
            }

            if (Dato == "Editar")
            {
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
                this.btnEditar.Enabled = false;

                this.txtEntradas.Enabled = false;
                this.txtSalidas.Enabled = false;

                this.rbEntradas.Enabled = false;
                this.rbSalidas.Enabled = false;
            }
        }
        //--------------------------------------------------------------------

        //Metodo para limpiar los textboxs y datagridview
        public void LimpiarEntradas()
        {

            if (this.rbEntradas.Checked == true) { this.txtEntradas.Text = null; }
            if (this.rbSalidas.Checked == true) { this.txtSalidas.Text = null; }
        }
        //--------------------------------------------------------------------
        public void LimpiarSalidas()
        {

            if (this.rbEntradas.Checked == true) { this.txtEntradas.Text = null; }
            if (this.rbSalidas.Checked == true) { this.txtSalidas.Text = null; }
        }
        //--------------------------------------------------------------------
        ////Mostrador de datagridview
        public async void TablaCuentas()
        {
            //int cont = 0;
            //foreach (OpCuentas OpC in OpCuentas.ListaCuentas1)
            //{
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
                        MessageBox.Show($"No se puede obtener la lista de cuentas: {response.StatusCode}");
                    }
                }
            }
        }
        ////---------------------------------------------------------------------
        //public void TablaEntradasSalidas()
        //{
        //    int cont = 0;
        //    foreach (OpTransacciones OT in OpTransacciones.ListopTransacciones1)
        //    {
        //        this.DataTransacciones.Rows.Insert(cont, OT.IdTransaccion, OT.Entradas, OT.Salidas);
        //        cont++;
        //    }
        //}

        ////---------------------------------------------------------------------
        public async void GuardarEntradas()
        {
            //EntradasClase e = new EntradasClase(OpCuentas.ListaCuentas1[c].IdCuenta,
            //                                     OpCuentas.ListaCuentas1[c].TipoCuenta,
            //                                     OpCuentas.ListaCuentas1[c].NombreCuenta,
            //                                     OpCuentas.ListaCuentas1[c].ValorCuenta,
            //                                     EntradasClase.ListEntradas1.Count,
            //                                     Convert.ToDecimal(this.txtEntradas.Text));

            //EntradasClase.AgregarEntradas(e);

            EntradasDtoCreate entradas = new EntradasDtoCreate();
            entradas.IdCuenta = Convert.ToInt32(this.txtIDCuenta.Text);
            entradas.entradas = Convert.ToDecimal(this.txtEntradas.Text);

            using (var client = new HttpClient())
            {
                var serializedStudent = JsonConvert.SerializeObject(entradas);
                var content = new StringContent(serializedStudent, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7245/api/Entradas", content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Entradas agregado");
                else
                    MessageBox.Show($"Error al guardar la entrada {response.Content.ReadAsStringAsync().Result}");
            }

        }
        //-----------------------------------------------------------------------
        public async void GuardarSalidas()
        {
            //SalidasClase s = new SalidasClase(OpCuentas.ListaCuentas1[c].IdCuenta,
            //                                     OpCuentas.ListaCuentas1[c].TipoCuenta,
            //                                     OpCuentas.ListaCuentas1[c].NombreCuenta,
            //                                     OpCuentas.ListaCuentas1[c].ValorCuenta,
            //                                     SalidasClase.ListSalidas1.Count,
            //                                     Convert.ToDecimal(this.txtSalidas.Text));

            //SalidasClase.AgregarSalidas(s);
            SalidasDtoCreate entradas = new SalidasDtoCreate();
            entradas.IdCuenta = Convert.ToInt32(this.txtIDCuenta.Text);
            entradas.salidas = Convert.ToDecimal(this.txtSalidas.Text);

            using (var client = new HttpClient())
            {
                var serializedStudent = JsonConvert.SerializeObject(entradas);
                var content = new StringContent(serializedStudent, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7245/api/Salidas", content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Salidas agregado");
                else
                    MessageBox.Show($"Error al guardar la salidas {response.Content.ReadAsStringAsync().Result}");
            }
        }
        //-------------------------------------------------------------------------------
        public async void MostrarEntradas()
        {
            //LimpiarEntradas();
            //int cont = 0;

            //foreach (EntradasClase EC in EntradasClase.ListEntradas1)
            //{
            //    if (c == EC.IdCuenta)
            //    {
            //        this.DataEntradas.Rows.Insert(cont, EC.IdTransaccion, EC.Entrada);
            //        cont++;
            //    }
            //}
            Thread.Sleep(500);
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync($"https://localhost:7245/api/Entradas/{c}");
                Thread.Sleep(500);
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<List<EntradasDto>>(data);
                    this.DataEntradas.DataSource = result.ToList();
                }
                else
                {
                    MessageBox.Show($"No se puede obtener la cuenta: {response.StatusCode}");
                }
            }
            //xd

            //using (var client = new HttpClient())
            //{
            //    using (var response = await client.GetAsync("https://localhost:7245/api/Entradas"))
            //    {
            //        if (response.IsSuccessStatusCode)
            //        {
            //            var entradas = await response.Content.ReadAsStringAsync();
            //            var result = JsonConvert.DeserializeObject<List<EntradasDto>>(entradas);
            //            DataEntradas.DataSource = result.ToList();
            //        }
            //        else
            //        {
            //            MessageBox.Show($"No se puede obtener la lista de estudiantes: {response.StatusCode}");
            //        }
            //    }
            //}

        }
        //-------------------------------------------------------------------------------
        public async void MostrarSalidas()
        {
            //LimpiarSalidas();   
            //int cont = 0;

            //foreach (SalidasClase SC in SalidasClase.ListSalidas1)
            //{
            //    if (c == SC.IdCuenta)
            //    {
            //        this.DataSalidas.Rows.Insert(cont, SC.Salida, SC.IdTransaccion);
            //        cont++;
            //    }
            //}

            Thread.Sleep(500);
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync($"https://localhost:7245/api/Salidas/{c}");
                Thread.Sleep(500);
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<List<SalidasDto>>(data);
                    this.DataSalidas.DataSource = result.ToList();
                }
                else
                {
                    MessageBox.Show($"No se puede obtener la salida: {response.StatusCode}");
                }
            }

        }

        private void rbEntradas_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbEntradas.Checked == true && this.rbSalidas.Checked == false)
            {
                this.txtEntradas.Enabled = true;
                this.txtSalidas.Enabled = false;

                this.DataSalidas.Enabled = false;
                this.DataEntradas.Enabled = true;
            }
        }

        private void rbSalidas_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbSalidas.Checked == true && this.rbEntradas.Checked == false)
            {
                this.txtEntradas.Enabled = false;
                this.txtSalidas.Enabled = true;

                this.DataEntradas.Enabled = false;
                this.DataSalidas.Enabled = true;
            }
        }

        private void DataSalidas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.DataSalidas.CurrentRow.Cells[0].Value != null)
            {
                this.rbSalidas.Checked = true;
                this.rbEntradas.Checked = false;

                this.txtEntradas.Enabled = false;
                this.txtSalidas.Enabled = true;

                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = true;
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = false;

                S = Convert.ToInt32(this.DataSalidas.CurrentRow.Cells[2].Value);
                this.txtIDTransaccion.Text = this.DataEntradas.CurrentRow.Cells[0].Value.ToString();
                this.txtSalidas.Text = this.DataEntradas.CurrentRow.Cells[1].Value.ToString();
            }
            else
            {
                MessageBox.Show("Campo de Salidas vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataEntradas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.DataEntradas.CurrentRow.Cells[0].Value != null)
            {
                this.rbEntradas.Checked = true;
                this.rbSalidas.Checked = false;

                this.txtEntradas.Enabled = true;
                this.txtSalidas.Enabled = false;

                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = true;
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = false;

                this.txtIDTransaccion.Text = this.DataEntradas.CurrentRow.Cells[0].Value.ToString();
                this.txtEntradas.Text = this.DataEntradas.CurrentRow.Cells[1].Value.ToString();
                E = Convert.ToInt32(this.DataEntradas.CurrentRow.Cells[2].Value);
            }
            else
            {
                MessageBox.Show("Campo de Salidas vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
