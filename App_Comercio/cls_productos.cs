using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Diagnostics.Contracts;

namespace App_Comercio
{
    public class cls_productos
    {
        private string str_mensaje;
        SqlCommand con; SqlDataReader Lectura;
        private string str_nombre;
        private string str_existencia;
        private string str_valor_compra;
        private string str_ganancia;
        private string str_categoria;
        private string str_especificaciones;
        private string str_valor_venta;
        private string int_estado;
        private string int_usuario;
        public void fnt_agregar(string codigo, string nombre, string existencia, string valor_compra, string ganancia, string categoria, string especificaciones, string valor_venta, string estado, string usuario )
        {
            try
            {
                cls_conexion objConecta = new cls_conexion();
                SqlCommand con = new SqlCommand("sp_agregarproducto", objConecta.connection);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@codigo", codigo);
                con.Parameters.AddWithValue("@nombre", nombre);
                con.Parameters.AddWithValue("@existencia", existencia);
                con.Parameters.AddWithValue("@valor_compra", valor_compra );
                con.Parameters.AddWithValue("@ganancia", ganancia);
                con.Parameters.AddWithValue("@categoria", categoria);
                con.Parameters.AddWithValue("@especificaciones", especificaciones);
                con.Parameters.AddWithValue("@valor_venta", valor_venta);
                con.Parameters.AddWithValue("@estado", estado);
                con.Parameters.AddWithValue("@usuario", usuario);
                objConecta.connection.Open();
                con.ExecuteNonQuery();
                objConecta.connection.Close();
                str_mensaje = "Registro exitoso";
            }
            catch (Exception) { str_mensaje = "Faltan campos / este registro ya existe"; }
        }

        public void fnt_consultar(string codigo)
        {
            try
            {
                cls_conexion objConecta = new cls_conexion();
                con = new SqlCommand("SP_Consultar", objConecta.connection);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@id", codigo);
                objConecta.connection.Open();
                Lectura = con.ExecuteReader();
                if (Lectura.Read() == true)
                {
                    str_nombre = Convert.ToString(Lectura[0]);
                    str_contacto = Convert.ToString(Lectura[1]);
                    str_correo = Convert.ToString(Lectura[3]);
                    str_direccion = Convert.ToString(Lectura[4]);
                    str_mensaje = "";
                }
            }
            catch (Exception)
            {
                str_mensaje = "No se encontraron registros";
            }
        }
        public string getMensaje() { return this.str_mensaje; }

        public string getNombre() { return this.str_nombre; }

        public string getContacto() { return this.str_contacto; }

        public string getCorreo() { return this.str_correo; }
        public string getDireccion() { return this.str_direccion; }
    }
}