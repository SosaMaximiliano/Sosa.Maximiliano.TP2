using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ParticipantesDB
    {

        string connectionString;
        SqlConnection connection;
        SqlCommand command;

        public List<Jugador> ObtenerJugadores()
        {
            List<Jugador> participantes = new List<Jugador>();
            
            try
            {
                //Guardo la conexion en una variable
                //Creo un objeto de conexion y le paso la direccion por parametro
                connectionString = "Server = .; Database = SegundoTP; Trusted_Connection = True;Encrypt=False;";
                connection = new SqlConnection(connectionString);

                //Puente entre el programa y la DB
                command = new SqlCommand();

                //Abro la conexion
                connection.Open();

                //Le asigno el objeto SqlConnection
                command.Connection = connection;

                //Le digo que va a recibir la query como texto
                command.CommandType = System.Data.CommandType.Text;


                command.CommandText = "SELECT * FROM Participantes";

                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    string nombre = reader.GetString(0);

                    participantes.Add(new Jugador(nombre));
                }

                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }

            }
            catch (Exception ex)
            {
                throw;
            }
            return participantes;
        }

        public void GuardarDatos(string jugador)
        {
            try
            {
                //Guardo la conexion en una variable
                //Creo un objeto de conexion y le paso la direccion por parametro
                connectionString = "Server = .; Database = SegundoTP; Trusted_Connection = True;Encrypt=False;";
                connection = new SqlConnection(connectionString);

                //Puente entre el programa y la DB
                command = new SqlCommand();

                //Abro la conexion
                connection.Open();

                //Le asigno el objeto SqlConnection
                command.Connection = connection;

                //Le digo que va a recibir la query como texto
                command.CommandType = System.Data.CommandType.Text;


                command.CommandText = $"INSERT INTO Ganadores (Nombre) VALUES (@Jugador)";
                command.Parameters.AddWithValue("@Jugador", jugador);

                command.ExecuteNonQuery();

                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
