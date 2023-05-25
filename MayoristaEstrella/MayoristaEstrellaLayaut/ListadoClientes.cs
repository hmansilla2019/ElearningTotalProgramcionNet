using MayoristaEstrellaBussiness;
using MayoristaEstrellaEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayoristaEstrellaLayaut
{
    public partial class ListadoClientes : Form
    {
        public ListadoClientes()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmABMCliente cliente = new frmABMCliente();
            cliente.FormClosed += new System.Windows.Forms.FormClosedEventHandler(Cliente_FormClosed);

            cliente.ShowDialog();
        }

        private void Cliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            dgClientes.AutoGenerateColumns = false;
            dgClientes.DataSource = ClienteBussiness.ListarClientes(txtNombre.Text);

        }

        private void btnFlitrar_Click(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void ListadoClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            int id = (int)this.dgClientes.Rows[e.RowIndex].Cells["Id"].Value;

            if (this.dgClientes.Columns[e.ColumnIndex].Name == "btnEditar")
            {

             
                frmABMCliente frmcliente = new frmABMCliente(id);
                frmcliente.FormClosed += new System.Windows.Forms.FormClosedEventHandler(Cliente_FormClosed);

                frmcliente.ShowDialog();
            }
            else if (this.dgClientes.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                if (MessageBox.Show("Esta seguro de eliminar el cliente?","Cliente",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    ClienteBussiness.DeleteCliente(id);
                    MessageBox.Show("Se elimino correctamente el cliente");
                    CargarClientes();
                }
            }
        }
    }
}
