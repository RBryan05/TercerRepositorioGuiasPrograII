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

        public Customer ObtenerPorID(string id)
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

        public Customer ExtraerInformacionDelCliente(DataTable dataTable)
        {
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

            return customer;
        }

        public int InsertarCliente(Customer customer)
        {
            using(var conexion = DataBase.GetSqlConnection())
            {
                String insertInto = "";
                insertInto = insertInto + "INSERT INTO [dbo].[Customers] " + "\n";
                insertInto = insertInto + "           ([CustomerID] " + "\n";
                insertInto = insertInto + "           ,[CompanyName] " + "\n";
                insertInto = insertInto + "           ,[ContactName] " + "\n";
                insertInto = insertInto + "           ,[ContactTitle] " + "\n";
                insertInto = insertInto + "           ,[Address]) " + "\n";
                insertInto = insertInto + " " + "\n";
                insertInto = insertInto + "     VALUES " + "\n";
                insertInto = insertInto + "           (@CustomerID" + "\n";
                insertInto = insertInto + "           ,@CompanyName " + "\n";
                insertInto = insertInto + "           ,@ContactName " + "\n";
                insertInto = insertInto + "           ,@ContactTitle " + "\n";
                insertInto = insertInto + "           ,@Address)";

                using(SqlCommand comando = new SqlCommand(insertInto, conexion)) 
                {
                    SqlCommand comandoConDatos = ParametrosSql(comando, customer);

                    SqlDataAdapter adaptador = new SqlDataAdapter()
                    {
                        InsertCommand = comandoConDatos
                    };
                    return adaptador.InsertCommand.ExecuteNonQuery();
                }
            }
        }

        public int ActualizarCliente(Customer cliente)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                String update = "";
                update = update + "UPDATE [dbo].[Customers] " + "\n";
                update = update + "   SET [CustomerID] = @CustomerID " + "\n";
                update = update + "      ,[CompanyName] = @CompanyName " + "\n";
                update = update + "      ,[ContactName] = @ContactName " + "\n";
                update = update + "      ,[ContactTitle] = @ContactTitle " + "\n";
                update = update + "      ,[Address] = @Address " + "\n";
                update = update + " WHERE [CustomerID] = @CustomerID";

                using(SqlCommand comando = new SqlCommand(update, conexion)) 
                {
                    SqlCommand comandoConDatos = ParametrosSql(comando, cliente);

                    SqlDataAdapter adaptador = new SqlDataAdapter()
                    {
                        UpdateCommand = comandoConDatos,
                    };
                    return adaptador.UpdateCommand.ExecuteNonQuery();
                }
            }
        }

        private SqlCommand ParametrosSql(SqlCommand comando, Customer cliente)
        {
            comando.Parameters.AddWithValue("CustomerID", cliente.CustomerID);
            comando.Parameters.AddWithValue("CompanyName", cliente.CompanyName);
            comando.Parameters.AddWithValue("ContactName", cliente.ContactName);
            comando.Parameters.AddWithValue("ContactTitle", cliente.ContactTitle);
            comando.Parameters.AddWithValue("Address", cliente.Address);
            return comando;
        }
    }
}
