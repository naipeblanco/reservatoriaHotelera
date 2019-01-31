using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ReservaHotel
{
    class Conexion
    {
        public MySqlConnection conexion;

        public Conexion()
        {
            conexion = new MySqlConnection("Server = 127.0.0.1; Database = reservas; Uid = root; Pwd = root; Port = 3306"); 
        }

        public DataTable getClientes()
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("Select * FROM clientes ",conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable clientes = new DataTable();
                clientes.Load(resultado);
                conexion.Close();
                return clientes;
               

            }
            catch(MySqlException e)
            {
                throw e;
            }

        }

        public DataTable getEquipoPorPuntos(String puntos)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("Select * FROM clientes WHERE puntos= '" + puntos + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable equipos = new DataTable();
                equipos.Load(resultado);
                conexion.Close();
                return equipos;


            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public void Actualiza(String dni,String nombre, String web, String ciudad)
        {

            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("UPDATE equipos SET nombre = '"+ nombre +"',web = '" + web + "' ciudad = '" + ciudad+ " WHERE dni = '" + dni + "'" , conexion);
                consulta.ExecuteNonQuery();
                conexion.Close();

            }
            catch (MySqlException e)
            {
                throw e;
            }

        }
    }
}
