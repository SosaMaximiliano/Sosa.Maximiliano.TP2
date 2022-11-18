﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ParticipantesDB
    {
        public List<Jugador> ObtenerJugadores()
        {
            List<Jugador> participantes = new List<Jugador>();
<<<<<<< HEAD
            
            try
=======

            //Guardo la conexion en una variable
            //Creo un objeto de conexion y le paso la direccion por parametro
            string connectionString = "Server = .; Database = SegundoTP; Trusted_Connection = True;Encrypt=False;";
            SqlConnection connection = new SqlConnection(connectionString);

            //Puente entre el programa y la DB
            SqlCommand command = new SqlCommand();

            //Abro la conexion
            connection.Open();

            //Le asigno el objeto SqlConnection
            command.Connection = connection;

            //Le digo que va a recibir la query como texto
            command.CommandType = System.Data.CommandType.Text;


            command.CommandText = "SELECT * FROM Participantes";

            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
>>>>>>> e598e714c54ef100a41f0caddb56c257a4cb988d
            {
                //Guardo la conexion en una variable
                //Creo un objeto de conexion y le paso la direccion por parametro
                string connectionString = "Server = .; Database = SegundoTP; Trusted_Connection = True;Encrypt=False;";
                SqlConnection connection = new SqlConnection(connectionString);

                //Puente entre el programa y la DB
                SqlCommand command = new SqlCommand();

                //Abro la conexion
                connection.Open();

                //Le asigno el objeto SqlConnection
                command.Connection = connection;

                //Le digo que va a recibir la query como texto
                command.CommandType = System.Data.CommandType.Text;


                command.CommandText = "SELECT * FROM Participantes2";

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
    }
}
