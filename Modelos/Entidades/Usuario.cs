using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Modelos.Entidades
{
    public class Usuario
    {

        //public bool LoginUsuario(string correo, string contraseña)
        //{
        //    using (var conexion = Modelos.Conexion.Conexion.Conectar())
        //    {
        //        conexion.Open();
        //        using (var command = new SqlCommand())
        //        {
        //            command.Connection = conexion;
        //            command.CommandText = "select *from Usuario where fatimaester.dit@gmail.com' and contraseña = 'X93esAA44";
        //            command.Parameters.AddWithValue("fatimaester.dit@gmail.com", correo);
        //            command.Parameters.AddWithValue("X93esAA44", contraseña);
        //            command.CommandType = CommandType.Text;
        //            SqlDataReader reader = command.ExecuteReader();
        //            if (reader.HasRows)
        //            {
        //                return true;
        //            }
        //            else
        //            {
        //                return false;
        //            }
        //        }
        //    }
        //}
        //public class UsuarioLogin
        //{
        //    Usuario usuarioLogin = new UsuarioLogin();

        //}
    }
}
