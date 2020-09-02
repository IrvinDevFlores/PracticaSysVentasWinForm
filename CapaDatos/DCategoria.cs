using CapaDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class DCategoria
    {
        public int IdCategoria { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public string TextBuscar { get; set; }

        public class Builder
        {
            private readonly DCategoria _categoria;

            public Builder()
            {
                _categoria = new DCategoria();
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

            public DCategoria Build()
            {
                return _categoria;
            }


        }
        public DCategoria() {  }

        public string InsertarCategoria(DCategoria categoria)
        {
            string request = "";
            SqlConnection dbConnection = new SqlConnection();

            try
            {
                dbConnection.ConnectionString = Conexion.stringConnection;
                dbConnection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = dbConnection;
                cmd.CommandText = "insertar_categoria";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter IdCategoriaParam = new SqlParameter();
                IdCategoriaParam.ParameterName = "@idCategoria";
                IdCategoriaParam.SqlDbType = SqlDbType.Int;
                IdCategoriaParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(IdCategoriaParam);

                SqlParameter ParamNombre = new SqlParameter();
                ParamNombre.ParameterName = "@nombre";
                ParamNombre.SqlDbType = SqlDbType.VarChar;
                ParamNombre.Size = 50;
                ParamNombre.Value = categoria.Nombre;
                cmd.Parameters.Add(ParamNombre);

                SqlParameter ParamDescripcion = new SqlParameter();
                ParamDescripcion.ParameterName = "@descripcion";
                ParamDescripcion.SqlDbType = SqlDbType.VarChar;
                ParamDescripcion.Size = 200;
                ParamDescripcion.Value = categoria.Descripcion;
                cmd.Parameters.Add(ParamDescripcion);

                request = cmd.ExecuteNonQuery() == 1 ? "OK" : "no se ingreso";

            }
            catch (Exception e)
            {
                request = e.Message;
            }
            finally
            {
                if (dbConnection.State == ConnectionState.Open)
                    dbConnection.Close();
            }

            return request;

        }

        public string EditarCategoria(DCategoria categoria)
        {
            string request = "";
            SqlConnection dbConnection = new SqlConnection();

            try
            {
                dbConnection.ConnectionString = Conexion.stringConnection;
                dbConnection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = dbConnection;
                cmd.CommandText = "editar_categoria";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter IdCategoriaParam = new SqlParameter();
                IdCategoriaParam.ParameterName = "@idCategoria";
                IdCategoriaParam.SqlDbType = SqlDbType.Int;
                IdCategoriaParam.Value = categoria.IdCategoria;
                cmd.Parameters.Add(IdCategoriaParam);

                SqlParameter ParamNombre = new SqlParameter();
                ParamNombre.ParameterName = "@nombre";
                ParamNombre.Size = 50;
                ParamNombre.Value = categoria.Nombre;
                cmd.Parameters.Add(ParamNombre);

                SqlParameter ParamDescripcion = new SqlParameter();
                ParamDescripcion.ParameterName = "@descripcion";
                ParamDescripcion.SqlDbType = SqlDbType.VarChar;
                ParamDescripcion.Size = 200;
                ParamDescripcion.Value = categoria.Descripcion;
                cmd.Parameters.Add(ParamDescripcion);

                request = cmd.ExecuteNonQuery() == 1 ? "OK" : "no actualizado";

            }
            catch (Exception e)
            {
                request = e.Message;
            }
            finally
            {
                if (dbConnection.State == ConnectionState.Open)
                    dbConnection.Close();
            }

            return request;
        }

        public string EliminarCategoria(DCategoria categoria)
        {
            string request = "";
            SqlConnection dbConnection = new SqlConnection();

            try
            {
                dbConnection.ConnectionString = Conexion.stringConnection;
                dbConnection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = dbConnection;
                cmd.CommandText = "eliminar_Categoria";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter IdCategoriaParam = new SqlParameter();
                IdCategoriaParam.ParameterName = "@idCategoria";
                IdCategoriaParam.SqlDbType = SqlDbType.Int;
                IdCategoriaParam.Value = categoria.IdCategoria;
                cmd.Parameters.Add(IdCategoriaParam);

                request = cmd.ExecuteNonQuery() == 1 ? "ok" : "no eliminado";

            }
            catch (Exception e)
            {
                request = e.Message;
            }
            finally
            {
                if (dbConnection.State == ConnectionState.Open)
                    dbConnection.Close();
            }

            return request;
        }

        public DataTable MostrarCategoria()
        {
            DataTable dataResult = new DataTable("Categoria");
            SqlConnection dbConnection = new SqlConnection();

            try
            {

                dbConnection.ConnectionString = Conexion.stringConnection;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = dbConnection;
                cmd.CommandText = "mostrar_categoria";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
                sqlData.Fill(dataResult);
            }
            catch (Exception e)
            {
                dataResult = null;
            }
            finally
            {
                if (dbConnection.State == ConnectionState.Open)
                    dbConnection.Close();
            }

            return dataResult;
        }

        public DataTable BuscarCategoria(DCategoria categoria)
        {
            DataTable dataResult = new DataTable("Categoria");
            SqlConnection dbConnection = new SqlConnection();

            try
            {

                dbConnection.ConnectionString = Conexion.stringConnection;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = dbConnection;
                cmd.CommandText = "buscar_categoria";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParamTextBuscado = new SqlParameter();
                ParamTextBuscado.ParameterName = "@textoBuscar";
                ParamTextBuscado.SqlDbType = SqlDbType.VarChar;
                ParamTextBuscado.Size = 50;
                ParamTextBuscado.Value = categoria.TextBuscar;
                cmd.Parameters.Add(ParamTextBuscado);

                SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
                sqlData.Fill(dataResult);

            }
            catch (Exception e)
            {
                dataResult = null;
            }
            finally
            {
                if (dbConnection.State == ConnectionState.Open)
                    dbConnection.Close();
            }

            return dataResult;
        }

    }
}
