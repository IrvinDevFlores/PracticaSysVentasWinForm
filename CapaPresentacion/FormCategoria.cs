using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
namespace CapaPresentacion
{
    public partial class FormCategoria : Form
    {

        private bool IsNuevo = false;
        private bool IsEditar = false;
        public FormCategoria()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombre,
                "Ingrese el nombre de la categoria");
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        public void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtIdCategoria.Text = string.Empty;
        }

        public void Habilitar(bool valor)
        {
            txtNombre.ReadOnly = !valor;
            txtDescripcion.ReadOnly = !valor;
            txtIdCategoria.ReadOnly = !valor;
        }

        public void Botones()
        {
            bool cualquiera = IsNuevo || IsEditar;
            if (!cualquiera)
            {
                Habilitar(false);
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
                return;
            }

            Habilitar(true);
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;


        }

        private void OcultarColumnas()
        {
            dataListadoCategorias.Columns[0].Visible = false;
            dataListadoCategorias.Columns[1].Visible = false;
        }

        private void Mostrar()
        {
            dataListadoCategorias.DataSource = NCategoria.MostrarCategoria();
            OcultarColumnas();
            string columnsCount = Convert.ToString(dataListadoCategorias.Rows.Count);
            labelTotal.Text = $"Total registros: {columnsCount}";
        }

        public void BuscarCategoria()
        {
            this.dataListadoCategorias.DataSource = NCategoria.Buscar(txtCategoriaBuscada.Text);

            OcultarColumnas();
            string columnsCount = Convert.ToString(dataListadoCategorias.Rows.Count);
            labelTotal.Text = $"Total registro: {columnsCount}";
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            Mostrar();
            Habilitar(false);
            Botones();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BuscarCategoria();
        }

        private void TxtCategoriaBuscada_TextChanged(object sender, EventArgs e)
        {
            BuscarCategoria();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            IsNuevo = true;
            IsEditar = false;
            Botones();
            Limpiar();
            Habilitar(true);
            txtNombre.Focus();
        }

        public void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje,"Ventas");
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
         
        {
            try
            {
                string respuesta = "";
                bool isEmpty = txtNombre.Text == string.Empty;
                if (isEmpty)
                {
                    MensajeError("Se le pediran campos que corrija");
                    errorIcono.SetError(txtNombre, "Ingrese nombre");

                }
                else
                {
                    if (IsNuevo)
                    {

                        respuesta = NCategoria.InsertarCategoria(txtNombre.Text.Trim(), txtDescripcion.Text.Trim());
                    }
                    else
                    {
                        int id = Convert.ToInt32(txtIdCategoria.Text.Trim());
                        string nombre = txtNombre.Text.Trim();
                        string descripcion = txtDescripcion.Text.Trim();
                        respuesta = NCategoria.EditarCategoria(id, nombre, descripcion);

                    }

                    if (respuesta.Equals("OK"))
                    {
                        if (IsNuevo)
                        {
                            MensajeOk("Se inserto correcto");
                        }
                        else
                        {
                            MensajeOk("Se actualizo correctamente");
                        }
                    }
                    else
                    {
                        MensajeError(respuesta);
                    }

                    IsNuevo = false;
                    IsEditar = false;
                    Botones();
                    Limpiar();
                    Mostrar();

                }
            }
            catch (Exception ex) { }
        }

        private void DataListadoCategorias_DoubleClick(object sender, EventArgs e)
        {
            txtIdCategoria.Text = Convert.ToString(dataListadoCategorias
                .CurrentRow.Cells["IdCategoria"].Value);

            txtNombre.Text = Convert.ToString(dataListadoCategorias
                .CurrentRow.Cells["Nombre"].Value);

            txtDescripcion.Text = Convert.ToString(dataListadoCategorias
                .CurrentRow.Cells["Descripcion"].Value);

            CategoriasControl.SelectedIndex = 1;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            bool siNoEstaVacio = !txtIdCategoria.Text.Equals("");
            if (siNoEstaVacio)
            {
                IsEditar = true;
                Botones();
                Habilitar(true);
                return;
            }
            MensajeError("Debe selecionar algo");
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            IsNuevo = false;
            IsEditar = false;
            Botones();
            Limpiar();
            Habilitar(false);
        }

        private void CheckEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEliminar.Checked)
            {
                dataListadoCategorias.Columns[0].Visible = true;
            }
            else
            {
                dataListadoCategorias.Columns[0].Visible = false;
            }
        }

        private void DataListadoCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool elIdDeCategoriasEsIgual = e.ColumnIndex == dataListadoCategorias
                .Columns["Eliminar"].Index;
            if (elIdDeCategoriasEsIgual)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dataListadoCategorias
                    .Rows[e.RowIndex].Cells["Eliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult option = MessageBox.Show("Quiere borrar realmente","SistemaVentas", 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                bool respuestaElegida = option == DialogResult.OK;
                if (respuestaElegida)
                {
                    string codigo;
                    string respuesta = "";

                   foreach( DataGridViewRow row in dataListadoCategorias.Rows)
                    {
                        bool esIgualLaCelda = Convert.ToBoolean(row.Cells[0].Value);

                        if (esIgualLaCelda)
                        {
                            codigo = Convert.ToString(row.Cells[1].Value);

                            respuesta = NCategoria.EliminarCategoria(Convert.ToInt32(codigo));

                            if (respuesta.Equals("OK"))
                            {
                                MensajeOk("Se elimino correctamente");
                            }
                            else
                            {
                                MensajeError(respuesta);
                            }
                        }
                    }

                    Mostrar();
                }

            }
            catch (Exception ex) { }
        }
    }
}
