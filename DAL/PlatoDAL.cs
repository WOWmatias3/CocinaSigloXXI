using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PlatoDAL
    {

        public int Id_plato { get; set; }
        public String Nombre_plato { get; set; }
        public int Precio { get; set; }
        public String Categoria { get; set; }
        public Byte[] Imagen { get; set; }
        public String Habilitado { get; set; }
        public double cantidad { get; set; }
        public int ing_id { get; set; }
        public string descripcion { get; set; }
        public int orden_id_orden { get; set; }

        public static PlatoDAL instance = null;

        public PlatoDAL()
        {

        }

        public static PlatoDAL Getinstancia()
        {
            if (instance == null)
            {
                instance = new PlatoDAL();
            }
            return instance;
        }

        public PlatoDAL(int id_plato, String nombre_plato, int precio, String categoria, Byte[] imagen, String habilitado, string descripcion, int orden_id_orden)
        {
            this.Id_plato = id_plato;
            this.Nombre_plato = nombre_plato;
            this.Precio = precio;
            this.Categoria = categoria;
            this.Imagen = imagen;
            this.Habilitado = habilitado;
            this.descripcion = descripcion;
            this.orden_id_orden = orden_id_orden;
        }

        public DataTable get_orden_esp_plat()
        {
            using (OracleConnection con = new Conexion().conexion())
            {
                OracleCommand cm = new OracleCommand("Get_Orden_espera_plato", con);
                cm.BindByName = true;
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                OracleParameter output = cm.Parameters.Add("my_cursor", OracleDbType.RefCursor);
                output.Direction = System.Data.ParameterDirection.ReturnValue;
                con.Open();
                cm.ExecuteNonQuery();

                OracleDataReader reader = ((OracleRefCursor)output.Value).GetDataReader();
                con.Close();
                using (DataTable dt = new DataTable())
                {
                    OracleDataAdapter adapter = new OracleDataAdapter(cm);
                    adapter.Fill(dt);
                    return dt;

                }
            }

        }
        public DataTable get_Orden_preparacion_plato()
        {
            using (OracleConnection con = new Conexion().conexion())
            {
                OracleCommand cm = new OracleCommand("Get_Orden_preparacion_plato", con);
                cm.BindByName = true;
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                OracleParameter output = cm.Parameters.Add("my_cursor", OracleDbType.RefCursor);
                output.Direction = System.Data.ParameterDirection.ReturnValue;
                con.Open();
                cm.ExecuteNonQuery();

                OracleDataReader reader = ((OracleRefCursor)output.Value).GetDataReader();
                con.Close();
                using (DataTable dt = new DataTable())
                {
                    OracleDataAdapter adapter = new OracleDataAdapter(cm);
                    adapter.Fill(dt);
                    return dt;

                }
            }

        }
        public DataTable get_Orden_listo_plato()
        {
            using (OracleConnection con = new Conexion().conexion())
            {
                OracleCommand cm = new OracleCommand("Get_Orden_listo_plato", con);
                cm.BindByName = true;
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                OracleParameter output = cm.Parameters.Add("my_cursor", OracleDbType.RefCursor);
                output.Direction = System.Data.ParameterDirection.ReturnValue;
                con.Open();
                cm.ExecuteNonQuery();

                OracleDataReader reader = ((OracleRefCursor)output.Value).GetDataReader();
                con.Close();
                using (DataTable dt = new DataTable())
                {
                    OracleDataAdapter adapter = new OracleDataAdapter(cm);
                    adapter.Fill(dt);
                    return dt;

                }
            }

        }
        public void alter_plato_Entregado(PlatoDAL objaux)
        {
            try
            {
                using (OracleConnection con = new Conexion().conexion())
                {

                    OracleDataAdapter da = new OracleDataAdapter();
                    OracleCommand cm = new OracleCommand("alter_plato_Entregado", con);
                    cm.BindByName = true;
                    cm.CommandType = System.Data.CommandType.StoredProcedure;
                    cm.Parameters.Add("ide", OracleDbType.Varchar2).Value = Id_plato;
                    cm.Parameters.Add("orden", OracleDbType.Varchar2).Value = orden_id_orden;
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("" + ex);
            }
        }
        public void alter_plato_Preparacion(PlatoDAL objaux)
        {
            try
            {
                using (OracleConnection con = new Conexion().conexion())
                {

                    OracleDataAdapter da = new OracleDataAdapter();
                    OracleCommand cm = new OracleCommand("alter_plato_Preparacion", con);
                    cm.BindByName = true;
                    cm.CommandType = System.Data.CommandType.StoredProcedure;
                    cm.Parameters.Add("ide", OracleDbType.Varchar2).Value = Id_plato;
                    cm.Parameters.Add("orden", OracleDbType.Varchar2).Value = orden_id_orden;
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("" + ex);
            }
        }
        public void alter_plato_Listo(PlatoDAL objaux)
        {
            try
            {
                using (OracleConnection con = new Conexion().conexion())
                {

                    OracleDataAdapter da = new OracleDataAdapter();
                    OracleCommand cm = new OracleCommand("alter_plato_Listo", con);
                    cm.BindByName = true;
                    cm.CommandType = System.Data.CommandType.StoredProcedure;
                    cm.Parameters.Add("ide", OracleDbType.Varchar2).Value = Id_plato;
                    cm.Parameters.Add("orden", OracleDbType.Varchar2).Value = orden_id_orden;
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("" + ex);
            }
        }

    }
}
