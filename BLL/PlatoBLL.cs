using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class PlatoBLL
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

        public static PlatoBLL instance = null;

        public PlatoBLL()
        {

        }

        public static PlatoBLL Getinstancia()
        {
            if (instance == null)
            {
                instance = new PlatoBLL();
            }
            return instance;
        }

        public PlatoBLL(int id_plato,
        String nombre_plato,
        int precio,
        String categoria,
        Byte[] imagen,
        String habilitado,
        int orden_id_orden)

        {
            this.Id_plato = id_plato;
            this.Nombre_plato = nombre_plato;
            this.Precio = precio;
            this.Categoria = categoria;
            this.Imagen = imagen;
            this.Habilitado = habilitado;
            this.descripcion = descripcion;
            this.cantidad = cantidad;
            this.ing_id = ing_id;
            this.orden_id_orden = orden_id_orden;
        }
        public DataTable Get_Orden_espera_plato()
        {
            PlatoDAL plat = new PlatoDAL();
            DataTable dt = plat.get_orden_esp_plat();
            return dt;
        }
        public DataTable Get_Orden_preparacion_plato()
        {
            PlatoDAL plat = new PlatoDAL();
            DataTable dt = plat.get_Orden_preparacion_plato();
            return dt;
        }
        public DataTable Get_Orden_listo_plato()
        {
            PlatoDAL plat = new PlatoDAL();
            DataTable dt = plat.get_Orden_listo_plato();
            return dt;
        }

        public void Alter_plato_Entregado(PlatoBLL objaux)
        {
            PlatoDAL alt = new PlatoDAL();
            alt.Id_plato = this.Id_plato;
            alt.orden_id_orden = this.orden_id_orden;
            alt.alter_plato_Entregado(alt);
        }
        public void Alter_plato_Preparacion(PlatoBLL objaux)
        {
            PlatoDAL alt = new PlatoDAL();
            alt.Id_plato = this.Id_plato;
            alt.orden_id_orden = this.orden_id_orden;
            alt.alter_plato_Preparacion(alt);
        }
        public void Alter_plato_Listo(PlatoBLL objaux)
        {
            PlatoDAL alt = new PlatoDAL();
            alt.Id_plato = this.Id_plato;
            alt.orden_id_orden = this.orden_id_orden;
            alt.alter_plato_Listo(alt);
        }

    }


}