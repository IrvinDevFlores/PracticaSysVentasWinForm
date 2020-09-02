using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DArticulo
    {
        public int IdArticulo { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte[] Imagen { get; set; }
        public int IdCategoria { get; set; }
        public int IdPresentacion { get; set; }
        private string TextoBuscar { get; set; }
        //Nos quedamos en crear el procedimiento almacenado eliminar leccion 15
        public DArticulo() {}
        public class Builder
        {
            private readonly DArticulo _articulo;

            public Builder()
            {
                _articulo = new DArticulo();
            }
            public Builder ConId(int id)
            {
                _articulo.IdArticulo = id;
                return this;
            }

            public Builder ConTexto(string texto)
            {
                _articulo.TextoBuscar = texto;
                return this;
            }

            public Builder ConNombre(string nombre)
            {
                _articulo.Nombre = nombre;
                return this;
            }
            public Builder ConDescripcion(string descripcion)
            {
                _articulo.Descripcion = descripcion;
                return this;
            }

            public Builder ConImagen(byte[] img)
            {
                _articulo.Imagen = img;
                return this;
            }

            public Builder ConIdCategoria(int id)
            {
                _articulo.IdCategoria = id;
                return this;
            }

            public Builder ConIdPresentacion(int id)
            {
                _articulo.IdPresentacion = id;
                return this;
            }

            public DArticulo Build()
            {
                return _articulo;
            }


        }
    }
}
