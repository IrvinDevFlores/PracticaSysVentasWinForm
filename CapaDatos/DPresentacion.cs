using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class DPresentacion
    {
        public int IdCategoria { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public string TextBuscar { get; set; }

        public DPresentacion()  { }

        public class Builder
        {
            private readonly DPresentacion _categoria;

            public Builder()
            {
                _categoria = new DPresentacion();
            }
            public Builder ConId(int id)
            {
                _categoria.IdCategoria = id;
                return this;
            }

            public Builder ConTexto(string texto)
            {
                _categoria.TextBuscar = texto;
                return this;
            }

            public Builder ConNombre(string nombre)
            {
                _categoria.Nombre = nombre;
                return this;
            }
            public Builder ConDescripcion(string descripcion)
            {
                _categoria.Descripcion = descripcion;
                return this;
            }

            public DPresentacion Build()
            {
                return _categoria;
            }


        }
    }
}
