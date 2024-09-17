﻿using AccesoDatos;
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
        private void btninsertarNoTipado_Click(object sender, EventArgs e)
        {
            int insertados = _customerRepository.InsertarCliente(Cliente());
            MessageBox.Show($"Se agrego {insertados} cliente.");
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
                var cliente = _customerRepository.ExtraerInformacionDelCliente(customer);
                dgvTipado.DataSource = cliente;
            }
        }
        private void btnInsertarTipado_Click(object sender, EventArgs e)
        {
            var insertar = Adaptador.Insert(Cliente().CustomerID, Cliente().CompanyName, 
                Cliente().ContactName, Cliente().ContactTitle, Cliente().Address);
            MessageBox.Show($"Se agrego {insertar} cliente.");
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
    }
}
