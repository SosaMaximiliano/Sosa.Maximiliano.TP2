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
                connectionString = "Server = .; Database = SegundoTP; Trusted_Connection = True; Encrypt = False;";
                connection = new SqlConnection(connectionString);

                command = new SqlCommand();

                connection.Open();

                command.Connection = connection;

                command.CommandType = System.Data.CommandType.Text;

                command.CommandText = "SELECT * FROM Participantes3";

                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string nombre = reader.GetString(1);
                    string apellido = reader.GetString(2);
                    string especie = reader.GetString(3);

                    participantes.Add(new Jugador(id,nombre,apellido,especie));
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
                connectionString = "Server = .; Database = SegundoTP; Trusted_Connection = True;Encrypt=False;";
                connection = new SqlConnection(connectionString);

                command = new SqlCommand();

                connection.Open();

                command.Connection = connection;

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
