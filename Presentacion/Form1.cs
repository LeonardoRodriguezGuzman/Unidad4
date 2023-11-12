using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using Unidad4.Datos;
using Unidad4.Pojos;

namespace Unidad4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<clsEmployees> empleados = DAOEmployees.ObtenerListaEmpleados();
            cbEmpleados.DataSource = empleados;
            cbEmpleados.DisplayMember = "empleado";
            List<clsCustomers> customers = DAOCustomers.ObternerListaCustomers();
            cbCliente.DataSource = customers;
            cbCliente.DisplayMember = "customers";
            List<clsShippers> shippers = DAOShippers.ObtenerListaShippers();
            cbProveedor.DataSource = shippers;
            cbProveedor.DisplayMember = "shippers";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        { 
        }
        private void agregarProducto()
        {
            int i = int.Parse(txtProducto.Text);
            clsProducts producto = DAOProducts.ObtenerProducto(i);
            txtProducto.Text = "";
            MessageBox.Show(producto.toString());
        }

        private void txtProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                agregarProducto();
            }
        }
    }
}