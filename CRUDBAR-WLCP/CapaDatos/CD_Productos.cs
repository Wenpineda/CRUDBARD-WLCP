using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;




namespace CapaDatos
{
    public class CD_Productos
    {
        private CD_Conexion conexion = new CD_Conexion ();

        SqlDataReader leer;
        DataTable tabla = new DataTable ();
        SqlCommand comando = new SqlCommand();

        public DataTable LeerProductos ()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "LeerProductos";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader ();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(string nombre, string desc, double precio, int cantidad, int estado)
        {
         
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nomprod", nombre);
            comando.Parameters.AddWithValue("@descripcion", desc);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.Parameters.AddWithValue("@estado", cantidad);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public void Actualizar(string nombre, string desc, double precio, int cantidad, int estado, int idproducto)
        {
           
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nomprod", nombre);
            comando.Parameters.AddWithValue("@descripcion", desc);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.Parameters.AddWithValue("@estado", cantidad);
            comando.Parameters.AddWithValue("@idProducto", idproducto);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Borrar(int idproducto)
        {
            
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idprod", idproducto);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

    }
}
