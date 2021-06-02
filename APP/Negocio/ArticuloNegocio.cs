using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {


        public List<Articulo> listar()
        {

            ////select Nombre, P.Descripcion, UrlImagen, T.Descripcion Tipo, D.Descripcion Debilidad from POKEMONS P, ELEMENTOS T, ELEMENTOS D Where P.IdTipo = T.Id and P.IdDebilidad = D.Id


            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();


            try
            {
                //inner entre 2 tablas articulos y marcas
                datos.setearConsulta("select A.Id, A.Codigo CodigoArticulo , A.Nombre , A.Descripcion Descripcion  , A.ImagenUrl UrlImagen, M.Descripcion Marca, A.IdMarca, A.IdCategoria from ARTICULOS A ,MARCAS M  WHERE A.IdMarca = M.Id ");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.CodigoArticulo = (string)datos.Lector["CodigoArticulo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.UrlImagen = (string)datos.Lector["UrlImagen"];
                    aux.marca = new Marca((string)datos.Lector["Marca"]);
                    aux.marca.Id = (int)datos.Lector["IdMarca"];

                    lista.Add(aux);
                }

                return lista; ///fundamental para devolver la lista (si no se pone el listar2 no anda)

            }

            catch (Exception ex)
            {

                throw ex;
            }

            ///Bloque de excepciones
            finally
            {
                datos.cerrarConexion();
            }

        }//Fin listar3()



        public void agregar(Articulo nuevo)
        {

            AccesoDatos datos = new AccesoDatos();

            try
            {


                string valores = "values('" + nuevo.CodigoArticulo + "', '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "', '" + nuevo.UrlImagen + "','" + nuevo.Precio + "','" + nuevo.marca.Id + "',1)";
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, ImagenUrl, Precio, IdMarca, IdCategoria)" + valores);
                datos.ejecutarAccion();
                //ATENCION: de la manera de arriba me tiraba error con el codigo, solo me dejaba poner int.pero es un varchar

                //datos.setearConsulta("update ARTICULOS set Nombre = @nombre, Codigo = @codigo, Descripcion = @descripcion, ImagenUrl = @imagenUrl, IdMarca = @idMarca, IdCategoria = 1 Where Id = @id");
                //datos.setearParametro("@codigo", nuevo.CodigoArticulo);
                //datos.setearParametro("@nombre", nuevo.Nombre);
                //datos.setearParametro("@descripcion", nuevo.Descripcion);
                //datos.setearParametro("@imagenUrl", nuevo.UrlImagen);
                //datos.setearParametro("@idMarca", nuevo.marca.Id);
                //datos.setearParametro("@id", nuevo.Id);

                //datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                datos.cerrarConexion();
            }





        }//cierra agregar


        public void modificar(Articulo modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Nombre = @nombre, Codigo = @codigo, Descripcion = @descripcion, ImagenUrl = @imagenUrl, IdMarca = @idMarca, IdCategoria = 1 Where Id = @id");
                datos.setearParametro("@codigo", modificar.CodigoArticulo);
                datos.setearParametro("@nombre", modificar.Nombre);
                datos.setearParametro("@descripcion", modificar.Descripcion);
                datos.setearParametro("@imagenUrl", modificar.UrlImagen);
                datos.setearParametro("@idMarca", modificar.marca.Id);
                datos.setearParametro("@id", modificar.Id);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Delete From ARTICULOS Where Id = " + id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
                datos = null;
            }
        }
        public void detalle(Articulo detalle)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Descripcion = @descripcion");
                datos.setearParametro("@descripcion", detalle.Descripcion);
                

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }


    }
}
