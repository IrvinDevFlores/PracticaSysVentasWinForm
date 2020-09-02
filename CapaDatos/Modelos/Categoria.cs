using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Modelos
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public Categoria() { }


         class Builder
         {
            private readonly Categoria _categoria;

            public Builder()
            {
                _categoria = new Categoria();
            }
            public Builder ConId(int id)
            {
                _categoria.IdCategoria = id;
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

            public Categoria Build()
            {
                return _categoria;
            }


        }
    }
}
