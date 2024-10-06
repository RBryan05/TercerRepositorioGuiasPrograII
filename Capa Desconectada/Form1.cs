using AccesoDatos;
using Capa_Desconectada.NorthwindTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Desconectada
{
    public partial class Form1 : Form
    {
        #region No Tipado
        CustomerRepository _customerRepository = new CustomerRepository();
        private void btnObtenerNoTipado_Click(object sender, EventArgs e)
        {
            dgvNoTipado.DataSource = _customerRepository.ObtenerTodos();
        }
        private void btnBuscarNoTipado_Click(object sender, EventArgs e)
        {
            string CustomerId = txtCustomerIDNoTipado.Text;
            var cliente = _customerRepository.ObtenerPorID(CustomerId);
            if (cliente == null)
            {
                MessageBox.Show("El objeto es null");
            }
            if (cliente != null)
            {
                AsignarDatosATextBox(cliente);
                var listaClientes = new List<Customer> { cliente };
                dgvNoTipado.DataSource = listaClientes;
            }
        }
        private void btnInsertarNoTipado_Click(object sender, EventArgs e)
        {
            int insertados = _customerRepository.InsertarCliente(Cliente());
            MessageBox.Show($"Se agrego {insertados} cliente.");
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var cliente = Cliente();
            int actualizar = _customerRepository.ActualizarCliente(cliente);
            MessageBox.Show($"Se actualizo {actualizar} cliente.");
        }
        #endregion

        #region Tipado
        CustomersTableAdapter Adaptador = new CustomersTableAdapter();
        private void btnObtenerTipados_Click(object sender, EventArgs e)
        {
            var customers = Adaptador.GetData();
            dgvTipado.DataSource = customers;
        }
        private void btnBuscarTipado_Click(object sender, EventArgs e)
        {
            var customer = Adaptador.GetDataByCustomerID(txtCustomerIdTipado.Text);

            if (customer != null)
            {
                var Cliente = _customerRepository.ExtraerInformacionDelCliente(customer);
                AsignarDatosATextBox(Cliente);
                var cliente = new List<Customer> { Cliente };
                dgvTipado.DataSource = cliente;
            }
        }
        private void btnInsertarTipado_Click(object sender, EventArgs e)
        {
            var insertar = Adaptador.Insert(Cliente().CustomerID, Cliente().CompanyName,
                Cliente().ContactName, Cliente().ContactTitle, Cliente().Address);
            MessageBox.Show($"Se agrego {insertar} cliente.");
        }
        private void btnActualizarTipado_Click(object sender, EventArgs e)
        {
            var fila = Adaptador.GetDataByCustomerID(txtCustomerID.Text);

            if (fila != null)
            {
                var datoOriginal = _customerRepository.ExtraerInformacionDelCliente(fila);
                var datosModificados = Cliente();

                int resultado = Adaptador.Update(
                    datosModificados.CompanyName,
                    datosModificados.ContactName,
                    datosModificados.ContactTitle,
                    datosModificados.Address,
                    datosModificados.City,
                    datosModificados.Region,
                    datosModificados.PostalCode,
                    datosModificados.Country,
                    datosModificados.Phone,
                    datosModificados.Fax,
                    datoOriginal.CustomerID,
                    datoOriginal.CompanyName,
                    datoOriginal.ContactName,
                    datoOriginal.ContactTitle,
                    datoOriginal.Address,
                    datoOriginal.City,
                    datoOriginal.Region,
                    datoOriginal.PostalCode,
                    datoOriginal.Country,
                    datoOriginal.Phone,
                    datoOriginal.Fax
                    );
                if(resultado != 0)
                {
                    dgvTipado.DataSource = Adaptador.GetData();
                }
            }
        }
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private Customer Cliente()
        {
            var cliente = new Customer
            {
                CompanyName = txtCompanyName.Text,
                ContactName = txtContactName.Text,
                CustomerID = txtCustomerID.Text,
                ContactTitle = txtContactTitle.Text,
                Address = txtAddres.Text
            };
            return cliente;
        }

        private void AsignarDatosATextBox(Customer cliente)
        {
            txtCustomerID.Text = cliente.CustomerID;
            txtContactTitle.Text = cliente.ContactTitle;
            txtContactName.Text = cliente.ContactName;
            txtCompanyName.Text = cliente.CompanyName;
            txtAddres.Text = cliente.Address;
        }
    }
}
