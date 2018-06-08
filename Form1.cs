using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerSoftware2
{
    public partial class TablaValidaciones : Form
    {

        private int numeroDocumento;
        public TablaValidaciones()
        {
            InitializeComponent();
        }

        private void TablaValidaciones_Load(object sender, EventArgs e)
        {
            System.Collections.Generic.List<TipoDocumento>
                tiposDocumentos = new List<TipoDocumento>();

            tiposDocumentos.Add(new TipoDocumento() { Identificacion = 1, Nombre = "CedulaCiudadania" });
            tiposDocumentos.Add(new TipoDocumento() { Identificacion = 2, Nombre = " NUIP" });
            tiposDocumentos.Add(new TipoDocumento() { Identificacion = 3, Nombre = "Tarjeta de Identidad" });
            tiposDocumentos.Add(new TipoDocumento() { Identificacion = 4, Nombre = "Tarjeta de Extranjeria" });


            cbxTipodeDocumento.DataSource = tiposDocumentos;
            cbxTipodeDocumento.DisplayMember = "Nombre";

            System.Collections.Generic.List<Rango>
                Rango = new List<Rango>();

            //Grupo de Rangos 

            Rango.Add(new Rango() { Identificacion = 1, Nombre = "A" });
            Rango.Add(new Rango() { Identificacion = 2, Nombre = "B" });
            Rango.Add(new Rango() { Identificacion = 3, Nombre = "C" });

            // añadir el rango del paciente

            cbxRango.DataSource = Rango;
            cbxRango.DisplayMember = "Nombre";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                erpMensaje.SetError(txtNombre, "El nombre es obligatorio");
            }

            if (string.IsNullOrEmpty(cbxTipodeDocumento.Text))
            {
                erpMensaje.SetError(cbxTipodeDocumento, "Debe seleccionar un tipo de Docuemnto");


            }

            if (string.IsNullOrEmpty(rbtnFemenino.Text))
            {
                erpMensaje.SetError(rbtnFemenino, "Debe seleccionar el sexo");

            }

            else
            {
                erpMensaje.SetError(rbtnFemenino, "");

            }
            if (string.IsNullOrEmpty(rbtnMasculino.Text))
            {
                erpMensaje.SetError(rbtnMasculino, "Debe seleccionar el sexo");
            }
            else
            {
                erpMensaje.SetError(rbtnMasculino, "");
            }

            if (string.IsNullOrEmpty(txtNumerodeDocumento.Text))
            {
                erpMensaje.SetError(txtNumerodeDocumento, "Debe de ingresar el numero de documento");
            }
            else
            {
                erpMensaje.SetError(txtNumerodeDocumento, "");
            }

            if (string.IsNullOrEmpty(cbxRango.Text))
            {
                erpMensaje.SetError(cbxRango, "Debe de seleccionar el rango a que pertenece");
            }
            else
            {
                erpMensaje.SetError(cbxRango, "");
            }


            // El numero del documento registrado debe ser mayor a 0 y por ende realizar el calculo del valor a pagar

            if (numeroDocumento >= 0)
            {
                erpMensaje.SetError(txtNumerodeDocumento, "debe de ingresar un numero de documento Valido");
            }
            else
            {
                erpMensaje.SetError(txtNumerodeDocumento, "");
            }

            //El costo del servicio debe de ser obligatorio

            if (string.IsNullOrEmpty(txtCostodelServicio.Text))
            {
                erpMensaje.SetError(txtCostodelServicio, "Debe de Ingresar el valor del servicio");
            }
            else
            {
                erpMensaje.SetError(txtCostodelServicio, "");
            }

            if ((Convert.ToInt64(txtCostodelServicio.Text) <= 0))
            {
                erpMensaje.SetError(txtCostodelServicio, "Debe de ingresar un valor del costo valido");
            }
            else
            {
                erpMensaje.SetError(txtCostodelServicio, "");
            }
        }

        private void btnCalcularServicio_Click(object sender, EventArgs e)
        {
            // calcular pago A

            double CostodelServicio = 0;
            if (((Rango)cbxRango.SelectedItem).Identificacion == 1)
            {
                CostodelServicio = (Convert.ToInt64(txtCostodelServicio.Text) - ((Convert.ToInt64(txtCostodelServicio.Text) * 0.30)));
            }

            //Calcular valor B

            if (((Rango)cbxRango.SelectedItem).Identificacion == 2)
            {
                CostodelServicio = (Convert.ToInt64(txtCostodelServicio.Text) - ((Convert.ToInt64(txtCostodelServicio.Text) * 0.20)));
            }

            //Calculo del valor C

            if (((Rango)cbxRango.SelectedItem).Identificacion == 3)
            {
                CostodelServicio = (Convert.ToInt64(txtCostodelServicio.Text) - ((Convert.ToInt64(txtCostodelServicio.Text) * 0.10)));
            }

            MessageBox.Show("El valor a pagar por el servicio es de:" + CostodelServicio);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

