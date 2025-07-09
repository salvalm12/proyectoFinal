using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClsVentasA
{
    public class clsVentas
    {
        private readonly string conexion =
       "server=localhost;database=Vuelos;uid=root;pwd=root;";

        public bool InsertarTicket(ticket ticket)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();
                string query = "INSERT INTO productos (id, numeroVuelo, fechaVuelo, HoraSalida," +
                    "Destino, Origen, pasajero, nuemeroAsiento)" +
                    " VALUES (@id, @numeroVuelo, @fechaVuelo, @HoraSalida," +
                    " @Destino, @Origen, @pasajero, @numeroAsiento)";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", ticket.id);
                cmd.Parameters.AddWithValue("@numeroVuelo", ticket.NumeroVuelo);
                cmd.Parameters.AddWithValue("@fechaVuelo", ticket.fechaVuelo);
                cmd.Parameters.AddWithValue("@HoraSalida", ticket.HoraSalida);
                cmd.Parameters.AddWithValue("@Destino", ticket.Destino);
                cmd.Parameters.AddWithValue("@Origen", ticket.Origen);
                cmd.Parameters.AddWithValue("@pasajero", ticket.Pasajero);
                cmd.Parameters.AddWithValue("@NumeroAsiento", ticket.NumeroAsiento);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException("Error " +
                    "al insertar el producto en la base de datos.", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error inesperado " +
                    " al insertar el producto.", ex);
            }
            finally
            {
                cmd.Dispose(); // Libera recursos asociados al comando                          
                conn.Close(); // Cierra la conexión si está abierta
                conn.Dispose(); // Libera recursos de conexión
            }
        }
    }
}
