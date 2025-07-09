using MySql.Data.MySqlClient;
using proyectoFinal;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClsVentasA
{

    public class clsVentas
    {
        private readonly string conexion =
       "server=localhost;database=ItsurAirline;uid=root;pwd=root;";

        /// <summary>
        /// Inserta un nuevo registro de ticket en la base de datos.
        /// </summary>
        /// <param name="ticket">Objeto 'ticket' con la información a insertar.</param>
        /// <returns>Retorna 'true' si la operación fue exitosa, de lo contrario relanza una excepción.</returns>
        /// <exception cref="ApplicationException">Se produce si ocurre un error específico de MySQL o un error inesperado durante la inserción.</exception>
        public bool InsertarTicket(ticket ticket)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();
                string query = "INSERT INTO Ticket (id, numeroVuelo, fechaVuelo, HoraSalida, " +
                                 "Destino, Origen, pasajero, numeroAsiento,Estado, Costo) " +
                                 "VALUES (@id, @numeroVuelo, @fechaVuelo, @HoraSalida, " +
                                 "@Destino, @Origen, @pasajero, @numeroAsiento, @Estado, @Costo)";

                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", ticket.id);
                cmd.Parameters.AddWithValue("@numeroVuelo", ticket.NumeroVuelo);
                cmd.Parameters.AddWithValue("@fechaVuelo", ticket.fechaVuelo);
                cmd.Parameters.AddWithValue("@HoraSalida", ticket.HoraSalida);
                cmd.Parameters.AddWithValue("@Destino", ticket.Destino);
                cmd.Parameters.AddWithValue("@Origen", ticket.Origen);
                cmd.Parameters.AddWithValue("@pasajero", ticket.Pasajero);
                cmd.Parameters.AddWithValue("@numeroAsiento", ticket.NumeroAsiento);
                cmd.Parameters.AddWithValue("@Estado", ticket.Estado);
                cmd.Parameters.AddWithValue("@Costo", ticket.Costo);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException("Error " +
                    "al crear el ticket en la base de datos.", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error inesperado " +
                    " al insertar el ticket.", ex);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
            }
        }

        /// <summary>
        /// Inserta un nuevo registro de vuelo en la base de datos.
        /// </summary>
        /// <param name="vuelo">Objeto 'vuelos' con la información a insertar.</param>
        /// <returns>Retorna 'true' si la operación fue exitosa.</returns>
        public bool InsertarVuelo(vuelos vuelo)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();
                string query = "INSERT INTO VuelosD (id, numeroVuelo, fechaVuelo, HoraSalida, " +
                                 "Destino, precio) " +
                                 "VALUES (@id, @numeroVuelo, @fechaVuelo, @HoraSalida, " +
                                 "@Destino, @precio)";

                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", vuelo.id);
                cmd.Parameters.AddWithValue("@numeroVuelo", vuelo.NumeroVuelo);
                cmd.Parameters.AddWithValue("@fechaVuelo", vuelo.fechaVuelo);
                cmd.Parameters.AddWithValue("@HoraSalida", vuelo.HoraSalida);
                cmd.Parameters.AddWithValue("@Destino", vuelo.Destino);
                cmd.Parameters.AddWithValue("@precio", vuelo.precio);
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (MySqlException ex)
            {
                throw new ApplicationException("Error " +
                    "al crear el Vuelo en la base de datos.", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error inesperado " +
                    " al insertar el Vuelo.", ex);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
            }
        }

        /// <summary>
        /// Obtiene todos los vuelos disponibles desde la base de datos.
        /// </summary>
        /// <returns>Una lista de objetos 'vuelos'.</returns>
        public List<vuelos> ObtenerVuelos()
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;
            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();
                string query = "Select * from VuelosD";
                cmd = new MySqlCommand(query, conn);
                reader = cmd.ExecuteReader();

                List<vuelos> VuelosD = new List<vuelos>();
                while (reader.Read())
                {
                    vuelos vuelos = new vuelos();
                    vuelos.id = reader.GetInt32(0);
                    vuelos.NumeroVuelo = reader.GetString(1);
                    vuelos.fechaVuelo = reader.GetDateTime(2);
                    vuelos.HoraSalida = reader.GetTimeSpan(3);
                    vuelos.Destino = reader.GetString(4);
                    vuelos.precio = reader.GetDouble(5);
                    VuelosD.Add(vuelos);
                }

                return VuelosD;
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
                cmd.Dispose();
                conn.Close();
                conn.Dispose();

            }
        }

        /// <summary>
        /// Obtiene todos los tickets registrados en la base de datos.
        /// </summary>
        /// <returns>Una lista de objetos 'ticket'.</returns>
        public List<ticket> Obtenertickets()
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;
            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();
                string query = "Select * from Ticket";
                cmd = new MySqlCommand(query, conn);
                reader = cmd.ExecuteReader();

                List<ticket> tickets = new List<ticket>();
                while (reader.Read())
                {
                    ticket ticket = new ticket();
                    ticket.id = reader.GetString(0);
                    ticket.NumeroVuelo = reader.GetString(1);
                    ticket.fechaVuelo = reader.GetDateTime(2);
                    ticket.HoraSalida = reader.GetTimeSpan(3);
                    ticket.Destino = reader.GetString(4);
                    ticket.Origen = reader.GetString(5);
                    ticket.Pasajero = reader.GetString(6);
                    ticket.NumeroAsiento = reader.GetString(7);
                    ticket.Estado = reader.GetBoolean(8);
                    ticket.Costo = reader.GetDouble(9);
                    tickets.Add(ticket);
                }

                return tickets;
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
                cmd.Dispose();
                conn.Close();
                conn.Dispose();

            }
        }

        /// <summary>
        /// Actualiza la información de un ticket existente.
        /// </summary>
        /// <param name="Id">El identificador del ticket a editar.</param>
        /// <param name="ticket">El objeto 'ticket' con los nuevos datos.</param>
        /// <returns>Retorna 'true' si la actualización fue exitosa.</returns>
        public bool Editarticket(string Id, ticket ticket)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();
                string query = "UPDATE Ticket SET numeroVuelo=@numeroVuelo, fechaVuelo=@fechaVuelo, HoraSalida=@HoraSalida, " +
                       " Destino=@Destino, Origen=@Origen, pasajero=@pasajero, numeroAsiento=@numeroAsiento, Estado=@Estado WHERE id=@id";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@numeroVuelo", ticket.NumeroVuelo);
                cmd.Parameters.AddWithValue("@fechaVuelo", ticket.fechaVuelo);
                cmd.Parameters.AddWithValue("@HoraSalida", ticket.HoraSalida);
                cmd.Parameters.AddWithValue("@Destino", ticket.Destino);
                cmd.Parameters.AddWithValue("@Origen", ticket.Origen);
                cmd.Parameters.AddWithValue("@pasajero", ticket.Pasajero);
                cmd.Parameters.AddWithValue("@numeroAsiento", ticket.NumeroAsiento);
                cmd.Parameters.AddWithValue("@Estado", ticket.Estado);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException("Error " +
                    "al actualizar el producto en la base de datos.", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error inesperado " +
                    " al actualizar el producto.", ex);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
            }
        }

        /// <summary>
        /// Actualiza la información de un vuelo existente.
        /// </summary>
        /// <param name="Id">El identificador del vuelo a editar.</param>
        /// <param name="vuelo">El objeto 'vuelos' con los nuevos datos.</param>
        /// <returns>Retorna 'true' si la actualización fue exitosa.</returns>
        public bool EditarVuelo(string Id, vuelos vuelo)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();
                string query = "UPDATE vuelosD SET numeroVuelo=@numeroVuelo, fechaVuelo=@fechaVuelo, HoraSalida=@HoraSalida, " +
                       " Destino=@Destino, precio=@precio WHERE id=@id";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@numeroVuelo", vuelo.NumeroVuelo);
                cmd.Parameters.AddWithValue("@fechaVuelo", vuelo.fechaVuelo);
                cmd.Parameters.AddWithValue("@HoraSalida", vuelo.HoraSalida);
                cmd.Parameters.AddWithValue("@Destino", vuelo.Destino);
                cmd.Parameters.AddWithValue("@precio", vuelo.precio);


                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException("Error " +
                    "al actualizar el producto en la base de datos.", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error inesperado " +
                    " al actualizar el producto.", ex);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
            }

        }

        /// <summary>
        /// Recupera una lista de vuelos que coinciden con un ID específico.
        /// </summary>
        /// <param name="Id">El ID del vuelo a buscar.</param>
        /// <returns>Una lista de objetos 'vuelos'. Potencialmente vacía si no hay coincidencias.</returns>
        public List<vuelos> ObtenervuelosPorId(int Id)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;
            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();
                string query = "Select * from VuelosD where id = @Id ";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", Id);
                reader = cmd.ExecuteReader();

                List<vuelos> vuelos = new List<vuelos>();
                while (reader.Read())
                {
                    vuelos vuelo = new vuelos();
                    vuelo.id = reader.GetInt32(0);
                    vuelo.NumeroVuelo = reader.GetString(1);
                    vuelo.fechaVuelo = reader.GetDateTime(2);
                    vuelo.HoraSalida = reader.GetTimeSpan(3);
                    vuelo.Destino = reader.GetString(4);
                    vuelo.precio = reader.GetDouble(5);
                    vuelos.Add(vuelo);
                }

                return vuelos;
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
                cmd.Dispose();
                conn.Close();
                conn.Dispose();

            }
        }

        /// <summary>
        /// Recupera una lista de tickets que coinciden con un ID específico.
        /// </summary>
        /// <param name="id">El ID del ticket a buscar.</param>
        /// <returns>Una lista de objetos 'ticket'. Potencialmente vacía si no hay coincidencias.</returns>
        public List<ticket> ObtenerticketsPorID(string id)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;
            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();
                string query = "Select * from Ticket WHERE id = @Id ";
                cmd = new MySqlCommand(query, conn);
                reader = cmd.ExecuteReader();

                List<ticket> tickets = new List<ticket>();
                while (reader.Read())
                {
                    ticket ticket = new ticket();
                    ticket.id = reader.GetString(0);
                    ticket.NumeroVuelo = reader.GetString(1);
                    ticket.fechaVuelo = reader.GetDateTime(2);
                    ticket.HoraSalida = reader.GetTimeSpan(3);
                    ticket.Destino = reader.GetString(4);
                    ticket.Origen = reader.GetString(5);
                    ticket.Pasajero = reader.GetString(6);
                    ticket.NumeroAsiento = reader.GetString(7);
                    ticket.Estado = reader.GetBoolean(8);
                    ticket.Costo = reader.GetDouble(9);

                    tickets.Add(ticket);
                }

                return tickets;
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
                cmd.Dispose();
                conn.Close();
                conn.Dispose();

            }
        }

        /// <summary>
        /// Elimina un vuelo de la base de datos utilizando su ID.
        /// </summary>
        /// <param name="Id">El ID del vuelo a eliminar.</param>
        /// <returns>Retorna 'true' si la eliminación fue exitosa.</returns>
        public bool EliminarVuelo(string Id)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();
                string query = "DELETE from VuelosD where id=@id";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", Id);

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
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
            }


        }

        /// <summary>
        /// Elimina un ticket de la base de datos utilizando su ID.
        /// </summary>
        /// <param name="Id">El ID del ticket a eliminar.</param>
        /// <returns>Retorna 'true' si la eliminación fue exitosa.</returns>
        public bool EliminarTicket(string Id)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();
                string query = "DELETE from Ticket where id=@id";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", Id);

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
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
            }


        }

        /// <summary>
        /// Obtiene la fecha de un vuelo específico usando su ID.
        /// </summary>
        /// <param name="idVuelo">El ID del vuelo.</param>
        /// <returns>La fecha del vuelo como un objeto DateTime. Retorna DateTime.MinValue si no se encuentra.</returns>
        public DateTime ObtenerFechaVueloPorId(int idVuelo)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            DateTime fechaVuelo = DateTime.MinValue;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();
                string query = "SELECT fechaVuelo FROM VuelosD WHERE id = @id";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idVuelo);

                object resultado = cmd.ExecuteScalar();

                if (resultado != null && resultado != DBNull.Value)
                {
                    fechaVuelo = Convert.ToDateTime(resultado);
                }

                return fechaVuelo;
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException("Error al obtener la fecha del vuelo.", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error inesperado al obtener la fecha del vuelo.", ex);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
            }
        }

        /// <summary>
        /// Obtiene la hora de salida de un vuelo específico usando su ID.
        /// </summary>
        /// <param name="idVuelo">El ID del vuelo.</param>
        /// <returns>La hora de salida como un objeto TimeSpan. Retorna TimeSpan.Zero si no se encuentra.</returns>
        public TimeSpan ObtenerHoraSalidaPorId(int idVuelo)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            TimeSpan horaSalida = TimeSpan.Zero;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();
                string query = "SELECT HoraSalida FROM VuelosD WHERE id = @id";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idVuelo);

                object resultado = cmd.ExecuteScalar();

                if (resultado != null && resultado != DBNull.Value)
                {
                    horaSalida = (TimeSpan)resultado;
                }

                return horaSalida;
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException("Error al obtener la hora de salida del vuelo.", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error inesperado al obtener la hora de salida del vuelo.", ex);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
            }
        }

        /// <summary>
        /// Obtiene una lista de los asientos ya ocupados para un número de vuelo específico.
        /// </summary>
        /// <param name="numeroVuelo">El número del vuelo a consultar.</param>
        /// <returns>Una lista de strings, donde cada string es un número de asiento ocupado.</returns>
        public List<string> ObtenerAsientosOcupadosPorNumeroVuelo(String numeroVuelo)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            List<string> asientosOcupados = new List<string>();

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();
                string query = "SELECT numeroAsiento FROM Ticket WHERE numeroVuelo = @numeroVuelo";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@numeroVuelo", numeroVuelo);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        asientosOcupados.Add(reader.GetString(0));
                    }
                }

                return asientosOcupados;
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException("Error al obtener los asientos ocupados.", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error inesperado al obtener los asientos ocupados.", ex);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
            }
        }

        /// <summary>
        /// Obtiene el número de vuelo a partir de su ID.
        /// </summary>
        /// <param name="idVuelo">El ID del vuelo.</param>
        /// <returns>El número de vuelo como string. Retorna un string vacío si no se encuentra.</returns>
        public String ObtenerNumeroVuelo(int idVuelo)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            String NVuelo = "";

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();
                string query = "SELECT NumeroVuelo FROM VuelosD WHERE id = @id";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idVuelo);

                object resultado = cmd.ExecuteScalar();

                if (resultado != null && resultado != DBNull.Value)
                {
                    NVuelo = (string)resultado;
                }

                return NVuelo;
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException("Error al obtener la fecha del vuelo.", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error inesperado al obtener la fecha del vuelo.", ex);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
            }
        }

        /// <summary>
        /// Recupera un único objeto 'vuelos' por su ID.
        /// </summary>
        /// <param name="Id">El ID del vuelo a buscar.</param>
        /// <returns>Un objeto 'vuelos'. Retorna un objeto vacío si no se encuentra.</returns>
        public vuelos ObtenervueloPorId(int Id)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;
            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();
                string query = "Select * from VuelosD where id = @Id ";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", Id);
                reader = cmd.ExecuteReader();
                vuelos vuelo = new vuelos();

                while (reader.Read())
                {

                    vuelo.id = reader.GetInt32(0);
                    vuelo.NumeroVuelo = reader.GetString(1);
                    vuelo.fechaVuelo = reader.GetDateTime(2);
                    vuelo.HoraSalida = reader.GetTimeSpan(3);
                    vuelo.Destino = reader.GetString(4);
                    vuelo.precio = reader.GetDouble(5);

                }

                return vuelo;
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
                cmd.Dispose();
                conn.Close();
                conn.Dispose();

            }
        }

        /// <summary>
        /// Recupera un único objeto 'ticket' por su ID.
        /// </summary>
        /// <param name="Id">El ID del ticket a buscar.</param>
        /// <returns>Un objeto 'ticket' o null si no se encuentra.</returns>
        public ticket ObtenerTicketPorId(string Id)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = "SELECT * FROM Ticket WHERE id = @Id";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", Id);

                reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                    return null;

                ticket ticket = new ticket();

                while (reader.Read())
                {
                    ticket.id = reader.GetString(0);
                    ticket.NumeroVuelo = reader.GetString(1);
                    ticket.fechaVuelo = reader.GetDateTime(2);
                    ticket.HoraSalida = reader.GetTimeSpan(3);
                    ticket.Destino = reader.GetString(4);
                    ticket.Origen = reader.GetString(5);
                    ticket.Pasajero = reader.GetString(6);
                    ticket.NumeroAsiento = reader.GetString(7);
                    ticket.Estado = reader.IsDBNull(8) ? false : reader.GetBoolean(8);
                    ticket.Costo = reader.GetDouble(9);

                }

                return ticket;
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException("Error al consultar el ticket en la base de datos.", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error inesperado al consultar el ticket.", ex);
            }
            finally
            {
                reader?.Close();
                cmd?.Dispose();
                conn?.Close();
                conn?.Dispose();
            }
        }

        /// <summary>
        /// Configura y carga la representación visual de los asientos en un DataGridView.
        /// Marca los asientos ocupados y deshabilita la interacción con ellos y el pasillo.
        /// </summary>
        /// <param name="dtgAsiento">El control DataGridView que mostrará los asientos.</param>
        /// <param name="asientosOcupados">Una lista de los números de asiento que ya están ocupados.</param>
        public void CargarAsientos(DataGridView dtgAsiento, List<string> asientosOcupados)
        {
            dtgAsiento.Rows.Clear();
            dtgAsiento.Columns.Clear();
            dtgAsiento.AllowUserToAddRows = false;
            dtgAsiento.RowHeadersVisible = false;
            dtgAsiento.SelectionMode = DataGridViewSelectionMode.CellSelect;

            dtgAsiento.Enabled = true;

            for (int col = 0; col < 7; col++)
            {
                var columna = new DataGridViewTextBoxColumn
                {
                    Name = $"Col{col + 1}",
                    Width = 50,
                    SortMode = DataGridViewColumnSortMode.NotSortable
                };
                dtgAsiento.Columns.Add(columna);
            }

            for (int fila = 0; fila < 5; fila++)
            {
                DataGridViewRow nuevaFila = new DataGridViewRow
                {
                    Height = 50
                };
                nuevaFila.CreateCells(dtgAsiento);

                for (int col = 0; col < 7; col++)
                {
                    string asiento = (fila + 1).ToString() + (char)('A' + col);

                    if (col == 3)
                    {
                        nuevaFila.Cells[col].Value = "";
                        nuevaFila.Cells[col].ReadOnly = true;
                        nuevaFila.Cells[col].Style.BackColor = Color.LightGray;
                        nuevaFila.Cells[col].Style.SelectionBackColor = Color.LightGray;
                        nuevaFila.Cells[col].Style.SelectionForeColor = Color.LightGray;
                    }
                    else
                    {
                        nuevaFila.Cells[col].Value = asiento;
                        nuevaFila.Cells[col].ReadOnly = false;

                        if (asientosOcupados.Contains(asiento))
                        {
                            nuevaFila.Cells[col].ReadOnly = true;
                            nuevaFila.Cells[col].Style.BackColor = Color.Gray;
                            nuevaFila.Cells[col].Style.SelectionBackColor = Color.DarkGray;
                            nuevaFila.Cells[col].Style.SelectionForeColor = Color.White;
                        }
                    }
                }

                dtgAsiento.Rows.Add(nuevaFila);
            }

            dtgAsiento.ClearSelection();
        }



    }
}