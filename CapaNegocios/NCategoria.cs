using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    public class NCategoria
    {
        public static string InsertarCategoria(string nombre, string descripcion)
        {
            DCategoria categoria = new DCategoria.Builder()
                .ConNombre(nombre)
                .ConDescripcion(descripcion).Build();
            return categoria.InsertarCategoria(categoria);
            
        }

        public static string EditarCategoria(int idCategoria, string nombre,
            string descripcion)
        {
            DCategoria categoria = new DCategoria.Builder()
                .ConId(idCategoria)
                .ConNombre(nombre)
                .ConDescripcion(descripcion).Build();
            return categoria.EditarCategoria(categoria);

        }

        public static string EliminarCategoria(int idCategoria)
        {
            DCategoria categoria = new DCategoria.Builder()
                .ConId(idCategoria).Build();
            return categoria.EliminarCategoria(categoria);

        }

        public static DataTable MostrarCategoria() => new DCategoria().MostrarCategoria();

        public static DataTable Buscar(string textoBuscado)
        {
            DCategoria categoria = new DCategoria.Builder()
                .ConTexto(textoBuscado).Build();
            return categoria.BuscarCategoria(categoria);
        }
    }
}
