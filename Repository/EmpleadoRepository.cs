using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Lab12.Models;

namespace Lab12.Repository
{
    public class EmpleadoRepository
    {
        private SqlConnection connection;

        private void DbConnection()
        {
            string conf = ConfigurationManager.ConnectionStrings["lab12"].ToString();
            connection = new SqlConnection(conf);
        }

        public List<Empleado> getEmployees()
        {
            DbConnection();
            List<Empleado> empleados = new List<Empleado>();
            SqlCommand command = new SqlCommand("sp_listarEmpleados", connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            connection.Open();
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow data in dataTable.Rows)
            {
                empleados.Add(new Empleado
                {
                    IdEmpleado = Convert.ToInt32(data["IdEmpleado"]),
                    Apellidos = Convert.ToString(data["Apellidos"]),
                    Nombre = Convert.ToString(data["Nombre"]),
                    Cargo = Convert.ToString(data["Cargo"]),
                    Tratamiento = Convert.ToString(data["Tratamiento"]),
                    FechaNacimiento = Convert.ToDateTime(data["FechaNacimiento"]),
                    FechaContratacion = Convert.ToDateTime(data["FechaContratacion"]),
                });
            }
            return empleados;
        }

        public List<Pedido> getPedidos()
        {
            DbConnection();
            List<Pedido> pedidos = new List<Pedido>();
            SqlCommand command = new SqlCommand("sp_listarPedidos3", connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            connection.Open();
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow data in dataTable.Rows)
            {
                pedidos.Add(new Pedido
                {
                    IdPedido = Convert.ToInt32(data["IdPedido"]),
                    IdCliente = Convert.ToString(data["IdCliente"]),
                    IdEmpleado = Convert.ToInt32(data["IdEmpleado"]),
                    FechaPedido = Convert.ToDateTime(data["FechaPedido"]),
                    FechaEntrega = Convert.ToDateTime(data["FechaEntrega"]),
                    FechaEnvio = Convert.ToDateTime(data["FechaEnvio"]),
                    FormaEnvio = Convert.ToInt32(data["FormaEnvio"]),
                    Cargo = Convert.ToDouble(data["Cargo"]),
                    Destinatario = Convert.ToString(data["Destinatario"]),
                });
            }
            return pedidos;
        }

        public List<Cliente> getClients()
        {
            DbConnection();
            List<Cliente> clientes = new List<Cliente>();
            SqlCommand command = new SqlCommand("sp_listarClientes", connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            connection.Open();
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow data in dataTable.Rows)
            {
                clientes.Add(new Cliente
                {
                    IdCliente = Convert.ToString(data["IdCliente"]),
                    NombreCompañia = Convert.ToString(data["NombreCompa�ia"])
                });
            }
            return clientes;
        }

        public List<DetallePedido> getDetallePedidos()
        {
            DbConnection();
            List<DetallePedido> detalles = new List<DetallePedido>();
            SqlCommand command = new SqlCommand("sp_listarDetallePedidos", connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            connection.Open();
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow data in dataTable.Rows)
            {
                detalles.Add(new DetallePedido
                {
                    IdPedido = Convert.ToInt32(data["IdPedido"]),
                    IdProducto = Convert.ToInt32(data["IdProducto"]),
                    NombreProducto = Convert.ToString(data["NombreProducto"]),
                    PrecioUnidad = Convert.ToDouble(data["PrecioUnidad"]),
                    Cantidad = Convert.ToInt32(data["Cantidad"]),
                });
            }
            return detalles;
        }
    }
}