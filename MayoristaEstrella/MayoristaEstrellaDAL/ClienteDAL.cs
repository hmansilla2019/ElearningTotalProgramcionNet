using MayoristaEstrellaEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace MayoristaEstrellaDAL
{
    public class ClienteDAL
    {
        public static List<Cliente> ListarClientes(string NombreApellido)
        {

            List<Cliente> list = new List<Cliente>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Cnn"].ToString()))
            {
                conn.Open();

                string sql = @"ListarClientes";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NombreApellido", SqlDbType.VarChar).Value = NombreApellido;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(ObtenerCliente(reader));
                }
            }

            return list;


        }


        public static Cliente ObtenerCliente(int Id)
        {

           Cliente cliente = new Cliente();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Cnn"].ToString()))
            {
                conn.Open();

                string sql = @"ObtenerCliente";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cliente = ObtenerCliente(reader);
                }
            }

            return cliente;


        }



        public static Cliente ObtenerCliente(SqlDataReader reader)
        {
            Cliente cliente = new Cliente();

            cliente.Id = Convert.ToInt32(reader["Id"]);
            cliente.NombreApellido = Convert.ToString(reader["NombreApellido"]);
            cliente.Cuit = Convert.ToString(reader["Cuit"]);
            cliente.Domicilio = Convert.ToString(reader["Domicilio"]);
            cliente.Telefono = Convert.ToString(reader["Telefono"]);
            cliente.Mail = Convert.ToString(reader["Mail"]);
            cliente.Localidad = Convert.ToString(reader["Localidad"]);
            cliente.Pais = Convert.ToString(reader["Pais"]);
            cliente.Provincia = Convert.ToString(reader["Provincia"]);
            cliente.FechaNacimiento = Convert.ToDateTime(reader["FecchaNacimiento"]);
            cliente.Nacionalidad = Convert.ToString(reader["Nacionalidad"]);

            return cliente;
        }

        public static Cliente ABMCliente(Cliente cliente)
        {
            Cliente Cliente = cliente;

            try
            {

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Cnn"].ToString()))
                {
                    conn.Open();
                    string sql = string.Empty;
                    if (cliente.Id > 0)
                    {
                        sql = @"MODIFICARCLIENTE";
                    }
                    else
                        sql = @"ALTACLIENTE";


                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.CommandType = CommandType.StoredProcedure;

                    if (cliente.Id > 0)
                    {
                        cmd.Parameters.Add("@Id", SqlDbType.Int).Value = cliente.Id;
                    }

                    cmd.Parameters.Add("@NombreApellido", SqlDbType.VarChar).Value = cliente.NombreApellido;
                    cmd.Parameters.Add("@Cuit", SqlDbType.VarChar).Value = cliente.Cuit;
                    cmd.Parameters.Add("@Domicilio", SqlDbType.VarChar).Value = cliente.Domicilio;
                    cmd.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = cliente.Telefono;
                    cmd.Parameters.Add("@Mail", SqlDbType.VarChar).Value = cliente.Mail;
                    cmd.Parameters.Add ("@Nacionalidad", SqlDbType.VarChar).Value = cliente.Nacionalidad;
                    cmd.Parameters.Add("@FecchaNacimiento", SqlDbType.Date).Value = cliente.FechaNacimiento;
                    cmd.Parameters.Add("@Localidad", SqlDbType.VarChar).Value = cliente.Localidad;
                    cmd.Parameters.Add("@Provincia", SqlDbType.VarChar).Value = cliente.Provincia;
                    cmd.Parameters.Add("@Pais", SqlDbType.VarChar).Value = cliente.Pais;

                    cmd.ExecuteNonQuery();


                    return Cliente;
                }



            }
            catch (Exception Ex)
            {
                return Cliente;

            }
        }

        public static void DeleteCliente(int id)
        {
       
            try
            {

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Cnn"].ToString()))
                {
                    conn.Open();
                    string sql = @"ELIMINARCLIENTE";
                   
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.CommandType = CommandType.StoredProcedure;

                  
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    
                    cmd.ExecuteNonQuery();

                }



            }
            catch (Exception Ex)
            {
           
            }
        }



    }
}
