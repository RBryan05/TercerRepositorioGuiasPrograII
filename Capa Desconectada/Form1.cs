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
            dgvNoTipado.DataSource = _customerRepository.ObtenerPorID(CustomerId);
        }
        #endregion

        #region Tipado
        CustomersTableAdapter Adaptador = new CustomersTableAdapter();
        private void btnObtenerTipados_Click(object sender, EventArgs e)
        {
            var customers = Adaptador.GetData();
            dgvTipado.DataSource = customers;
        }
        #endregion
        public Form1()
        {
            InitializeComponent();
        }
    }
}
