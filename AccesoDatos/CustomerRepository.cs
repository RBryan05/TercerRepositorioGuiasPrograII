using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CustomerRepository
    {
        public string conexion = DataBase.ConnectionString;
        public DataTable ObtenerTodos()
        {
            DataTable dataTable = new DataTable();
            String selectAll = "";
            selectAll = selectAll + "SELECT [CustomerID] " + "\n";
            selectAll = selectAll + "      ,[CompanyName] " + "\n";
            selectAll = selectAll + "      ,[ContactName] " + "\n";
            selectAll = selectAll + "      ,[ContactTitle] " + "\n";
            selectAll = selectAll + "      ,[Address] " + "\n";
            selectAll = selectAll + "      ,[City] " + "\n";
            selectAll = selectAll + "      ,[Region] " + "\n";
            selectAll = selectAll + "      ,[PostalCode] " + "\n";
            selectAll = selectAll + "      ,[Country] " + "\n";
            selectAll = selectAll + "      ,[Phone] " + "\n";
            selectAll = selectAll + "      ,[Fax] " + "\n";
            selectAll = selectAll + "  FROM [dbo].[Customers]";

            SqlDataAdapter adapter =
                new SqlDataAdapter(selectAll, conexion);
            adapter.Fill(dataTable);

            return dataTable;
        }

        public List<Customer> ObtenerPorID(string id)
        {
            DataTable dataTable = new DataTable();
            using (var conexion = DataBase.GetSqlConnection())
            {
                String selectPorID = "";
                selectPorID = selectPorID + "SELECT [CustomerID] " + "\n";
                selectPorID = selectPorID + "      ,[CompanyName] " + "\n";
                selectPorID = selectPorID + "      ,[ContactName] " + "\n";
                selectPorID = selectPorID + "      ,[ContactTitle] " + "\n";
                selectPorID = selectPorID + "      ,[Address] " + "\n";
                selectPorID = selectPorID + "      ,[City] " + "\n";
                selectPorID = selectPorID + "      ,[Region] " + "\n";
                selectPorID = selectPorID + "      ,[PostalCode] " + "\n";
                selectPorID = selectPorID + "      ,[Country] " + "\n";
                selectPorID = selectPorID + "      ,[Phone] " + "\n";
                selectPorID = selectPorID + "      ,[Fax] " + "\n";
                selectPorID = selectPorID + "  FROM [dbo].[Customers]";
                selectPorID = selectPorID + "  WHERE [CustomerID] = @CustomerID";

                using(SqlCommand comando =  new SqlCommand(selectPorID,conexion))
                {
                    comando.Parameters.AddWithValue("@CustomerId", id);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    adapter.Fill(dataTable);

                    var cliente = ExtraerInformacionDelCliente(dataTable);
                    return cliente;
                }
            }
        }

        public List<Customer> ExtraerInformacionDelCliente(DataTable dataTable)
        {
            List<Customer> cliente = new List<Customer>();
            Customer customer = new Customer();
            foreach (DataRow fila in dataTable.Rows)
            {
                customer.CustomerID = fila.Field<String>("CustomerID");
                customer.CompanyName = fila.Field<String>("CompanyName");
                customer.ContactName = fila.Field<String>("ContactName");
                customer.ContactTitle = fila.Field<String>("ContactTitle");
                customer.Address = fila.Field<String>("address");
                customer.City = fila.Field<String>("City");
                customer.Region = fila.Field<String>("Region");
                customer.PostalCode = fila.Field<String>("PostalCode");
                customer.Country = fila.Field<String>("Country");
                customer.Phone = fila.Field<String>("Phone");
                customer.Fax = fila.Field<String>("Fax");
            }
            cliente.Add(customer);

            return cliente;
        }
    }
}
