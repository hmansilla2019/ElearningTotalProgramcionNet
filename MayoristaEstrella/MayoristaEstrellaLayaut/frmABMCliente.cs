using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MayoristaEstrellaEntities;
using MayoristaEstrellaBussiness;
namespace MayoristaEstrellaLayaut
{
    public partial class frmABMCliente : Form
    {
        public frmABMCliente()
        {
            InitializeComponent();
        }


        private Cliente cliente = new Cliente();
        public frmABMCliente(int ID)
        {
            InitializeComponent();
            lblId.Text = ID.ToString();

            cliente = ClienteBussiness.ObtenerCliente(ID);

            txtCUIT.Text = cliente.Cuit;
            txtDomicilio.Text = cliente.Domicilio;
            txtLocalidad.Text = cliente.Localidad;
            txtNacionalidad.Text = cliente.Nacionalidad;
            txtNombreApellido.Text = cliente.NombreApellido;
            txtPais.Text = cliente.Pais;
            txtMail.Text = cliente.Mail;
            txtProvincia.Text = cliente.Provincia;
            txtTelefono.Text = cliente.Telefono;
            dtpFechaNacimiento.Value = cliente.FechaNacimiento;
        }




     


        private void frmABMCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            cliente.Cuit=txtCUIT.Text;
            cliente.Domicilio= txtDomicilio.Text;
            cliente.Localidad = txtLocalidad.Text;
            cliente.Nacionalidad =txtNacionalidad.Text;
            cliente.NombreApellido=txtNombreApellido.Text;
            cliente.Pais = txtPais.Text;
            cliente.Mail = txtMail.Text;
            cliente.Provincia = txtProvincia.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.FechaNacimiento = dtpFechaNacimiento.Value;

            ClienteBussiness.ABMCliente(cliente);

            MessageBox.Show("Se guardo el cliente OK");

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
